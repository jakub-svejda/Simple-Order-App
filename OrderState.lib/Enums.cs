using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderState.lib
{
    public enum OrderState
    {
        New,
        InProgress,
        Ready,
        Uploaded,
        Invoiced,
        Paid,
        Returned,
        Deleted
    }
}