using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gmail_Auto_Reg
{
    internal interface ISavingFile
    {
        void SaveAccountsToTxt(string fileName);
        void SaveAccountsToExcel(string fileName);
    }
}
