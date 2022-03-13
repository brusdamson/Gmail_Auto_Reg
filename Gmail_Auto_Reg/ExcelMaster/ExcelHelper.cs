using Gmail_Auto_Reg.Interfaces;
using Microsoft.Office.Interop.Excel;

namespace Gmail_Auto_Reg.ExcelMaster
{
    internal class ExcelHelper : IExcelExport
    {
        private bool disposedValue;
        private Application _excel;
        private Workbook _workBook;
        private Worksheets _worksheets;
        private string _filepath;

        public ExcelHelper()
        {
            _excel = new Application();
        }

        #region IExcelExport implementation
        bool IExcelExport.Open(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                    _workBook = _excel.Workbooks.Open(filePath);
                else
                {
                    _workBook = _excel.Workbooks.Add();
                    _filepath = filePath;
                }
                return true;
            }
            catch (Exception ex) { 

                Console.WriteLine(ex.Message);
                return false;
            }
      
        }

        bool IExcelExport.Set(string column, int row, object data)
        {
            try
            {
                ((Worksheet)_excel.ActiveSheet).Cells[row, column] = data;
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        void IExcelExport.Save()
        {
            if (!string.IsNullOrEmpty(_filepath))
                _workBook.SaveAs();
            else
                _workBook.Save();
        }
        #endregion

        #region IDisposable implementation
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    Dispose();
                    _workBook.Close(0);
                    _excel.Quit();
                }

                // TODO: освободить неуправляемые ресурсы (неуправляемые объекты) и переопределить метод завершения
                // TODO: установить значение NULL для больших полей
                _excel = null;
                _worksheets = null;
                _workBook = null;
                _filepath = null;
                disposedValue = true;
            }
        }

        // TODO: переопределить метод завершения, только если "Dispose(bool disposing)" содержит код для освобождения неуправляемых ресурсов
        ~ExcelHelper()
        {
            // Не изменяй этот код. Размести код очистки в методе "Dispose(bool disposing)".
            Dispose(disposing: false);
        }

        public void Dispose()
        {
            // Не изменяй этот код. Размести код очистки в методе "Dispose(bool disposing)".
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
        #endregion

    }
}
