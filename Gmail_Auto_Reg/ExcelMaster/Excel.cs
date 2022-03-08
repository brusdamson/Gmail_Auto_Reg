using Gmail_Auto_Reg.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gmail_Auto_Reg.ExcelMaster
{
    internal class Excel : IExcelExport
    {
        #region IExcelExport implementation
        public string CreateExcelFile(string fileName)
        {
            throw new NotImplementedException();
        }

        public void CreateNamedCells(IEnumerable<ExcelCells> cells)
        {
            throw new NotImplementedException();
        }

        public void WriteDataToColumn(int columnId, string data)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
