using Gmail_Auto_Reg.ExcelMaster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gmail_Auto_Reg.Interfaces
{
    internal interface IExcelExport
    {
        /// <summary>
        /// Создание Excel файла
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns>Полный путь к файлу</returns>
        public string CreateExcelFile(string fileName);

        /// <summary>
        /// Создание наименование столбцов
        /// </summary>
        public void CreateNamedCells(IEnumerable<ExcelCells> cells);

        /// <summary>
        /// Запись данных в указанную колонку (Последующие записи должны быть со сдвигом)
        /// </summary>
        /// <param name="columnId">Id колонки</param>
        /// <param name="data">Данные для записи</param>
        public void WriteDataToColumn(int columnId, string data);
    }
}
