using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kuliner.Core.Repositories
{
    public class OldRowVersionEmptyException : ApplicationException 
    {
        public OldRowVersionEmptyException()
            : base("Old row version cannot be empty.")
        {

        }
    }
}
