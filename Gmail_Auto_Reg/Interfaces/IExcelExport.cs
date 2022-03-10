using Gmail_Auto_Reg.ExcelMaster;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace Gmail_Auto_Reg.Interfaces
{
    internal interface IExcelExport:IDisposable
    {
        /// <summary>
        /// Открыие excel файла
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        internal bool Open(string filePath);

        /// <summary>
        /// Устанавливает в указанную ячейку указанные данные 
        /// </summary>
        /// <param name="column"></param>
        /// <param name="row"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        internal bool Set(string column, int row, object data);

        internal void Save();
    }
}
