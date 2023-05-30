using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.code.control
{
    public class TextBox : Control
    {
        public TextBox(By locator) : base(locator)
        { 
        }

        public void SetText(string value)
        {
            FindControl();
            control.Clear();
            control.SendKeys(value);
        }
    }
}
