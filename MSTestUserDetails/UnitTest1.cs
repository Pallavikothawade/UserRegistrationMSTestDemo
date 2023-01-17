using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Policy;
using UserRegistrationMSTestDemo;

namespace MSTestUserDetails
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
       [DataRow  (new string[] {"Pallavi","Akanksha","Ankita","Priyansh"},true)]
       [DataRow(new string[] { "pallavi", "akanksha", "ankita", "priyansh" }, false)]

        public void TestMethod1(string[] arr ,bool expected)
        {

           UserDetails userDetails = new UserDetails();
            foreach(string s in arr)
            {
                bool actual= userDetails.FirstNameTestcase(s);
                Assert.AreEqual(actual,expected);
            }
          
        }
        [TestMethod]
        [DataRow(new string[] { "Kohtawade", "Morankar", "Sonje"}, true)]
        [DataRow(new string[] { "kohtawade", "morankar", "sonje" }, false)]

        public void LastName(string[] arr, bool expected)
        {

            UserDetails userDetails = new UserDetails();
            foreach (string s in arr)
            {
                bool actual = userDetails.LastNameTestcase(s);
                Assert.AreEqual(actual, expected);
            }

        }
        [TestMethod]
        [DataRow(new string[] { "abc.xyz@bl.co.in","abc100@gmail.com" }, true)]
        [DataRow(new string[] { "@pallavikohtawade@gmail.com", "amorankargmail.com" }, false)]

        public void Email_Id(string[] arr, bool expected)
        {

            UserDetails userDetails = new UserDetails();
            foreach (string s in arr)
            {
                bool actual = userDetails.Email_IdTestCase(s);
                Assert.AreEqual(actual, expected);
            }

        }
    }
}
