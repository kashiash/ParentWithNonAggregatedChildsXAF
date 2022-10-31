using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParentWithNonAggregatedChildsXAF.Module.BusinessObjects
{
 public   interface ICustomerChild
    {
        Customer Customer { get; set; }

    }
}
