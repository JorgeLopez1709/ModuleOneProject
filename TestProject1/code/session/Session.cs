using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject1.code.factoryBrowser;

namespace TestProject1.code.session
{
    public class Session
    {
        //Instancia privada de la misma clase (Privado s, solo accesible desde una propiedad)
        private static Session instance = null;
        //atributo que se modifica una vez que se tiene una instancia
        private IWebDriver browser;

        //Constructor
        private Session()
        {
            //atributos o configuraciones de la instancia unica.
            browser = FactoryBrowser.Make("Chrome").Create();
        }
        //Propiedad de la clase para crear la instancia u otener la instancia creada    
        public static Session Instance()
        {
            
                if (instance == null)
                    instance = new Session();

                return instance;
           
        }
        public void CloseBrowser()
        {
            instance= null;
            browser.Quit();
        }
        public IWebDriver GetBrowser()
        {
            
                return browser;
            
        }
    }
}
