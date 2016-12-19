using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuliner.Core.Web.Entities
{
    [Serializable]
    public class WebUserEntity
    {
        public Guid UserId { get; set; }
        public string Username { get; set; }
    }
}
