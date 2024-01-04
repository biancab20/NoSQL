using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Token
    {
        public string Email { get; set; }
        public string ResetToken { get; set; }
        public DateTime ExpiryTime { get; set; }
    }
}
