using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kuliner.Core.Repositories
{
    public interface IRepository
    {
        KulinerEntities DataContext { set; get; }
    }
}
