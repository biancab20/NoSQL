using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public enum TicketStatus
    {
        Unresolved = 1,
        InProgress,
        Transferred,
        Solved,
        Unknown
    }
}
