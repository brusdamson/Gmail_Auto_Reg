using Gmail_Auto_Reg.Interfaces;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gmail_Auto_Reg.ExcelMaster
{
    internal class ExcelHelper : IExcelExport
    {
        private bool disposedValue;
        private Application _excel;
        private Workbook _workbook;

        public ExcelHelper()
        {
            _excel = new Application();
        }

        #region IExcelExport implementation
        bool IExcelExport.Open(string filePath)
        {
            throw new NotImplementedException();
        }

        bool IExcelExport.Set(string column, int row, object data)
        {
            throw new NotImplementedException();
        }

        void IExcelExport.Save()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region IDisposable implementation
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: освободить управляемое состояние (управляемые объекты)
                }

                // TODO: освободить неуправляемые ресурсы (неуправляемые объекты) и переопределить метод завершения
                // TODO: установить значение NULL для больших полей
                disposedValue = true;
            }
        }

        // // TODO: переопределить метод завершения, только если "Dispose(bool disposing)" содержит код для освобождения неуправляемых ресурсов
        // ~ExcelHelper()
        // {
        //     // Не изменяй этот код. Размести код очистки в методе "Dispose(bool disposing)".
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Не изменяйте этот код. Разместите код очистки в методе "Dispose(bool disposing)".
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
        #endregion

    }
}
