using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.code.factoryBrowser
{
    public interface IBrowser
    {
        IWebDriver Create();
    }
}
