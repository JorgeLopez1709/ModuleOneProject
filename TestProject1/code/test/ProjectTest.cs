using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestProject1.code.page;
using TestProject1.code.session;

namespace TestProject1.code.test 
{ 
    [TestClass]
    public class ProjectTest : TestBase
    {

        MainPage mainPage = new MainPage();
        LoginSection loginSection = new LoginSection();
        LeftSite leftSite = new LeftSite();
        MenuSection menuSection = new MenuSection();
        RightSection rightSection = new RightSection();
        string projectName = "TestProject";
        string taskName = "TestTask";
        string taskNameUpdated = "TestTask Update";



        [TestMethod]
        public void Test1Login()
        {
            mainPage.loginButton.Click();
            loginSection.Login("jorge.e.lopez.1709@gmail.com", "Pass123");
            Assert.IsTrue(menuSection.logoutButton.IsControlDisplayed(),
                "ERROR !! the login was not successfully, review credentials please");

        }
        [TestMethod]
        public void Test2CreateProject()
        {
            Test1Login();
            leftSite.addNewProjectButton.Click();
            leftSite.projectNameTxtBox.SetText(projectName);
            leftSite.addButton.Click();
            Assert.IsTrue(leftSite.ProjectNameIsDisplayed(projectName), "ERROR!The project was not created");
            


        }

        [TestMethod]
        public void Test3CreateTask()
        {
            Test2CreateProject();
            leftSite.ClickProjectName(projectName);
            Thread.Sleep(3000);
            rightSection.taskNameTxtBox.SetText(taskName);
            rightSection.taskAddButton.Click();
            Assert.IsTrue(rightSection.TaskNameIsDisplayed(taskName), "ERROR!The project was not created");




        }

        [TestMethod]
        public void Test4UpdateTask()
        {
            Test3CreateTask();
            leftSite.ClickProjectName(projectName);
            Thread.Sleep(2000);
            rightSection.ClickTaskName();
            rightSection.taskSubMenuIcon.Click();
            Thread.Sleep(2000);
            rightSection.editButton.Click();
            rightSection.taskNameEditTxtBox.SetText(taskNameUpdated);
            rightSection.saveButton.Click();
            Thread.Sleep(3000);
            Assert.IsTrue(rightSection.TaskNameIsDisplayed(taskNameUpdated), "ERROR!!! The task name was not updated. Please note that a bug ticket has already been created to address this issue.");
        }

        [TestMethod]
        public void Test4UpdateTask2()
        {
            //this test use the workAroun to save the name of the Task by clicking in another area of the webPage.
            Test3CreateTask();
            leftSite.ClickProjectName(projectName);
            Thread.Sleep(2000);
            rightSection.ClickTaskName();
            rightSection.taskSubMenuIcon.Click();
            Thread.Sleep(2000);
            rightSection.editButton.Click();
            rightSection.taskNameEditTxtBox.SetText(taskNameUpdated);
            rightSection.taskAddButton.Click();
            Thread.Sleep(3000);
            Assert.IsTrue(rightSection.TaskNameIsDisplayed(taskNameUpdated), "ERROR!The task Name was not updated");
        }


        [TestMethod]
        public void Test5DeleteTask()
        {
            Test3CreateTask();
            leftSite.ClickProjectName(projectName);
            Thread.Sleep(2000);
            rightSection.ClickTaskName();
            rightSection.taskSubMenuIcon.Click();
            Thread.Sleep(2000);
            rightSection.deleteButton.Click();            
            Thread.Sleep(3000);
            
            Assert.IsFalse(rightSection.DeletedTaskMEssageIsDisplayed(), "ERROR!The Task was not deleted");
  
        }
         [TestMethod]
        public void Test6DeleteProject()
        {
            Test1Login();
            while (leftSite.ProjectNameIsDisplayed(projectName))
            {
                leftSite.ClickProjectName(projectName);
                leftSite.subMenuIcon.Click();
                leftSite.deleteButton.Click();
                Thread.Sleep(1000);
                Session.Instance().GetBrowser().SwitchTo().Alert().Accept();
                Thread.Sleep(1000);
            }
            
            Assert.IsFalse(leftSite.ProjectNameIsDisplayed(projectName), "ERROR!The project was not deleted");

        }

    }
}