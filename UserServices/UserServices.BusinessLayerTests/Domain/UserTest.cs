using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineServices.Shared.Exceptions;
using System.Net.Mail;
using UserServices.BusinessLayer;

namespace UserServices.BusinessLayerTests
{
    [TestClass]
    public class UserTest
    {
        User ass = new User { ID = 1, Name = "Assistant", IsActivated = true, Company = "Company 01", Role = Shared.Role.Assistant, Email = "Assistant@gmail.com" };
        User att = new User { ID = 2, Name = "Attendee", IsActivated = true, Company = "Company 02", Role = Shared.Role.Attendee, Email = "Attendee@gmail.com" };
        User tea = new User { ID = 3, Name = "Teacher", IsActivated = true, Company = "Company 03", Role = Shared.Role.Teacher, Email = "Teacher@gmail.com" };
        

        [TestMethod()]
        public void Role_Validation()
        {
            Assert.AreEqual(Shared.Role.Assistant, ass.Role);
            Assert.AreEqual(Shared.Role.Attendee, att.Role);
            Assert.AreEqual(Shared.Role.Teacher, tea.Role);
        }


        [TestMethod()]
        public void IsValid_ThrowsIsNullOrWhiteSpaceException_WhenNullNameIsProvided()
        {
            var us = new Course { Name = null };
            Assert.ThrowsException<IsNullOrWhiteSpaceException>(() => us.IsValid());
        }

        [TestMethod]
        public void IsValid_ThrowsIsNullOrWhiteSpaceException_WhenWhiteSpaceNameIsProvided()
        {
            var us = new Course { Name = " " };
            Assert.ThrowsException<IsNullOrWhiteSpaceException>(() => us.IsValid());
        }

        [TestMethod]
        public void IsValid_ThrowsIsNullOrWhiteSpqceException_WhenEmptyNameIsProvided()
        {
            var us = new Course { Name = "" };
            Assert.ThrowsException<IsNullOrWhiteSpaceException>(() => us.IsValid());
        }


        [TestMethod]
        public void IsValid_Email()
        {
            User noValidEmailUser = new User { ID = 0, Name = "Teacher", IsActivated = true, Company = "Company 03", Role = Shared.Role.Teacher, Email = "Teacher@gmailcom" };


            Assert.IsTrue(ass.ValidateEmail(ass.Email));
            Assert.IsTrue(att.ValidateEmail(att.Email));
            Assert.IsTrue(tea.ValidateEmail(tea.Email));

            Assert.IsFalse(noValidEmailUser.ValidateEmail(noValidEmailUser.Email));

        }
    }
}
