using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject1.code.control;


namespace TestProject1.code.page
{
    public class MainPage
    {
        public Button loginButton = new Button(By.XPath("//img[@src=\"/Images/design/pagelogin.png\"]"));
    }
}
