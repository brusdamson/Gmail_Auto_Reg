using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gmail_Auto_Reg
{
    internal class AutoRegerParams
    {
        public string RuCaptchaToken { get; set; } = "";
        public int CountOfAccount { get; set; }
        public OutputType TypeOfOutput { get; set; }

    }
    internal enum OutputType
    {
        TXT,
        EXCEL,
    }
}
