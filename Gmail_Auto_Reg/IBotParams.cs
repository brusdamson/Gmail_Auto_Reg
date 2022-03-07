using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gmail_Auto_Reg
{
    internal interface IBotParams
    {
        void SetParams(AutoRegerParams @params);
        void SaveAccountsToTxt(string fileName);
        void SaveAccountsToExcel(string fileName);
    }
}
