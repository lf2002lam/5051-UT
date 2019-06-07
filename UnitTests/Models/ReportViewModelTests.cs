using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW1c.Models;
using System.Collections.Generic;


namespace UnitTests.Models
{
    [TestClass]
    public class ReportViewModelTests
    {
        [TestMethod]
        public void ReportViewModel_Instantiate_Default_Should_Pass() {
            // Arrange            


            // Act           
            var result = new ReportViewModel();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ReportViewModel_NumberOfUsers_Get_Default_Should_Pass() {
            // Arrange            
            var myTest = new ReportViewModel();

            // Act           
            var num_of_users = myTest.NumberOfUsers;

            // Assert
            Assert.AreEqual(0, num_of_users);
        }

        [TestMethod]
        public void ReportViewModel_NumberOfUsers_Set_Default_Should_Pass(){            
            // Arrange            
            var myTest = new ReportViewModel();
            var num_of_users = 60;
            // Act           
            myTest.NumberOfUsers = num_of_users;

            // Assert
            Assert.AreEqual(num_of_users, myTest.NumberOfUsers);
        }

        [TestMethod]
        public void ReportViewModel_LogViewModel_Get_Default_Should_Pass() { }

        [TestMethod]
        public void ReportViewModel_LogViewModel_Set_Default_Should_Pass() { }
 
    }
}
