using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Gmail_Auto_Reg
{
    internal class AutoRegerClient:IBotParams
    {
        private IWebDriver driver;
        private string RuCaptchaToken { get; set; }
        private int CountOfAccounts { get; set; }
        private OutputType TypeOfOutput { get; set; }

        
        public AutoRegerClient(IWebDriver driver, AutoRegerParams @params)
        {
            this.driver = driver;
            SetParams(@params);
        }

        #region IBotParams implementation
        /// <summary>
        /// Сохраняет файл в формате .xls | .xlsx
        /// </summary>
        /// <param name="fileName"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void SaveAccountsToExcel(string fileName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Сохраняет файл в формате .txt
        /// </summary>
        /// <param name="fileName"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void SaveAccountsToTxt(string fileName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Устанавливает конфигурацию
        /// </summary>
        /// <param name="params"></param>
        public void SetParams(AutoRegerParams @params)
        {
            this.RuCaptchaToken = @params.RuCaptchaToken;
            this.CountOfAccounts = @params.CountOfAccount;
            this.TypeOfOutput = @params.TypeOfOutput;
        }
        #endregion

    }
}
