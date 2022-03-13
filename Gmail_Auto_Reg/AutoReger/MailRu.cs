using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gmail_Auto_Reg
{
    internal class MailRu : AutoRegerClient
    {
        #region XPath
        private const string registerButton = "//a[@class='ph-project ph-project__register svelte-1hiqrvn']";
        #endregion

        public MailRu(IWebDriver driver, AutoRegerParams @params) : base(driver, @params)
        {
            base.driver = driver;
        }
        public void CreateAccounts()
        {
            for (int i = 0; i < CountOfAccounts; i++)
            {
                driver.Navigate().GoToUrl(MailRuUrl);
            }
        }
        
    }
}
