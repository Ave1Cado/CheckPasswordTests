using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CheckPassword.Tests
{
    [TestClass]
    public class PasswordValidatorTests
    {
        [TestMethod]
        public void TestPasswordScore1()
        {
            string password = "1234567890";
            int score = CheckPassword.ValidatePassword(password);
            Assert.AreEqual(1, score);
        }

        [TestMethod]
        public void TestPasswordScore2()
        {
            string password = "1234567890a";
            int score = CheckPassword.ValidatePassword(password);
            Assert.AreEqual(3, score);
        }

        [TestMethod]
        public void TestPasswordScore3()
        {
            string password = "1234567890aA";
            int score = CheckPassword.ValidatePassword(password);
            Assert.AreEqual(4, score);
        }

        [TestMethod]
        public void TestPasswordScore4()
        {
            string password = "1234567890aA!";
            int score = CheckPassword.ValidatePassword(password);
            Assert.AreEqual(5, score);
        }

        [TestMethod]
        public void TestPasswordScore5()
        {
            string password = "1234567890aA!12345";
            int score = CheckPassword.ValidatePassword(password);
            Assert.AreEqual(5, score);
        }

        [TestMethod]
        public void TestPasswordScore0()
        {
            string password = "abcdefghij";
            int score = CheckPassword.ValidatePassword(password);
            Assert.AreEqual(1, score);
        }
    }
}
