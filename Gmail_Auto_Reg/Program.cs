using mevoronin.RuCaptchaNETClient;
using Gmail_Auto_Reg;
using OpenQA.Selenium.Chrome;
using Gmail_Auto_Reg.ExcelMaster;
using Gmail_Auto_Reg.Interfaces;


using (IExcelExport excelHelper = new ExcelHelper())
{
    if (excelHelper.Open(Path.Combine(Environment.CurrentDirectory, "Ts.xlsx")))
    {
        excelHelper.Set("A", 2, DateTime.Now);
        excelHelper.Save();
        excelHelper.Dispose();
        GC.SuppressFinalize(excelHelper);
    }
}