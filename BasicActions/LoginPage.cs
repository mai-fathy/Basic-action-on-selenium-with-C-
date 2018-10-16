using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using BasicActionsFramework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace BasicActions
{
    public class LoginPage
    {
        public static void LoginAS(string user, string Pass)
        {
            Driver.Instance.FindElement(By.Id("username")).SendKeys(user);
            Driver.Instance.FindElement(By.Id("password")).SendKeys(Pass);
            Driver.Instance.FindElement(By.XPath("/html/body/div[2]/div/div/form/button")).Click();
        }

        public static string GetMSA()
        {
            return Driver.Instance.FindElement(By.Id("flash")).Text; 
        }

        public static DataTable ReadFromExcal(string excalPath, string sheetName)
        {
            string connectionString = @"Provider= Microsoft.ACE.OLEDB.12.0;Data Source=" + excalPath +
                                     ";Extended Properties=Excel 12.0 Xml";// Connection string 
            OleDbConnection excelConnection = new System.Data.OleDb.OleDbConnection(connectionString);
            string excelQuery = "Select * from [" + sheetName + "$]"; // SQl statement  
            OleDbCommand excelCommand = new System.Data.OleDb.OleDbCommand(excelQuery, excelConnection);
            excelConnection.Open(); // open Connection
            OleDbDataReader excelReader;
            excelReader = excelCommand.ExecuteReader(); // excute quary 
            DataTable excelTable = new DataTable();
            excelTable.Load(excelReader); // put the excal data into data table 
            excelConnection.Close();
            return excelTable;
            
        }

        public static void LoginUsingDataDriven()
        {
            DataTable testdata = ReadFromExcal(@"D:\Accounts.xlsx", "Sheet2");
            
            for (int i = 0; i < testdata.Rows.Count; i++)
            {

                string name = testdata.Rows[i][0].ToString();
                string pass = testdata.Rows[i][1].ToString();
                Driver.Instance.FindElement(By.Id("username")).SendKeys(name);
                Driver.Instance.FindElement(By.Id("password")).SendKeys(pass);
                Driver.Instance.FindElement(By.XPath("/html/body/div[2]/div/div/form/button")).Click();
             
            }
            
        }

        public static void LoginWithPageFactory(string user, string pass)
        {
            LoginPageFactory p = new LoginPageFactory();
            PageFactory.InitElements(Driver.Instance , p);
            p.UserName.SendKeys(user);
            p.Password.SendKeys(pass);
            p.Loginbutton.Click();

        }


        public static void LoginWithLoginPageWebEs(string user, string pass)
        {
            LoginPageWebEs P = new LoginPageWebEs();
            P.UserName.SendKeys(user);
            P.Password.SendKeys(pass);
            P.LoginB.Click();
        }

    }

}
