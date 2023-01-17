using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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
    }
}
