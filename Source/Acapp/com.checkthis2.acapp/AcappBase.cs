using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.checkthis2.acapp
{
    /// <summary>
    /// This class is used as the base for a JSON return message
    /// </summary>
    /// <remarks>
    /// 2014-05-16: Created
    /// </remarks>
    public class AcappBase
    {
        /// <summary>Extra data to be added. This can be almost anything like HTML page, simple string or JSON data</summary>
        public dynamic Data;

        /// <summary>When DoNothing is true there will be no automated action.</summary>
        public Boolean DoNothing;

        /// <summary>Is the user logged on</summary>
        public Boolean LoggedOn;

        /// <summary>When OnLoad is provided the function will be called on load complete</summary>
        public string OnLoad = "";

        /// <summary>The title which will be shown. This is only used when Data doesnt contain a string value (html page)</summary>
        public string PageTitle = "";

        /// <summary>When redirect is provided a new call will be made to this url on complete</summary>
        public string Redirect = "";

        /// <summary>The session of the logged on user</summary>
        public string SessionId;

        /// <summary>The username of the logged on user</summary>
        public string UserName;


        /// <summary>
        /// This method is used to create a basic JSON return object
        /// </summary>
        /// <remarks>
        /// 2014-05-16: Created
        /// </remarks>
        public AcappBase() : this(null) { }

        /// <summary>
        /// This method is used to create a basic JSON return object
        /// </summary>
        /// <remarks>
        /// 2014-05-16: Created
        /// </remarks>
        /// 
        /// <param name="user">Used to identify the logged on user.</param>
        public AcappBase(System.Security.Principal.IPrincipal user)
        {
            if (user != null)
            {
                if (user.Identity.IsAuthenticated)
                {
                    LoggedOn = true;
                    UserName = user.Identity.Name;
                }
            }
        }
    }
}
