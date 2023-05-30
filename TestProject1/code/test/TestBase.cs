using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.code.page
{
    //[TestClass]
    public class TestBase
    {
        [TestInitialize]
        public void OpenBrowser()
        {
            session.Session.Instance().GetBrowser().Navigate().GoToUrl("http://todo.ly/");
        }

        [TestCleanup]
        public void CloseBrowser()
        {
            session.Session.Instance().CloseBrowser();
        }
    }
}
