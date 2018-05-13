using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace Test_Framework
{
    [TestClass]
    public class tstCompany
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCompany AnCompany = new clsCompany();
            //test to see that it exists
            Assert.IsNotNull(AnCompany);
        }
        [TestMethod]
        public void Company_NameOK()
        {
            //create an instance of the class we want to create
             clsCompany AnCompany = new clsCompany();
            //create some test data to assign to the property
            string TestData = "Google";
            //assign the data to the property
            AnCompany.Company_Name = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCompany.Company_Name, TestData);
        }
        [TestMethod]
        public void Company_EmailOK()
        {
            //create an instance of the class we want to create
            clsCompany AnCompany = new clsCompany();
            //create some test data to assign to the property
            string TestData = "google@hotmail.com";
            //assign the data to the property
            AnCompany.Company_Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCompany.Company_Email, TestData);
        }
        [TestMethod]
        public void Company_DescriptionOK()
        {
            //create an instance of the class we want to create
            clsCompany AnCompany = new clsCompany();
            //create some test data to assign to the property
            string TestData = "Google is a great company to work for";
            //assign the data to the property
            AnCompany.Company_Description = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCompany.Company_Description, TestData);
        }
        [TestMethod]
        public void Company_WebsiteOK()
        {
            //create an instance of the class we want to create
            clsCompany AnCompany = new clsCompany();
            //create some test data to assign to the property
            string TestData = "Google.Com";
            //assign the data to the property
            AnCompany.Company_Website = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCompany.Company_Website, TestData);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create 
            clsCompany AnCompany = new clsCompany();
            //string variable to store any error message
            Boolean OK = false;
            //create some test data to pass to the method
            string Company_Name = "Google";
            string Company_Email = "google@hotmail.com";
            string Company_Description = "Google is a great company to work for";
            string Company_Website = "Google.Com";
            //invoke the method 
            OK = AnCompany.Valid(Company_Name, Company_Email, Company_Description, Company_Website);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Company_NameMinLessOne()
        {
            //create an instance of the class we want to create 
            clsCompany AnCompany = new clsCompany();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Company_Name = "";// This should trigger an error
            string Company_Email = "google@hotmail.com";
            string Company_Description = "Google is a great company to work for";
            string Company_Website = "Google.Com";
            //invoke the method 
            OK = AnCompany.Valid(Company_Name, Company_Email, Company_Description, Company_Website);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void Company_NameMin()
        {
            //create an instance of the class we want to create 
            clsCompany AnCompany = new clsCompany();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Company_Name = "a";// This should trigger an Pass
            string Company_Email = "google@hotmail.com";
            string Company_Description = "Google is a great company to work for";
            string Company_Website = "Google.Com";
            //invoke the method 
            OK = AnCompany.Valid(Company_Name, Company_Email, Company_Description, Company_Website);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Company_NameMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsCompany AnCompany = new clsCompany();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Company_Name = "aa";// This should trigger an Pass
            string Company_Email = "google@hotmail.com";
            string Company_Description = "Google is a great company to work for";
            string Company_Website = "Google.Com";
            //invoke the method 
            OK = AnCompany.Valid(Company_Name, Company_Email, Company_Description, Company_Website);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Company_NameMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsCompany AnCompany = new clsCompany();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Company_Name = "aaaaaaaaaaaaaaaaaaaaa";// This should trigger an Pass
            string Company_Email = "google@hotmail.com";
            string Company_Description = "Google is a great company to work for";
            string Company_Website = "Google.Com";
            //invoke the method 
            OK = AnCompany.Valid(Company_Name, Company_Email, Company_Description, Company_Website);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Company_NameMax()
        {
            //create an instance of the class we want to create 
            clsCompany AnCompany = new clsCompany();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Company_Name = "aaaaaaaaaaaaaaaaaaaaaa";// This should trigger an Pass
            string Company_Email = "google@hotmail.com";
            string Company_Description = "Google is a great company to work for";
            string Company_Website = "Google.Com";
            //invoke the method 
            OK = AnCompany.Valid(Company_Name, Company_Email, Company_Description, Company_Website);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Company_NameMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsCompany AnCompany = new clsCompany();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Company_Name = "aaaaaaaaaaaaaaaaaaaaaaa";// This should trigger an Fail
            string Company_Email = "google@hotmail.com";
            string Company_Description = "Google is a great company to work for";
            string Company_Website = "Google.Com";
            //invoke the method 
            OK = AnCompany.Valid(Company_Name, Company_Email, Company_Description, Company_Website);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void Company_EmailMinLessOne()
        {
            //create an instance of the class we want to create 
            clsCompany AnCompany = new clsCompany();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Company_Name = "Google";
            string Company_Email = "";// This should trigger an error
            string Company_Description = "Google is a great company to work for";
            string Company_Website = "Google.Com";
            //invoke the method 
            OK = AnCompany.Valid(Company_Name, Company_Email, Company_Description, Company_Website);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void Company_EmailMin()
        {
            //create an instance of the class we want to create 
            clsCompany AnCompany = new clsCompany();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Company_Name = "Google";
            string Company_Email = "a";// This should trigger an Pass
            string Company_Description = "Google is a great company to work for";
            string Company_Website = "Google.Com";
            //invoke the method 
            OK = AnCompany.Valid(Company_Name, Company_Email, Company_Description, Company_Website);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Company_EmailMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsCompany AnCompany = new clsCompany();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Company_Name = "Google";
            string Company_Email = "aa";// This should trigger an Pass
            string Company_Description = "Google is a great company to work for";
            string Company_Website = "Google.Com";
            //invoke the method 
            OK = AnCompany.Valid(Company_Name, Company_Email, Company_Description, Company_Website);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Company_EmailMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsCompany AnCompany = new clsCompany();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Company_Name = "Google";
            string Company_Email = "aaaaaaaaaaaaaaaaaaaaa";// This should trigger an Pass
            string Company_Description = "Google is a great company to work for";
            string Company_Website = "Google.Com";
            //invoke the method 
            OK = AnCompany.Valid(Company_Name, Company_Email, Company_Description, Company_Website);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Company_EmailMax()
        {
            //create an instance of the class we want to create 
            clsCompany AnCompany = new clsCompany();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Company_Name = "Google";
            string Company_Email = "aaaaaaaaaaaaaaaaaaaaaa";// This should trigger an Pass
            string Company_Description = "Google is a great company to work for";
            string Company_Website = "Google.Com";
            //invoke the method 
            OK = AnCompany.Valid(Company_Name, Company_Email, Company_Description, Company_Website);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Company_EmailMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsCompany AnCompany = new clsCompany();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Company_Name = "Google";
            string Company_Email = "aaaaaaaaaaaaaaaaaaaaaaa";// This should trigger an Fail
            string Company_Description = "Google is a great company to work for";
            string Company_Website = "Google.Com";
            //invoke the method 
            OK = AnCompany.Valid(Company_Name, Company_Email, Company_Description, Company_Website);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void Company_DescriptionMinLessOne()
        {
            //create an instance of the class we want to create 
            clsCompany AnCompany = new clsCompany();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Company_Name = "Runner";
            string Company_Email = "google@hotmail.com";
            string Company_Description = "";// This should trigger an error
            string Company_Website = "Google.Com";
            //invoke the method 
            OK = AnCompany.Valid(Company_Name, Company_Email, Company_Description, Company_Website);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void Company_DescriptionMin()
        {
            //create an instance of the class we want to create 
            clsCompany AnCompany = new clsCompany();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Company_Name = "Runner";
            string Company_Email = "google@hotmail.com";
            string Company_Description = "a";// This should trigger an Pass
            string Company_Website = "Google.Com";
            //invoke the method 
            OK = AnCompany.Valid(Company_Name, Company_Email, Company_Description, Company_Website);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Company_DescriptionMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsCompany AnCompany = new clsCompany();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Company_Name = "Runner";
            string Company_Email = "google@hotmail.com";
            string Company_Description = "aa";// This should trigger an Pass
            string Company_Website = "Google.Com";
            //invoke the method 
            OK = AnCompany.Valid(Company_Name, Company_Email, Company_Description, Company_Website);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Company_DescriptionMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsCompany AnCompany = new clsCompany();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Company_Name = "Runner";
            string Company_Email = "google@hotmail.com";
            string Company_Description = "";// This should trigger an Pass
            Company_Description = Company_Description.PadRight(99, 'a');
            string Company_Website = "Google.Com";
            //invoke the method 
            OK = AnCompany.Valid(Company_Name, Company_Email, Company_Description, Company_Website);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Company_DescriptionMax()
        {
            //create an instance of the class we want to create 
            clsCompany AnCompany = new clsCompany();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Company_Name = "Runner";
            string Company_Email = "google@hotmail.com";
            string Company_Description = "";// This should trigger an Pass
            Company_Description = Company_Description.PadRight(100, 'a');
            string Company_Website = "Google.Com";
            //invoke the method 
            OK = AnCompany.Valid(Company_Name, Company_Email, Company_Description, Company_Website);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Company_DescriptionMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsCompany AnCompany = new clsCompany();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Company_Name = "Runner";
            string Company_Email = "google@hotmail.com";
            string Company_Description = "";// This should trigger an Fail
            Company_Description = Company_Description.PadRight(101, 'a');
            string Company_Website = "Google.Com";
            //invoke the method 
            OK = AnCompany.Valid(Company_Name, Company_Email, Company_Description, Company_Website);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void Company_WebsiteMinLessOne()
        {
            //create an instance of the class we want to create 
            clsCompany AnCompany = new clsCompany();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Company_Name = "Runner";
            string Company_Email = "google@hotmail.com";
            string Company_Description = "Google is a great company to work for";
            string Company_Website = "";// This should trigger an error
            //invoke the method 
            OK = AnCompany.Valid(Company_Name, Company_Email, Company_Description, Company_Website);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void Company_WebsiteMin()
        {
            //create an instance of the class we want to create 
            clsCompany AnCompany = new clsCompany();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Company_Name = "Runner";
            string Company_Email = "google@hotmail.com";
            string Company_Description = "Google is a great company to work for";
            string Company_Website = "a";// This should trigger an Pass
            //invoke the method 
            OK = AnCompany.Valid(Company_Name, Company_Email, Company_Description, Company_Website);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Company_WebsiteMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsCompany AnCompany = new clsCompany();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Company_Name = "Runner";
            string Company_Email = "google@hotmail.com";
            string Company_Description = "Google is a great company to work for";
            string Company_Website = "aa";// This should trigger an Pass
            //invoke the method 
            OK = AnCompany.Valid(Company_Name, Company_Email, Company_Description, Company_Website);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Company_WebsiteMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsCompany AnCompany = new clsCompany();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Company_Name = "Runner";
            string Company_Email = "google@hotmail.com";
            string Company_Description = "Google is a great company to work for";
            string Company_Website = "aaaaaaaaaaaaaaaaaaaaa";// This should trigger an Pass
            //invoke the method 
            OK = AnCompany.Valid(Company_Name, Company_Email, Company_Description, Company_Website);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Company_WebsiteMax()
        {
            //create an instance of the class we want to create 
            clsCompany AnCompany = new clsCompany();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Company_Name = "Runner";
            string Company_Email = "google@hotmail.com";
            string Company_Description = "Google is a great company to work for";
            string Company_Website = "aaaaaaaaaaaaaaaaaaaaaa";// This should trigger an Pass
            //invoke the method 
            OK = AnCompany.Valid(Company_Name, Company_Email, Company_Description, Company_Website);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Company_WebsiteMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsCompany AnCompany = new clsCompany();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Company_Name = "Runner";
            string Company_Email = "google@hotmail.com";
            string Company_Description = "Google is a great company to work for";
            string Company_Website = "aaaaaaaaaaaaaaaaaaaaaaa";// This should trigger an Fail
            //invoke the method 
            OK = AnCompany.Valid(Company_Name, Company_Email, Company_Description, Company_Website);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create 
            clsCompany AnCompany = new clsCompany();
            //boolean variable to store the reslt of the validation
            Boolean Found = false;
            //create some test data to use with the method
            int CompanyId = 1;
            //invoke the method
            Found = AnCompany.Find(CompanyId);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCompanyIdFound()
        {
            //create an instance of the class we want to create 
            clsCompany AnCompany = new clsCompany();
            //boolean variable to store the reslt of the validation
            bool Found = false;
            //boolean variable to records if data is ok (Asume it is)
            bool OK = true;
            //create some test data to use with the method
            int CompanyId = 1;
            //invoke the method
            Found = AnCompany.Find(CompanyId);
            //check the booking NO
            if (AnCompany.CompanyId != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCompany_NameFound()
        {
            //create an instance of the class we want to create 
            clsCompany AnCompany = new clsCompany();
            //boolean variable to store the reslt of the validation
            bool Found = false;
            //boolean variable to records if data is ok (Asume it is)
            bool OK = true;
            //create some test data to use with the method
            int CompanyId = 1;
            //invoke the method
            Found = AnCompany.Find(CompanyId);
            //check the booking NO
            if (AnCompany.Company_Name != "Google")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCompany_EmailFound()
        {
            //create an instance of the class we want to create 
            clsCompany AnCompany = new clsCompany();
            //boolean variable to store the reslt of the validation
            bool Found = false;
            //boolean variable to records if data is ok (Asume it is)
            bool OK = true;
            //create some test data to use with the method
            int CompanyId = 1;
            //invoke the method
            Found = AnCompany.Find(CompanyId);
            //check the booking NO
            if (AnCompany.Company_Email != "google@hotmail.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCompany_DescriptionFound()
        {
            //create an instance of the class we want to create 
            clsCompany AnCompany = new clsCompany();
            //boolean variable to store the reslt of the validation
            bool Found = false;
            //boolean variable to records if data is ok (Asume it is)
            bool OK = true;
            //create some test data to use with the method
            int CompanyId = 1;
            //invoke the method
            Found = AnCompany.Find(CompanyId);
            //check the booking NO
            if (AnCompany.Company_Description != "Google is a great company to work for")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCompany_WebsiteFound()
        {
            //create an instance of the class we want to create 
            clsCompany AnCompany = new clsCompany();
            //boolean variable to store the reslt of the validation
            bool Found = false;
            //boolean variable to records if data is ok (Asume it is)
            bool OK = true;
            //create some test data to use with the method
            int CompanyId = 1;
            //invoke the method
            Found = AnCompany.Find(CompanyId);
            //check the booking NO
            if (AnCompany.Company_Website != "Google.Com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


    }
}
