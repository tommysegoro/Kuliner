using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuliner.Core.Web
{
    public interface IWebUserController
    {
        Entities.WebUserEntity GetCurrentUser();
    }
}
