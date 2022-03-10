using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gmail_Auto_Reg.Models
{
    internal class Account
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public override string ToString()
        {
            return $"{Login}:{Password}";
        }
    }
}
