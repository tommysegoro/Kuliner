using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kuliner.Core.Repositories
{
    public interface IEntity
    {
        int OldRowVersion { get; set; }
        int NewRowVersion { get; set; }
    }
}
