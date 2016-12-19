using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kuliner.Core.Repositories
{
    public class ConcurrencyControlException : ApplicationException 
    {
        public ConcurrencyControlException()
            : base("Someone else is currently updating this record at the same time. Please refresh the page.")
        {

        }
    }
}
