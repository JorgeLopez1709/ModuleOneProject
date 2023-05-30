using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject1.code.control;

namespace TestProject1.code.page
{
    public class MenuSection
    {
        public Button logoutButton = new Button(By.Id("ctl00_HeaderTopControl1_LinkButtonLogout"));
    }
}
