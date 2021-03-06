﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace Test_Framework
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(AnCustomer);
        }
        [TestMethod]
        public void First_NameOK()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Abdi";
            //assign the data to the property
            AnCustomer.First_Name = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.First_Name, TestData);
        }
        [TestMethod]
        public void Last_NameOK()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Hussein";
            //assign the data to the property
            AnCustomer.Last_Name = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Last_Name, TestData);
        }
        [TestMethod]
        public void EmailOK()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "husseinfinland94@hotmail.com";
            //assign the data to the property
            AnCustomer.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Email, TestData);
        }
        [TestMethod]
        public void AddressOK()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "135 Sandhills Avenue";
            //assign the data to the property
            AnCustomer.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Address, TestData);
        }
        [TestMethod]
        public void PostcodeOK()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "LE5 1QN";
            //assign the data to the property
            AnCustomer.Postcode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Postcode, TestData);
        }
        [TestMethod]
        public void PasswordOK()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Password";
            //assign the data to the property
            AnCustomer.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Password, TestData);
        }
        [TestMethod]
        public void AgeOK()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            String TestData = "23";
            //assign the data to the property 
            AnCustomer.Age = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Age, TestData);
        }
        [TestMethod]
        public void Phone_NumberOK()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "07947491403";
            //assign the data to the property
            AnCustomer.Phone_Number = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Phone_Number, TestData);
        }
        [TestMethod]
        public void User_CV()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "CV IMAGE";
            //assign the data to the property
            AnCustomer.User_CV = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.User_CV, TestData);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            Boolean OK = false;
            //create some test data to pass to the method
            string First_Name = "abdi";
            string Last_Name = "Hussein";
            string Email = "Husseinfinland94@hotmail.com";
            string Address = "135 Sandhills avenue";
            string Postcode = "LE5 1QN";
            string Password = "Password";
            string Age = "23";
            string Phone_Number = "07947491403";
            string User_CV = "CV Image";
            //invoke the method 
            OK = AnCustomer.Valid(First_Name, Last_Name, Email, Address, Postcode, Password, Age, Phone_Number, User_CV);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void First_NameMinLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string First_Name = "";//This should trigger an error
            string Last_Name = "Hussein";
            string Email = "Husseinfinland94@hotmail.com";
            string Address = "135 Sandhills avenue";
            string Postcode = "LE5 1QN";
            string Password = "Password";
            string Age = "23";
            string Phone_Number = "07947491403";
            string User_CV = "CV IMAGE";
            //invoke the method 
            OK = AnCustomer.Valid(First_Name, Last_Name, Email, Address, Postcode, Password, Age, Phone_Number, User_CV);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void First_NameMin()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string First_Name = "a";//This should trigger an pass
            string Last_Name = "Hussein";
            string Email = "Husseinfinland94@hotmail.com";
            string Address = "135 Sandhills avenue";
            string Postcode = "LE5 1QN";
            string Password = "Password";
            string Age = "23";
            string Phone_Number = "07947491403";
            string User_CV = "CV IMAGE";
            //invoke the method 
            OK = AnCustomer.Valid(First_Name, Last_Name, Email, Address, Postcode, Password, Age, Phone_Number, User_CV);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void First_NameMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string First_Name = "ab";//This should trigger an pass
            string Last_Name = "Hussein";
            string Email = "Husseinfinland94@hotmail.com";
            string Address = "135 Sandhills avenue";
            string Postcode = "LE5 1QN";
            string Password = "Password";
            string Age = "23";
            string Phone_Number = "07947491403";
            string User_CV = "CV IMAGE";
            //invoke the method 
            OK = AnCustomer.Valid(First_Name, Last_Name, Email, Address, Postcode, Password, Age, Phone_Number, User_CV);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void First_NameMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string First_Name = "aaaaaaaaaaaaaaaaaaaaa";//This should trigger an pass
            string Last_Name = "Hussein";
            string Email = "Husseinfinland94@hotmail.com";
            string Address = "135 Sandhills avenue";
            string Postcode = "LE5 1QN";
            string Password = "Password";
            string Age = "23";
            string Phone_Number = "07947491403";
            string User_CV = "CV IMAGE";
            //invoke the method 
            OK = AnCustomer.Valid(First_Name, Last_Name, Email, Address, Postcode, Password, Age, Phone_Number, User_CV);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void First_NameMax()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string First_Name = "aaaaaaaaaaaaaaaaaaaaaa";//This should trigger an pass
            string Last_Name = "Hussein";
            string Email = "Husseinfinland94@hotmail.com";
            string Address = "135 Sandhills avenue";
            string Postcode = "LE5 1QN";
            string Password = "Password";
            string Age = "23";
            string Phone_Number = "07947491403";
            string User_CV = "CV IMAGE";
            //invoke the method 
            OK = AnCustomer.Valid(First_Name, Last_Name, Email, Address, Postcode, Password, Age, Phone_Number, User_CV);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void First_NameMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string First_Name = "aaaaaaaaaaaaaaaaaaaaaaa";//This should trigger an Fail
            string Last_Name = "Hussein";
            string Email = "Husseinfinland94@hotmail.com";
            string Address = "135 Sandhills avenue";
            string Postcode = "LE5 1QN";
            string Password = "Password";
            string Age = "23";
            string Phone_Number = "07947491403";
            string User_CV = "CV IMAGE";
            //invoke the method 
            OK = AnCustomer.Valid(First_Name, Last_Name, Email, Address, Postcode, Password, Age, Phone_Number, User_CV);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void First_NameMid()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string First_Name = "aaaaaaaaaaa";//This should trigger an pass
            string Last_Name = "Hussein";
            string Email = "Husseinfinland94@hotmail.com";
            string Address = "135 Sandhills avenue";
            string Postcode = "LE5 1QN";
            string Password = "Password";
            string Age = "23";
            string Phone_Number = "07947491403";
            string User_CV = "CV IMAGE";
            //invoke the method 
            OK = AnCustomer.Valid(First_Name, Last_Name, Email, Address, Postcode, Password, Age, Phone_Number, User_CV);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void First_NameExtremeMax()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string First_Name = "";
            First_Name = First_Name.PadRight(90, 'a');//This should trigger an Fail
            string Last_Name = "Hussein";
            string Email = "Husseinfinland94@hotmail.com";
            string Address = "135 Sandhills avenue";
            string Postcode = "LE5 1QN";
            string Password = "Password";
            string Age = "23";
            string Phone_Number = "07947491403";
            string User_CV = "CV IMAGE";
            //invoke the method 
            OK = AnCustomer.Valid(First_Name, Last_Name, Email, Address, Postcode, Password, Age, Phone_Number, User_CV);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }


        [TestMethod]
        public void Last_NameMinLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string First_Name = "abdi";
            string Last_Name = "";//This should trigger an error
            string Email = "Husseinfinland94@hotmail.com";
            string Address = "135 Sandhills avenue";
            string Postcode = "LE5 1QN";
            string Password = "Password";
            string Age = "23";
            string Phone_Number = "07947491403";
            string User_CV = "CV IMAGE";
            //invoke the method 
            OK = AnCustomer.Valid(First_Name, Last_Name, Email, Address, Postcode, Password, Age, Phone_Number, User_CV);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void Last_NameMin()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string First_Name = "abdi";
            string Last_Name = "a";//This should trigger an pass
            string Email = "Husseinfinland94@hotmail.com";
            string Address = "135 Sandhills avenue";
            string Postcode = "LE5 1QN";
            string Password = "Password";
            string Age = "23";
            string Phone_Number = "07947491403";
            string User_CV = "CV IMAGE";
            //invoke the method 
            OK = AnCustomer.Valid(First_Name, Last_Name, Email, Address, Postcode, Password, Age, Phone_Number, User_CV);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Last_NameMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string First_Name = "abdi";
            string Last_Name = "aa";//This should trigger an pass
            string Email = "Husseinfinland94@hotmail.com";
            string Address = "135 Sandhills avenue";
            string Postcode = "LE5 1QN";
            string Password = "Password";
            string Age = "23";
            string Phone_Number = "07947491403";
            string User_CV = "CV IMAGE";
            //invoke the method 
            OK = AnCustomer.Valid(First_Name, Last_Name, Email, Address, Postcode, Password, Age, Phone_Number, User_CV);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Last_NameMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string First_Name = "abdi";
            string Last_Name = "aaaaaaaaaaaaaaaaaaaaa";//This should trigger an pass
            string Email = "Husseinfinland94@hotmail.com";
            string Address = "135 Sandhills avenue";
            string Postcode = "LE5 1QN";
            string Password = "Password";
            string Age = "23";
            string Phone_Number = "07947491403";
            string User_CV = "CV IMAGE";
            //invoke the method 
            OK = AnCustomer.Valid(First_Name, Last_Name, Email, Address, Postcode, Password, Age, Phone_Number, User_CV);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Last_NameMax()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string First_Name = "abdi";
            string Last_Name = "aaaaaaaaaaaaaaaaaaaaaa";//This should trigger an pass
            string Email = "Husseinfinland94@hotmail.com";
            string Address = "135 Sandhills avenue";
            string Postcode = "LE5 1QN";
            string Password = "Password";
            string Age = "23";
            string Phone_Number = "07947491403";
            string User_CV = "CV IMAGE";
            //invoke the method 
            OK = AnCustomer.Valid(First_Name, Last_Name, Email, Address, Postcode, Password, Age, Phone_Number, User_CV);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Last_NameMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string First_Name = "abdi";
            string Last_Name = "aaaaaaaaaaaaaaaaaaaaaaa";//This should trigger an Fail
            string Email = "Husseinfinland94@hotmail.com";
            string Address = "135 Sandhills avenue";
            string Postcode = "LE5 1QN";
            string Password = "Password";
            string Age = "23";
            string Phone_Number = "07947491403";
            string User_CV = "CV IMAGE";
            //invoke the method 
            OK = AnCustomer.Valid(First_Name, Last_Name, Email, Address, Postcode, Password, Age, Phone_Number, User_CV);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void Last_NameMid()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string First_Name = "abdi";
            string Last_Name = "aaaaaaaaaaa";//This should trigger an pass
            string Email = "Husseinfinland94@hotmail.com";
            string Address = "135 Sandhills avenue";
            string Postcode = "LE5 1QN";
            string Password = "Password";
            string Age = "23";
            string Phone_Number = "07947491403";
            string User_CV = "CV IMAGE";
            //invoke the method 
            OK = AnCustomer.Valid(First_Name, Last_Name, Email, Address, Postcode, Password, Age, Phone_Number, User_CV);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Last_NameExtremeMax()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string First_Name = "abdi";
            string Last_Name = "";
            Last_Name = Last_Name.PadRight(90, 'a');//This should trigger an Fail
            string Email = "Husseinfinland94@hotmail.com";
            string Address = "135 Sandhills avenue";
            string Postcode = "LE5 1QN";
            string Password = "Password";
            string Age = "23";
            string Phone_Number = "07947491403";
            string User_CV = "CV IMAGE";
            //invoke the method 
            OK = AnCustomer.Valid(First_Name, Last_Name, Email, Address, Postcode, Password, Age, Phone_Number, User_CV);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void EmailLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string First_Name = "abdi";
            string Last_Name = "a";
            string Email = "";//This should trigger an error
            string Address = "135 Sandhills avenue";
            string Postcode = "LE5 1QN";
            string Password = "Password";
            string Age = "23";
            string Phone_Number = "07947491403";
            string User_CV = "CV IMAGE";
            //invoke the method 
            OK = AnCustomer.Valid(First_Name, Last_Name, Email, Address, Postcode, Password, Age, Phone_Number, User_CV);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void EmailMin()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string First_Name = "abdi";
            string Last_Name = "a";//This should trigger an pass
            string Email = "a";
            string Address = "135 Sandhills avenue";
            string Postcode = "LE5 1QN";
            string Password = "Password";
            string Age = "23";
            string Phone_Number = "07947491403";
            string User_CV = "CV IMAGE";
            //invoke the method 
            OK = AnCustomer.Valid(First_Name, Last_Name, Email, Address, Postcode, Password, Age, Phone_Number, User_CV);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string First_Name = "abdi";
            string Last_Name = "aa";
            string Email = "aa";//This should trigger an pass
            string Address = "135 Sandhills avenue";
            string Postcode = "LE5 1QN";
            string Password = "Password";
            string Age = "23";
            string Phone_Number = "07947491403";
            string User_CV = "CV IMAGE";
            //invoke the method 
            OK = AnCustomer.Valid(First_Name, Last_Name, Email, Address, Postcode, Password, Age, Phone_Number, User_CV);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void EmailMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string First_Name = "abdi";
            string Last_Name = "aaaaaaaaaaaaaaaaaaaaa";
            string Email = "aaaaaaaaaaaaaaaaaaaaa";//This should trigger an pass
            string Address = "135 Sandhills avenue";
            string Postcode = "LE5 1QN";
            string Password = "Password";
            string Age = "23";
            string Phone_Number = "07947491403";
            string User_CV = "CV IMAGE";
            //invoke the method 
            OK = AnCustomer.Valid(First_Name, Last_Name, Email, Address, Postcode, Password, Age, Phone_Number, User_CV);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void EmailMax()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string First_Name = "abdi";
            string Last_Name = "aaaaaaaaaaaaaaaaaaaaaa";//This should trigger an pass
            string Email = "aaaaaaaaaaaaaaaaaaaaaa";
            string Address = "135 Sandhills avenue";
            string Postcode = "LE5 1QN";
            string Password = "Password";
            string Age = "23";
            string Phone_Number = "07947491403";
            string User_CV = "CV IMAGE";
            //invoke the method 
            OK = AnCustomer.Valid(First_Name, Last_Name, Email, Address, Postcode, Password, Age, Phone_Number, User_CV);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void EmailPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string First_Name = "abdi";
            string Last_Name = "aaaaaaaaaaaaaaaaaaaaaaa";
            string Email = "aaaaaaaaaaaaaaaaaaaaaaa";//This should trigger an Fail
            string Address = "135 Sandhills avenue";
            string Postcode = "LE5 1QN";
            string Password = "Password";
            string Age = "23";
            string Phone_Number = "07947491403";
            string User_CV = "CV IMAGE";
            //invoke the method 
            OK = AnCustomer.Valid(First_Name, Last_Name, Email, Address, Postcode, Password, Age, Phone_Number, User_CV);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void EmailMid()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string First_Name = "abdi";
            string Last_Name = "aaaaaaaaaaa";
            string Email = "aaaaaaaaaaa";//This should trigger an pass
            string Address = "135 Sandhills avenue";
            string Postcode = "LE5 1QN";
            string Password = "Password";
            string Age = "23";
            string Phone_Number = "07947491403";
            string User_CV = "CV IMAGE";
            //invoke the method 
            OK = AnCustomer.Valid(First_Name, Last_Name, Email, Address, Postcode, Password, Age, Phone_Number, User_CV);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void EmailExtremeMax()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string First_Name = "abdi";
            string Last_Name = "Hussein";
            string Email = "";
            Email = Email.PadRight(90, 'a');//This should trigger an Fail
            string Address = "135 Sandhills avenue";
            string Postcode = "LE5 1QN";
            string Password = "Password";
            string Age = "23";
            string Phone_Number = "07947491403";
            string User_CV = "CV IMAGE";
            //invoke the method 
            OK = AnCustomer.Valid(First_Name, Last_Name, Email, Address, Postcode, Password, Age, Phone_Number, User_CV);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void AddressLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string First_Name = "abdi";
            string Last_Name = "a";
            string Email = "a";
            string Address = "";//This should trigger an error
            string Postcode = "LE5 1QN";
            string Password = "Password";
            string Age = "23";
            string Phone_Number = "07947491403";
            string User_CV = "CV IMAGE";
            //invoke the method 
            OK = AnCustomer.Valid(First_Name, Last_Name, Email, Address, Postcode, Password, Age, Phone_Number, User_CV);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void AddressMin()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string First_Name = "abdi";
            string Last_Name = "a";
            string Email = "a";
            string Address = "a";//This should trigger an pass
            string Postcode = "LE5 1QN";
            string Password = "Password";
            string Age = "23";
            string Phone_Number = "07947491403";
            string User_CV = "CV IMAGE";
            //invoke the method 
            OK = AnCustomer.Valid(First_Name, Last_Name, Email, Address, Postcode, Password, Age, Phone_Number, User_CV);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AddressMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string First_Name = "abdi";
            string Last_Name = "aa";
            string Email = "aa";
            string Address = "aa";//This should trigger an pass
            string Postcode = "LE5 1QN";
            string Password = "Password";
            string Age = "23";
            string Phone_Number = "07947491403";
            string User_CV = "CV IMAGE";
            //invoke the method 
            OK = AnCustomer.Valid(First_Name, Last_Name, Email, Address, Postcode, Password, Age, Phone_Number, User_CV);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AddressMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string First_Name = "abdi";
            string Last_Name = "aaaaaaaaaaaaaaaaaaaaa";
            string Email = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            string Address = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";//This should trigger an pass
            string Postcode = "LE5 1QN";
            string Password = "Password";
            string Age = "23";
            string Phone_Number = "07947491403";
            string User_CV = "CV IMAGE";
            //invoke the method 
            OK = AnCustomer.Valid(First_Name, Last_Name, Email, Address, Postcode, Password, Age, Phone_Number, User_CV);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AddressMax()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string First_Name = "abdi";
            string Last_Name = "aaaaaaaaaaaaaaaaaaaaaa";
            string Email = "aaaaaaaaaaaaaaaaaaaaaa";
            string Address = "aaaaaaaaaaaaaaaaaaaaaa";//This should trigger an pass
            string Postcode = "LE5 1QN";
            string Password = "Password";
            string Age = "23";
            string Phone_Number = "07947491403";
            string User_CV = "CV IMAGE";
            //invoke the method 
            OK = AnCustomer.Valid(First_Name, Last_Name, Email, Address, Postcode, Password, Age, Phone_Number, User_CV);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AddressPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string First_Name = "abdi";
            string Last_Name = "aaaaaaaaaaaaaaaaaaaaaaa";
            string Email = "aaaaaaaaaaaaaaaaaaaaaaa";
            string Address = "aaaaaaaaaaaaaaaaaaaaaaa";//This should trigger an Fail
            string Postcode = "LE5 1QN";
            string Password = "Password";
            string Age = "23";
            string Phone_Number = "07947491403";
            string User_CV = "CV IMAGE";
            //invoke the method 
            OK = AnCustomer.Valid(First_Name, Last_Name, Email, Address, Postcode, Password, Age, Phone_Number, User_CV);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void AddressMid()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string First_Name = "abdi";
            string Last_Name = "aaaaaaaaaaa";
            string Email = "aaaaaaaaaaa";
            string Address = "aaaaaaaaaaa";//This should trigger an pass
            string Postcode = "LE5 1QN";
            string Password = "Password";
            string Age = "23";
            string Phone_Number = "07947491403";
            string User_CV = "CV IMAGE";
            //invoke the method 
            OK = AnCustomer.Valid(First_Name, Last_Name, Email, Address, Postcode, Password, Age, Phone_Number, User_CV);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AddressExtremeMax()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string First_Name = "abdi";
            string Last_Name = "Hussein";
            string Email = "aa";
            string Address = "";
            Address = Address.PadRight(90, 'a');//This should trigger an Fail
            string Postcode = "LE5 1QN";
            string Password = "Password";
            string Age = "23";
            string Phone_Number = "07947491403";
            string User_CV = "CV IMAGE";
            //invoke the method 
            OK = AnCustomer.Valid(First_Name, Last_Name, Email, Address, Postcode, Password, Age, Phone_Number, User_CV);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }


        [TestMethod]
        public void PostcodeMinLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string First_Name = "a";
            string Last_Name = "Hussein";
            string Email = "Husseinfinland94@hotmail.com";
            string Address = "135 Sandhills avenue";
            string Postcode = "";//This should trigger an error
            string Password = "Password";
            string Age = "23";
            string Phone_Number = "07947491403";
            string User_CV = "CV IMAGE";
            //invoke the method 
            OK = AnCustomer.Valid(First_Name, Last_Name, Email, Address, Postcode, Password, Age, Phone_Number, User_CV);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void PostcodeMin()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string First_Name = "a";
            string Last_Name = "Hussein";
            string Email = "Husseinfinland94@hotmail.com";
            string Address = "135 Sandhills avenue";
            string Postcode = "a";//This should trigger an pass
            string Password = "Password";
            string Age = "23";
            string Phone_Number = "07947491403";
            string User_CV = "CV IMAGE";
            //invoke the method 
            OK = AnCustomer.Valid(First_Name, Last_Name, Email, Address, Postcode, Password, Age, Phone_Number, User_CV);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PostcodeMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string First_Name = "ab";
            string Last_Name = "Hussein";
            string Email = "Husseinfinland94@hotmail.com";
            string Address = "135 Sandhills avenue";
            string Postcode = "aa";//This should trigger an pass
            string Password = "Password";
            string Age = "23";
            string Phone_Number = "07947491403";
            string User_CV = "CV IMAGE";
            //invoke the method 
            OK = AnCustomer.Valid(First_Name, Last_Name, Email, Address, Postcode, Password, Age, Phone_Number, User_CV);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PostcodeMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string First_Name = "aaaaaaaaaaaaaaaaaaaaa";
            string Last_Name = "Hussein";
            string Email = "Husseinfinland94@hotmail.com";
            string Address = "135 Sandhills avenue";
            string Postcode = "aaaaaaaaaaaaaaaaaaaaa";//This should trigger an pass
            string Password = "Password";
            string Age = "23";
            string Phone_Number = "07947491403";
            string User_CV = "CV IMAGE";
            //invoke the method 
            OK = AnCustomer.Valid(First_Name, Last_Name, Email, Address, Postcode, Password, Age, Phone_Number, User_CV);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PostcodeMax()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string First_Name = "aaaaaaaaaaaaaaaaaaaaaa";
            string Last_Name = "Hussein";
            string Email = "Husseinfinland94@hotmail.com";
            string Address = "135 Sandhills avenue";
            string Postcode = "aaaaaaaaaaaaaaaaaaaaaa";//This should trigger an pass
            string Password = "Password";
            string Age = "23";
            string Phone_Number = "07947491403";
            string User_CV = "CV IMAGE";
            //invoke the method 
            OK = AnCustomer.Valid(First_Name, Last_Name, Email, Address, Postcode, Password, Age, Phone_Number, User_CV);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PostcodeMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string First_Name = "aaaaaaaaaaaaaaaaaaaaaaa";
            string Last_Name = "Hussein";
            string Email = "Husseinfinland94@hotmail.com";
            string Address = "135 Sandhills avenue";
            string Postcode = "aaaaaaaaaaaaaaaaaaaaaaa";//This should trigger an Fail
            string Password = "Password";
            string Age = "23";
            string Phone_Number = "07947491403";
            string User_CV = "CV IMAGE";
            //invoke the method 
            OK = AnCustomer.Valid(First_Name, Last_Name, Email, Address, Postcode, Password, Age, Phone_Number, User_CV);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void PostcodeMid()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string First_Name = "aaaaaaaaaaa";
            string Last_Name = "Hussein";
            string Email = "Husseinfinland94@hotmail.com";
            string Address = "135 Sandhills avenue";
            string Postcode = "aaaaaaaaaaa";//This should trigger an pass
            string Password = "Password";
            string Age = "23";
            string Phone_Number = "07947491403";
            string User_CV = "CV IMAGE";
            //invoke the method 
            OK = AnCustomer.Valid(First_Name, Last_Name, Email, Address, Postcode, Password, Age, Phone_Number, User_CV);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PostcodeExtremeMax()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string First_Name = "as";
            string Last_Name = "Hussein";
            string Email = "Husseinfinland94@hotmail.com";
            string Address = "135 Sandhills avenue";
            string Postcode = "";
            Postcode = Postcode.PadRight(90, 'a');//This should trigger an Fail
            string Password = "Password";
            string Age = "23";
            string Phone_Number = "07947491403";
            string User_CV = "CV IMAGE";
            //invoke the method 
            OK = AnCustomer.Valid(First_Name, Last_Name, Email, Address, Postcode, Password, Age, Phone_Number, User_CV);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }


        [TestMethod]
        public void PasswordLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string First_Name = "abdi";
            string Last_Name = "a";
            string Email = "a";
            string Address = "a";
            string Postcode = "LE5 1QN";
            string Password = "";//This should trigger an error
            string Age = "23";
            string Phone_Number = "07947491403";
            string User_CV = "CV IMAGE";
            //invoke the method 
            OK = AnCustomer.Valid(First_Name, Last_Name, Email, Address, Postcode, Password, Age, Phone_Number, User_CV);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void PasswordMin()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string First_Name = "abdi";
            string Last_Name = "a";
            string Email = "a";
            string Address = "a";
            string Postcode = "LE5 1QN";
            string Password = "a";//This should trigger an pass
            string Age = "23";
            string Phone_Number = "07947491403";
            string User_CV = "CV IMAGE";
            //invoke the method 
            OK = AnCustomer.Valid(First_Name, Last_Name, Email, Address, Postcode, Password, Age, Phone_Number, User_CV);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PasswordMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string First_Name = "abdi";
            string Last_Name = "aa";
            string Email = "aa";
            string Address = "aa";
            string Postcode = "LE5 1QN";
            string Password = "aa";//This should trigger an pass
            string Age = "23";
            string Phone_Number = "07947491403";
            string User_CV = "CV IMAGE";
            //invoke the method 
            OK = AnCustomer.Valid(First_Name, Last_Name, Email, Address, Postcode, Password, Age, Phone_Number, User_CV);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PasswordMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string First_Name = "abdi";
            string Last_Name = "aaaaaaaaaaaaaaaaaaaaa";
            string Email = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            string Address = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            string Postcode = "LE5 1QN";
            string Password = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";//This should trigger an pass
            string Age = "23";
            string Phone_Number = "07947491403";
            string User_CV = "CV IMAGE";
            //invoke the method 
            OK = AnCustomer.Valid(First_Name, Last_Name, Email, Address, Postcode, Password, Age, Phone_Number, User_CV);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PasswordMax()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string First_Name = "abdi";
            string Last_Name = "aaaaaaaaaaaaaaaaaaaaaa";
            string Email = "aaaaaaaaaaaaaaaaaaaaaa";
            string Address = "aaaaaaaaaaaaaaaaaaaaaa";
            string Postcode = "LE5 1QN";
            string Password = "aaaaaaaaaaaaaaaaaaaaaa";//This should trigger an pass
            string Age = "23";
            string Phone_Number = "07947491403";
            string User_CV = "CV IMAGE";
            //invoke the method 
            OK = AnCustomer.Valid(First_Name, Last_Name, Email, Address, Postcode, Password, Age, Phone_Number, User_CV);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PasswordPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string First_Name = "abdi";
            string Last_Name = "aaaaaaaaaaaaaaaaaaaaaaa";
            string Email = "aaaaaaaaaaaaaaaaaaaaaaa";
            string Address = "aaaaaaaaaaaaaaaaaaaaaaa";
            string Postcode = "LE5 1QN";
            string Password = "aaaaaaaaaaaaaaaaaaaaaaa";//This should trigger an Fail
            string Age = "23";
            string Phone_Number = "07947491403";
            string User_CV = "CV IMAGE";
            //invoke the method 
            OK = AnCustomer.Valid(First_Name, Last_Name, Email, Address, Postcode, Password, Age, Phone_Number, User_CV);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void PasswordMid()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string First_Name = "abdi";
            string Last_Name = "aaaaaaaaaaa";
            string Email = "aaaaaaaaaaa";
            string Address = "aaaaaaaaaaa";
            string Postcode = "LE5 1QN";//This should trigger an pass
            string Password = "aaaaaaaaaaa";
            string Age = "23";
            string Phone_Number = "07947491403";
            string User_CV = "CV IMAGE";
            //invoke the method 
            OK = AnCustomer.Valid(First_Name, Last_Name, Email, Address, Postcode, Password, Age, Phone_Number, User_CV);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PasswordExtremeMax()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string First_Name = "abdi";
            string Last_Name = "Hussein";
            string Email = "aa";
            string Address = "as";
            string Postcode = "LE5 1QN";
            string Password = "";
            Password = Password.PadRight(90, 'a');//This should trigger an Fail
            string Age = "23";
            string Phone_Number = "07947491403";
            string User_CV = "CV IMAGE";
            //invoke the method 
            OK = AnCustomer.Valid(First_Name, Last_Name, Email, Address, Postcode, Password, Age, Phone_Number, User_CV);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }



        [TestMethod]
        public void Phone_NumberMinLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string First_Name = "a";
            string Last_Name = "Hussein";
            string Email = "Husseinfinland94@hotmail.com";
            string Address = "135 Sandhills avenue";
            string Postcode = "a";
            string Password = "Password";
            string Age = "23";
            string Phone_Number = "";//This should trigger an error
            string User_CV = "CV IMAGE";
            //invoke the method 
            OK = AnCustomer.Valid(First_Name, Last_Name, Email, Address, Postcode, Password, Age, Phone_Number, User_CV);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void Phone_NumberMin()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string First_Name = "a";
            string Last_Name = "Hussein";
            string Email = "Husseinfinland94@hotmail.com";
            string Address = "135 Sandhills avenue";
            string Postcode = "a";
            string Password = "Password";
            string Age = "23";
            string Phone_Number = "a";//This should trigger an pass
            string User_CV = "CV IMAGE";
            //invoke the method 
            OK = AnCustomer.Valid(First_Name, Last_Name, Email, Address, Postcode, Password, Age, Phone_Number, User_CV);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Phone_NumberMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string First_Name = "ab";
            string Last_Name = "Hussein";
            string Email = "Husseinfinland94@hotmail.com";
            string Address = "135 Sandhills avenue";
            string Postcode = "aa";
            string Password = "Password";
            string Age = "23";
            string Phone_Number = "aa";//This should trigger an pass
            string User_CV = "CV IMAGE";
            //invoke the method 
            OK = AnCustomer.Valid(First_Name, Last_Name, Email, Address, Postcode, Password, Age, Phone_Number, User_CV);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Phone_NumberMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string First_Name = "aaaaaaaaaaaaaaaaaaaaa";
            string Last_Name = "Hussein";
            string Email = "Husseinfinland94@hotmail.com";
            string Address = "135 Sandhills avenue";
            string Postcode = "aaaaaaaaaaaaaaaaaaaaa";
            string Password = "Password";
            string Age = "23";
            string Phone_Number = "aaaaaaaaaaaaaaaaaaaaa";//This should trigger an pass
            string User_CV = "CV IMAGE";
            //invoke the method 
            OK = AnCustomer.Valid(First_Name, Last_Name, Email, Address, Postcode, Password, Age, Phone_Number, User_CV);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Phone_NumberMax()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string First_Name = "aaaaaaaaaaaaaaaaaaaaaa";
            string Last_Name = "Hussein";
            string Email = "Husseinfinland94@hotmail.com";
            string Address = "135 Sandhills avenue";
            string Postcode = "aaaaaaaaaaaaaaaaaaaaaa";
            string Password = "Password";
            string Age = "23";
            string Phone_Number = "aaaaaaaaaaaaaaaaaaaaaa";//This should trigger an pass
            string User_CV = "CV IMAGE";
            //invoke the method 
            OK = AnCustomer.Valid(First_Name, Last_Name, Email, Address, Postcode, Password, Age, Phone_Number, User_CV);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Phone_NumberMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string First_Name = "aaaaaaaaaaaaaaaaaaaaaaa";
            string Last_Name = "Hussein";
            string Email = "Husseinfinland94@hotmail.com";
            string Address = "135 Sandhills avenue";
            string Postcode = "aaaaaaaaaaaaaaaaaaaaaaa";
            string Password = "Password";
            string Age = "23";
            string Phone_Number = "aaaaaaaaaaaaaaaaaaaaaaa";//This should trigger an Fail
            string User_CV = "CV IMAGE";
            //invoke the method 
            OK = AnCustomer.Valid(First_Name, Last_Name, Email, Address, Postcode, Password, Age, Phone_Number, User_CV);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void Phone_NumberMid()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string First_Name = "aaaaaaaaaaa";
            string Last_Name = "Hussein";
            string Email = "Husseinfinland94@hotmail.com";
            string Address = "135 Sandhills avenue";
            string Postcode = "aaaaaaaaaaa";
            string Password = "Password";
            string Age = "23";
            string Phone_Number = "aaaaaaaaaaa";//This should trigger an pass
            string User_CV = "CV IMAGE";
            //invoke the method 
            OK = AnCustomer.Valid(First_Name, Last_Name, Email, Address, Postcode, Password, Age, Phone_Number, User_CV);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Phone_NumberExtremeMax()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string First_Name = "as";
            string Last_Name = "Hussein";
            string Email = "Husseinfinland94@hotmail.com";
            string Address = "135 Sandhills avenue";
            string Postcode = "a";
            string Password = "Password";
            string Age = "23";
            string Phone_Number = "";
            Phone_Number = Phone_Number.PadRight(90, 'a');//This should trigger an Fail
            string User_CV = "CV IMAGE";
            //invoke the method 
            OK = AnCustomer.Valid(First_Name, Last_Name, Email, Address, Postcode, Password, Age, Phone_Number, User_CV);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }


        [TestMethod]
        public void User_CVLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string First_Name = "abdi";
            string Last_Name = "a";
            string Email = "a";
            string Address = "a";
            string Postcode = "LE5 1QN";
            string Password = "a";
            string Age = "23";
            string Phone_Number = "07947491403";
            string User_CV = "";//This should trigger an error
            //invoke the method 
            OK = AnCustomer.Valid(First_Name, Last_Name, Email, Address, Postcode, Password, Age, Phone_Number, User_CV);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }



        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the reslt of the validation
            Boolean Found = false;
            //create some test data to use with the method
            int UserId = 4;
            //invoke the method
            Found = AnCustomer.Find(UserId);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestUserIdFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the reslt of the validation
            bool Found = false;
            //boolean variable to records if data is ok (Asume it is)
            bool OK = true;
            //create some test data to use with the method
            int UserId = 4;
            //invoke the method
            Found = AnCustomer.Find(UserId);
            //check the booking NO
            if (AnCustomer.UserId != 4)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFirst_NameFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the reslt of the validation
            Boolean Found = false;
            //boolean variable to records if data is ok (Asume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 UserId = 4;
            //invoke the method
            Found = AnCustomer.Find(UserId);
            //check the Property
            if (AnCustomer.First_Name != "Abdinasir")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLast_NameFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the reslt of the validation
            Boolean Found = false;
            //boolean variable to records if data is ok (Asume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 UserId = 4;
            //invoke the method
            Found = AnCustomer.Find(UserId);
            //check the Property
            if (AnCustomer.Last_Name != "Nasir")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the reslt of the validation
            Boolean Found = false;
            //boolean variable to records if data is ok (Asume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 UserId = 4;
            //invoke the method
            Found = AnCustomer.Find(UserId);
            //check the Property
            if (AnCustomer.Email != "husseinfinland94@hotmail.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddressFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the reslt of the validation
            Boolean Found = false;
            //boolean variable to records if data is ok (Asume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 UserId = 4;
            //invoke the method
            Found = AnCustomer.Find(UserId);
            //check the Property
            if (AnCustomer.Address != "Hello")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPostcodeFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the reslt of the validation
            Boolean Found = false;
            //boolean variable to records if data is ok (Asume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 UserId = 4;
            //invoke the method
            Found = AnCustomer.Find(UserId);
            //check the Property
            if (AnCustomer.Postcode != "LE5 1QN")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPasswordFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the reslt of the validation
            Boolean Found = false;
            //boolean variable to records if data is ok (Asume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 UserId = 4;
            //invoke the method
            Found = AnCustomer.Find(UserId);
            //check the Property
            if (AnCustomer.Password != "Password")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAgeFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the reslt of the validation
            Boolean Found = false;
            //boolean variable to records if data is ok (Asume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 UserId = 4;
            //invoke the method
            Found = AnCustomer.Find(UserId);
            //check the Property
            if (AnCustomer.Age != Convert.ToString("25"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPhone_NumberFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the reslt of the validation
            Boolean Found = false;
            //boolean variable to records if data is ok (Asume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 UserId = 4;
            //invoke the method
            Found = AnCustomer.Find(UserId);
            //check the Property
            if (AnCustomer.Phone_Number != "07947491403")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestUser_CVFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the reslt of the validation
            Boolean Found = false;
            //boolean variable to records if data is ok (Asume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 UserId = 4;
            //invoke the method
            Found = AnCustomer.Find(UserId);
            //check the Property
            if (AnCustomer.User_CV != "CV Image")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

    }
}
