using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kuliner.Core.Web.Entities;
using System.Web;

namespace Kuliner.Core.Web
{
    public class AspNetSessionWebUserController : IWebUserController
    {
        #region "Methods"
        /// <summary>
        /// Get current user from ASP.NET session.
        /// </summary>
        /// <returns></returns>
        public WebUserEntity GetCurrentUser()
        {
            Entities.WebUserEntity webUser = null;

            if (HttpContext.Current.Session[Constants.WEB_USER_SESSION_NAME] != null)
                webUser = HttpContext.Current.Session[Constants.WEB_USER_SESSION_NAME] as Entities.WebUserEntity;

            return webUser;
        }
        #endregion
    }
}
