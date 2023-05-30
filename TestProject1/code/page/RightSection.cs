using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using TestProject1.code.control;
using TestProject1.code.session;

namespace TestProject1.code.page
{
    public class RightSection
    {
        
        public TextBox taskNameTxtBox = new TextBox(By.Id("NewItemContentInput"));
        public Button taskAddButton = new Button(By.Id("NewItemAddButton"));        
        public Button taskSubMenuIcon = new Button(By.XPath("//div[@class=\"ItemIndicator\"]"));
        public Button editButton = new Button(By.XPath("//ul[@id=\"itemContextMenu\"]//a[@href=\"#edit\"]"));
        public TextBox taskNameEditTxtBox = new TextBox(By.Id("ItemEditTextbox"));//
        public Button saveButton = new Button(By.XPath("//div[@id=\"ItemEditDiv\"]/img[@id=\"ItemEditSubmit\"]"));
        public Button deleteButton = new Button(By.XPath("//ul[@id=\"itemContextMenu\"]//a[@href=\"#delete\"]"));
        
        public Boolean TaskNameIsDisplayed(String nameValue)
        {
            Label taskNameLabel = new Label(By.XPath(String.Format("//div[@class=\"ItemContentDiv\"][text()=\"{0}\"]",nameValue)));
            return taskNameLabel.IsControlDisplayed();
        }
        public Boolean DeletedTaskMEssageIsDisplayed()
        {
            Label deletedTaskMessage = new Label(By.XPath("//div[contains(@id=\"HeaderMessageInfo\") and contains(@style, 'display: block')]"));
            return deletedTaskMessage.IsControlDisplayed();
        }

        public void ClickTaskName()
        {
            Label taskNameLabel = new Label(By.XPath("//td[@class=\"ItemContent\"]"));
            taskNameLabel.Click();
        }
        
    }
}
