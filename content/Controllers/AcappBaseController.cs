using System;
using System.IO;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using com.checkthis2.acapp;

namespace ACAPP.Controllers
{
    public class AcappBaseController : Controller
    {
        /// <summary>
        /// generate a view and return as string
        /// </summary>
        /// <remarks>
        /// 2014-05-16: Created
        /// </remarks>
        public string ViewToString(string viewName, object model)
        {
            ViewData.Model = model;
            using (var sw = new StringWriter())
            {
                var viewResult = ViewEngines.Engines.FindPartialView(ControllerContext, viewName);
                var viewContext = new ViewContext(ControllerContext, viewResult.View, ViewData, TempData, sw);
                viewResult.View.Render(viewContext, sw);
                viewResult.ViewEngine.ReleaseView(ControllerContext, viewResult.View);
                return sw.GetStringBuilder().ToString();
            }
        }

        /// <summary>
        /// Generate a JSON result.
        /// </summary>
        /// <remark>
        /// This function allowes for larger responds. The standard response would generate an error on very large forms
        /// </remark>
        /// <remarks>
        /// 2013-05-16: Created
        /// </remarks>
        public ContentResult JsonSerialized(AcappBase result)
        {
            if (result == null)
                return null;

            //result.UpdateNotification();

            var serializer = new JavaScriptSerializer { MaxJsonLength = Int32.MaxValue };
            return new ContentResult
            {
                Content = serializer.Serialize(result),
                ContentType = "application/json"
            };
        }

    }
}
