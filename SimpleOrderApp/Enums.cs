using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleOrderApp
{
    public enum State
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