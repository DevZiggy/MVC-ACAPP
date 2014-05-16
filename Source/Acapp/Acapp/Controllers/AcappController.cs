using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using com.checkthis2.acapp;

namespace ACAPP.Controllers
{
    public class AcappController : AcappBaseController
    {
        /// <summary>
        /// The base of ACAPP. 
        /// It will load the HTML layout and should be the only page that doesnt return a JSON result to be processed.
        /// This should only define the layout and should not include content.
        /// Menu's/tabs/pages/content should all be loaded with AJAX after the initial load
        /// </summary>
        /// <remarks>
        /// 2014-05-16: Created
        /// </remarks>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// The default content (homepage)
        /// </summary>
        /// <remarks>
        /// 2014-05-16: Created
        /// </remarks>
        public ActionResult Home()
        {
            var result = new AcappBase();

            return JsonSerialized(result);
        }


    }
}
