using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gmail_Auto_Reg.ExcelMaster;
using Gmail_Auto_Reg.Interfaces;
using Gmail_Auto_Reg.Models;
using OpenQA.Selenium;

namespace Gmail_Auto_Reg
{
    internal abstract class AutoRegerClient : IBotParams, ISavingFile
    {
        #region configs
        protected string RuCaptchaToken { get; set; }
        protected int CountOfAccounts { get; set; }

        protected Account[] accounts;
        protected OutputType TypeOfOutput { get; set; }
        #endregion
        protected IWebDriver driver;
        private IExcelExport excelExport;

        protected const string MailRuUrl = "https://mail.ru/";

        public AutoRegerClient(IWebDriver driver, AutoRegerParams @params)
        {
            this.SetParams(@params);
            this.excelExport = new ExcelHelper();
            this.driver = driver;
            this.accounts = new Account[CountOfAccounts];
        }

        #region ISaving implementation

        /// <summary>
        /// Сохраняет файл в формате .xls | .xlsx
        /// </summary>
        /// <param name="fileName"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void SaveAccountsToExcel(string filePath)
        {
            
            if (excelExport.Open(filePath))
            {
                //Добавление наименований
                excelExport.Set("A", 1, "Логин");
                excelExport.Set("B", 2, "Пароль");
                //Добавление данных в таблицу
                for (int i = 0; i < accounts.Length; i++)
                {
                    excelExport.Set("A", i + 1, accounts[i].Login);//i + 1 т.к. 0-вая строка - наименование столбцов
                    excelExport.Set("B", i + 1, accounts[i].Password);
                }
                //Сохранение таблицы
                excelExport.Save();
                //Освобождение ресурсов
                excelExport.Dispose();
            }
        }

        /// <summary>
        /// Сохраняет файл в формате .txt
        /// </summary>
        /// <param name="fileName"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void SaveAccountsToTxt(string filePath)
        {
            using (StreamWriter wr = new StreamWriter(filePath, true))
            {
                for (int i = 0; i < accounts.Length; i++)
                    wr.WriteLine(accounts[i].ToString());
            }
        }
        #endregion


        #region IBotParams implementation
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
