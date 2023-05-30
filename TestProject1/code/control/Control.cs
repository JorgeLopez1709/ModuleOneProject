using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject1.code.session;

namespace TestProject1.code.control
{
    public class Control
    {
        protected By locator;
        protected IWebElement control;
        public Control(By locator)
        {
            this.locator = locator;
        }

        protected void FindControl()
        {
            control = Session.Instance().GetBrowser().FindElement(locator);
        }
        public void Click()
        {
            FindControl();
            control.Click();
        }

        public Boolean IsControlDisplayed()
        {
            try
            {
                FindControl();
                return control.Displayed;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
