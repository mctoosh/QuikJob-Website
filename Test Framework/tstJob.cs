using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace Test_Framework
{
    [TestClass]
    public class tstJob
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //test to see that it exists
            Assert.IsNotNull(AnJob);
        }
        [TestMethod]
        public void Job_NameOK()
        {
            //create an instance of the class we want to create 
             clsJob AnJob = new clsJob();
            //create some test data to assign to the property
            string TestData = "Google";
            //assign the data to the property
            AnJob.Job_Name = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnJob.Job_Name, TestData);
        }
        [TestMethod]
        public void Job_TypeOK()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //create some test data to assign to the property
            string TestData = "Software Developer";
            //assign the data to the property
            AnJob.Job_Type = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnJob.Job_Type, TestData);
        }
        [TestMethod]
        public void Job_DescriptionOK()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //create some test data to assign to the property
            string TestData = "Looking For Experienced Software Developer";
            //assign the data to the property
            AnJob.Job_Description = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnJob.Job_Description, TestData);
        }
        [TestMethod]
        public void Job_AddressOK()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //create some test data to assign to the property
            string TestData = "23 California";
            //assign the data to the property
            AnJob.Job_Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnJob.Job_Address, TestData);
        }
        [TestMethod]
        public void Job_PostcodeOK()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //create some test data to assign to the property
            string TestData = "LE4 2WS";
            //assign the data to the property
            AnJob.Job_Postcode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnJob.Job_Postcode, TestData);
        }
        [TestMethod]
        public void Job_Image()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //create some test data to assign to the property
            string TestData = "Image";
            //assign the data to the property
            AnJob.Job_Image = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnJob.Job_Image, TestData);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //string variable to store any error message
            Boolean OK = false;
            //create some test data to pass to the method
            string Job_Name = "Google";
            string Job_Type = "Admin";
            string Job_Description = "We are looking for experianced admin";
            string Job_Address = "135 Sandhills avenue";
            string Job_Postcode = "LE5 1QN";
            string Job_Image = "Image";
            //invoke the method 
            OK = AnJob.Valid(Job_Name, Job_Type, Job_Description, Job_Address, Job_Postcode, Job_Image);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Job_NameMinLessOne()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Job_Name = "";//This should trigger an error
            string Job_Type = "Admin";
            string Job_Description = "We are looking for experianced admin";
            string Job_Address = "135 Sandhills avenue";
            string Job_Postcode = "LE5 1QN";
            string Job_Image = "Image";
            //invoke the method 
            OK = AnJob.Valid(Job_Name, Job_Type, Job_Description, Job_Address, Job_Postcode, Job_Image);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void Job_NameMin()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Job_Name = "g";
            string Job_Type = "Admin";
            string Job_Description = "We are looking for experianced admin";
            string Job_Address = "135 Sandhills avenue";
            string Job_Postcode = "LE5 1QN";
            string Job_Image = "Image";
            //invoke the method 
            OK = AnJob.Valid(Job_Name, Job_Type, Job_Description, Job_Address, Job_Postcode, Job_Image);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Job_NameMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Job_Name = "go";
            string Job_Type = "Admin";
            string Job_Description = "We are looking for experianced admin";
            string Job_Address = "135 Sandhills avenue";
            string Job_Postcode = "LE5 1QN";
            string Job_Image = "Image";
            //invoke the method 
            OK = AnJob.Valid(Job_Name, Job_Type, Job_Description, Job_Address, Job_Postcode, Job_Image);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Job_NameMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Job_Name = "aaaaaaaaaaaaaaaaaaaaa";
            string Job_Type = "Admin";
            string Job_Description = "We are looking for experianced admin";
            string Job_Address = "135 Sandhills avenue";
            string Job_Postcode = "LE5 1QN";
            string Job_Image = "Image";
            //invoke the method 
            OK = AnJob.Valid(Job_Name, Job_Type, Job_Description, Job_Address, Job_Postcode, Job_Image);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Job_NameMax()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Job_Name = "aaaaaaaaaaaaaaaaaaaaaa";
            string Job_Type = "Admin";
            string Job_Description = "We are looking for experianced admin";
            string Job_Address = "135 Sandhills avenue";
            string Job_Postcode = "LE5 1QN";
            string Job_Image = "Image";
            //invoke the method 
            OK = AnJob.Valid(Job_Name, Job_Type, Job_Description, Job_Address, Job_Postcode, Job_Image);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Job_NameMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Job_Name = "aaaaaaaaaaaaaaaaaaaaaaa";
            string Job_Type = "Admin";
            string Job_Description = "We are looking for experianced admin";
            string Job_Address = "135 Sandhills avenue";
            string Job_Postcode = "LE5 1QN";
            string Job_Image = "Image";
            //invoke the method 
            OK = AnJob.Valid(Job_Name, Job_Type, Job_Description, Job_Address, Job_Postcode, Job_Image);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void Job_NameMid()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Job_Name = "aaaaaaaaaaa";
            string Job_Type = "Admin";
            string Job_Description = "We are looking for experianced admin";
            string Job_Address = "135 Sandhills avenue";
            string Job_Postcode = "LE5 1QN";
            string Job_Image = "Image";
            //invoke the method 
            OK = AnJob.Valid(Job_Name, Job_Type, Job_Description, Job_Address, Job_Postcode, Job_Image);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Job_NameExtremeMax()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Job_Name = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            string Job_Type = "Admin";
            string Job_Description = "We are looking for experianced admin";
            string Job_Address = "135 Sandhills avenue";
            string Job_Postcode = "LE5 1QN";
            string Job_Image = "Image";
            //invoke the method 
            OK = AnJob.Valid(Job_Name, Job_Type, Job_Description, Job_Address, Job_Postcode, Job_Image);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void Job_TypeMinLessOne()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Job_Name = "Google";
            string Job_Type = "";//This should trigger an error
            string Job_Description = "We are looking for experianced admin";
            string Job_Address = "135 Sandhills avenue";
            string Job_Postcode = "LE5 1QN";
            string Job_Image = "Image";
            //invoke the method 
            OK = AnJob.Valid(Job_Name, Job_Type, Job_Description, Job_Address, Job_Postcode, Job_Image);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void Job_TypeMin()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Job_Name = "Google";
            string Job_Type = "a";//This should trigger an Pass
            string Job_Description = "We are looking for experianced admin";
            string Job_Address = "135 Sandhills avenue";
            string Job_Postcode = "LE5 1QN";
            string Job_Image = "Image";
            //invoke the method 
            OK = AnJob.Valid(Job_Name, Job_Type, Job_Description, Job_Address, Job_Postcode, Job_Image);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Job_TypeMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Job_Name = "Google";
            string Job_Type = "aa";//This should trigger an Pass
            string Job_Description = "We are looking for experianced admin";
            string Job_Address = "135 Sandhills avenue";
            string Job_Postcode = "LE5 1QN";
            string Job_Image = "Image";
            //invoke the method 
            OK = AnJob.Valid(Job_Name, Job_Type, Job_Description, Job_Address, Job_Postcode, Job_Image);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Job_TypeMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Job_Name = "Google";
            string Job_Type = "aaaaaaaaaaaaaaaaaaaaa";//This should trigger an Pass
            string Job_Description = "We are looking for experianced admin";
            string Job_Address = "135 Sandhills avenue";
            string Job_Postcode = "LE5 1QN";
            string Job_Image = "Image";
            //invoke the method 
            OK = AnJob.Valid(Job_Name, Job_Type, Job_Description, Job_Address, Job_Postcode, Job_Image);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Job_TypeMax()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Job_Name = "Google";
            string Job_Type = "aaaaaaaaaaaaaaaaaaaaaa";//This should trigger an Pass
            string Job_Description = "We are looking for experianced admin";
            string Job_Address = "135 Sandhills avenue";
            string Job_Postcode = "LE5 1QN";
            string Job_Image = "Image";
            //invoke the method 
            OK = AnJob.Valid(Job_Name, Job_Type, Job_Description, Job_Address, Job_Postcode, Job_Image);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Job_TypeMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Job_Name = "Google";
            string Job_Type = "aaaaaaaaaaaaaaaaaaaaaaa";//This should trigger an Error
            string Job_Description = "We are looking for experianced admin";
            string Job_Address = "135 Sandhills avenue";
            string Job_Postcode = "LE5 1QN";
            string Job_Image = "Image";
            //invoke the method 
            OK = AnJob.Valid(Job_Name, Job_Type, Job_Description, Job_Address, Job_Postcode, Job_Image);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void Job_TypeMid()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Job_Name = "Google";
            string Job_Type = "aaaaaaaaaaa";//This should trigger an Pass
            string Job_Description = "We are looking for experianced admin";
            string Job_Address = "135 Sandhills avenue";
            string Job_Postcode = "LE5 1QN";
            string Job_Image = "Image";
            //invoke the method 
            OK = AnJob.Valid(Job_Name, Job_Type, Job_Description, Job_Address, Job_Postcode, Job_Image);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Job_TypeExtremeMax()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Job_Name = "Google";
            string Job_Type = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";//This should trigger an Error
            string Job_Description = "We are looking for experianced admin";
            string Job_Address = "135 Sandhills avenue";
            string Job_Postcode = "LE5 1QN";
            string Job_Image = "Image";
            //invoke the method 
            OK = AnJob.Valid(Job_Name, Job_Type, Job_Description, Job_Address, Job_Postcode, Job_Image);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void Job_DescriptionMinLessOne()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Job_Name = "Google";
            string Job_Type = "Admin";
            string Job_Description = "";//This should trigger an error
            string Job_Address = "135 Sandhills avenue";
            string Job_Postcode = "LE5 1QN";
            string Job_Image = "Image";
            //invoke the method 
            OK = AnJob.Valid(Job_Name, Job_Type, Job_Description, Job_Address, Job_Postcode, Job_Image);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void Job_DescriptionMin()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Job_Name = "Google";
            string Job_Type = "Admin";
            string Job_Description = "a";//This should trigger an Pass
            string Job_Address = "135 Sandhills avenue";
            string Job_Postcode = "LE5 1QN";
            string Job_Image = "Image";
            //invoke the method 
            OK = AnJob.Valid(Job_Name, Job_Type, Job_Description, Job_Address, Job_Postcode, Job_Image);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Job_DescriptionMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Job_Name = "Google";
            string Job_Type = "Admin";
            string Job_Description = "aa";//This should trigger an Pass
            string Job_Address = "135 Sandhills avenue";
            string Job_Postcode = "LE5 1QN";
            string Job_Image = "Image";
            //invoke the method 
            OK = AnJob.Valid(Job_Name, Job_Type, Job_Description, Job_Address, Job_Postcode, Job_Image);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Job_DescriptionMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Job_Name = "Google";
            string Job_Type = "Admin";
            string Job_Description = "";
            Job_Description = Job_Description.PadRight(99, 'a');
            string Job_Address = "135 Sandhills avenue";
            string Job_Postcode = "LE5 1QN";
            string Job_Image = "Image";
            //invoke the method 
            OK = AnJob.Valid(Job_Name, Job_Type, Job_Description, Job_Address, Job_Postcode, Job_Image);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Job_DescriptionMax()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Job_Name = "Google";
            string Job_Type = "Admin";
            string Job_Description = "";
            Job_Description = Job_Description.PadRight(100, 'a');
            string Job_Address = "135 Sandhills avenue";
            string Job_Postcode = "LE5 1QN";
            string Job_Image = "Image";
            //invoke the method 
            OK = AnJob.Valid(Job_Name, Job_Type, Job_Description, Job_Address, Job_Postcode, Job_Image);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Job_DescriptionMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Job_Name = "Google";
            string Job_Type = "Admin";
            string Job_Description = "";
            Job_Description = Job_Description.PadRight(101, 'a');
            string Job_Address = "135 Sandhills avenue";
            string Job_Postcode = "LE5 1QN";
            string Job_Image = "Image";
            //invoke the method 
            OK = AnJob.Valid(Job_Name, Job_Type, Job_Description, Job_Address, Job_Postcode, Job_Image);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void Job_DescriptionMid()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Job_Name = "Google";
            string Job_Type = "Admin";
            string Job_Description = "";
            Job_Description = Job_Description.PadRight(50, 'a');
            string Job_Address = "135 Sandhills avenue";
            string Job_Postcode = "LE5 1QN";
            string Job_Image = "Image";
            //invoke the method 
            OK = AnJob.Valid(Job_Name, Job_Type, Job_Description, Job_Address, Job_Postcode, Job_Image);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Job_DescriptionExtremeMax()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Job_Name = "Google";
            string Job_Type = "Admin";
            string Job_Description = "";
            Job_Description = Job_Description.PadRight(1000, 'a');
            string Job_Address = "135 Sandhills avenue";
            string Job_Postcode = "LE5 1QN";
            string Job_Image = "Image";
            //invoke the method 
            OK = AnJob.Valid(Job_Name, Job_Type, Job_Description, Job_Address, Job_Postcode, Job_Image);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void Job_AddressMinLessOne()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Job_Name = "Google";
            string Job_Type = "Admin";
            string Job_Description = "We are looking for an experianced admin";
            string Job_Address = "";//This should trigger an error
            string Job_Postcode = "LE5 1QN";
            string Job_Image = "Image";
            //invoke the method 
            OK = AnJob.Valid(Job_Name, Job_Type, Job_Description, Job_Address, Job_Postcode, Job_Image);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void Job_AddressMin()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Job_Name = "Google";
            string Job_Type = "Admin";
            string Job_Description = "We are looking for an experianced admin";
            string Job_Address = "a";//This should trigger an Pass
            string Job_Postcode = "LE5 1QN";
            string Job_Image = "Image";
            //invoke the method 
            OK = AnJob.Valid(Job_Name, Job_Type, Job_Description, Job_Address, Job_Postcode, Job_Image);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Job_AddressMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Job_Name = "Google";
            string Job_Type = "Admin";
            string Job_Description = "We are looking for an experianced admin";
            string Job_Address = "aa";//This should trigger an Pass
            string Job_Postcode = "LE5 1QN";
            string Job_Image = "Image";
            //invoke the method 
            OK = AnJob.Valid(Job_Name, Job_Type, Job_Description, Job_Address, Job_Postcode, Job_Image);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Job_AddressMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Job_Name = "Google";
            string Job_Type = "Admin";
            string Job_Description = "We are looking for an experianced admin";
            string Job_Address = "";
            Job_Address = Job_Address.PadRight(39, 'a');
            string Job_Postcode = "LE5 1QN";
            string Job_Image = "Image";
            //invoke the method 
            OK = AnJob.Valid(Job_Name, Job_Type, Job_Description, Job_Address, Job_Postcode, Job_Image);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Job_AddressMax()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Job_Name = "Google";
            string Job_Type = "Admin";
            string Job_Description = "We are looking for an experianced admin";
            string Job_Address = "";
            Job_Address = Job_Address.PadRight(40, 'a');
            string Job_Postcode = "LE5 1QN";
            string Job_Image = "Image";
            //invoke the method 
            OK = AnJob.Valid(Job_Name, Job_Type, Job_Description, Job_Address, Job_Postcode, Job_Image);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Job_AddressMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Job_Name = "Google";
            string Job_Type = "Admin";
            string Job_Description = "We are looking for an experianced admin";
            string Job_Address = "";
            Job_Address = Job_Address.PadRight(41, 'a');
            string Job_Postcode = "LE5 1QN";
            string Job_Image = "Image";
            //invoke the method 
            OK = AnJob.Valid(Job_Name, Job_Type, Job_Description, Job_Address, Job_Postcode, Job_Image);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void Job_AddressMid()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Job_Name = "Google";
            string Job_Type = "Admin";
            string Job_Description = "We are looking for an experianced admin";
            string Job_Address = "";
            Job_Address = Job_Address.PadRight(20, 'a');
            string Job_Postcode = "LE5 1QN";
            string Job_Image = "Image";
            //invoke the method 
            OK = AnJob.Valid(Job_Name, Job_Type, Job_Description, Job_Address, Job_Postcode, Job_Image);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Job_AddressExtremeMax()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Job_Name = "Google";
            string Job_Type = "Admin";
            string Job_Description = "We are looking for an experianced admin";
            string Job_Address = "";
            Job_Address = Job_Address.PadRight(10000, 'a');
            string Job_Postcode = "LE5 1QN";
            string Job_Image = "Image";
            //invoke the method 
            OK = AnJob.Valid(Job_Name, Job_Type, Job_Description, Job_Address, Job_Postcode, Job_Image);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void Job_PostcodeMinLessOne()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Job_Name = "Google";
            string Job_Type = "Admin";
            string Job_Description = "We are looking for an experianced admin";
            string Job_Address = "135 Sandhills avenue";
            string Job_Postcode = "";//This should trigger an error
            string Job_Image = "Image";
            //invoke the method 
            OK = AnJob.Valid(Job_Name, Job_Type, Job_Description, Job_Address, Job_Postcode, Job_Image);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void Job_PostcodeMin()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Job_Name = "Google";
            string Job_Type = "Admin";
            string Job_Description = "We are looking for an experianced admin";
            string Job_Address = "135 Sandhills avenue";
            string Job_Postcode = "a";//This should trigger an Pass
            string Job_Image = "Image";
            //invoke the method 
            OK = AnJob.Valid(Job_Name, Job_Type, Job_Description, Job_Address, Job_Postcode, Job_Image);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Job_PostcodeMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Job_Name = "Google";
            string Job_Type = "Admin";
            string Job_Description = "We are looking for an experianced admin";
            string Job_Address = "135 Sandhills avenue";
            string Job_Postcode = "aa";//This should trigger an Pass
            string Job_Image = "Image";
            //invoke the method 
            OK = AnJob.Valid(Job_Name, Job_Type, Job_Description, Job_Address, Job_Postcode, Job_Image);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Job_PostcodeMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Job_Name = "Google";
            string Job_Type = "Admin";
            string Job_Description = "We are looking for an experianced admin";
            string Job_Address = "135 Sandhills avenue";
            string Job_Postcode = "aaaaaaaaaaaaaaaaaaaaa";//This should trigger an Pass
            string Job_Image = "Image";
            //invoke the method 
            OK = AnJob.Valid(Job_Name, Job_Type, Job_Description, Job_Address, Job_Postcode, Job_Image);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Job_PostcodeMax()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Job_Name = "Google";
            string Job_Type = "Admin";
            string Job_Description = "We are looking for an experianced admin";
            string Job_Address = "135 Sandhills avenue";
            string Job_Postcode = "aaaaaaaaaaaaaaaaaaaaaa";//This should trigger an Pass
            string Job_Image = "Image";
            //invoke the method 
            OK = AnJob.Valid(Job_Name, Job_Type, Job_Description, Job_Address, Job_Postcode, Job_Image);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Job_PostcodeMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Job_Name = "Google";
            string Job_Type = "Admin";
            string Job_Description = "We are looking for an experianced admin";
            string Job_Address = "135 Sandhills avenue";
            string Job_Postcode = "aaaaaaaaaaaaaaaaaaaaaaa";//This should trigger an Error
            string Job_Image = "Image";
            //invoke the method 
            OK = AnJob.Valid(Job_Name, Job_Type, Job_Description, Job_Address, Job_Postcode, Job_Image);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void Job_PostcodeMid()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Job_Name = "Google";
            string Job_Type = "Admin";
            string Job_Description = "We are looking for an experianced admin";
            string Job_Address = "135 Sandhills avenue";
            string Job_Postcode = "aaaaaaaaaaa";//This should trigger an Pass
            string Job_Image = "Image";
            //invoke the method 
            OK = AnJob.Valid(Job_Name, Job_Type, Job_Description, Job_Address, Job_Postcode, Job_Image);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void Job_PostcodeExtremeMax()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Job_Name = "Google";
            string Job_Type = "Admin";
            string Job_Description = "We are looking for an experianced admin";
            string Job_Address = "135 Sandhills avenue";
            string Job_Postcode = "";
            Job_Postcode = Job_Postcode.PadRight(1000, 'a');
            string Job_Image = "Image";
            //invoke the method 
            OK = AnJob.Valid(Job_Name, Job_Type, Job_Description, Job_Address, Job_Postcode, Job_Image);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void Job_ImageMinLessOne()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Job_Name = "Google";
            string Job_Type = "Admin";
            string Job_Description = "We are looking for an experianced admin";
            string Job_Address = "135 Sandhills avenue";
            string Job_Postcode = "LE5 1QN";
            string Job_Image = "";//This should trigger an error
            //invoke the method 
            OK = AnJob.Valid(Job_Name, Job_Type, Job_Description, Job_Address, Job_Postcode, Job_Image);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void Job_ImageMin()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Job_Name = "Google";
            string Job_Type = "Admin";
            string Job_Description = "We are looking for an experianced admin";
            string Job_Address = "135 Sandhills avenue";
            string Job_Postcode = "LE5 1QN";
            string Job_Image = "a";//This should trigger an Pass
            //invoke the method 
            OK = AnJob.Valid(Job_Name, Job_Type, Job_Description, Job_Address, Job_Postcode, Job_Image);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Job_ImageMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Job_Name = "Google";
            string Job_Type = "Admin";
            string Job_Description = "We are looking for an experianced admin";
            string Job_Address = "135 Sandhills avenue";
            string Job_Postcode = "LE5 1QN";
            string Job_Image = "aa";//This should trigger an Pass
            //invoke the method 
            OK = AnJob.Valid(Job_Name, Job_Type, Job_Description, Job_Address, Job_Postcode, Job_Image);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Job_ImageMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Job_Name = "Google";
            string Job_Type = "Admin";
            string Job_Description = "We are looking for an experianced admin";
            string Job_Address = "135 Sandhills avenue";
            string Job_Postcode = "LE5 1QN";
            string Job_Image = "";
            Job_Image = Job_Image.PadRight(999, 'a');
            //invoke the method 
            OK = AnJob.Valid(Job_Name, Job_Type, Job_Description, Job_Address, Job_Postcode, Job_Image);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void Job_ImageMax()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Job_Name = "Google";
            string Job_Type = "Admin";
            string Job_Description = "We are looking for an experianced admin";
            string Job_Address = "135 Sandhills avenue";
            string Job_Postcode = "LE5 1QN";
            string Job_Image = "";
            Job_Image = Job_Image.PadRight(1000, 'a');
            //invoke the method 
            OK = AnJob.Valid(Job_Name, Job_Type, Job_Description, Job_Address, Job_Postcode, Job_Image);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void Job_ImageMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Job_Name = "Google";
            string Job_Type = "Admin";
            string Job_Description = "We are looking for an experianced admin";
            string Job_Address = "135 Sandhills avenue";
            string Job_Postcode = "LE5 1QN";
            string Job_Image = "";
            Job_Image = Job_Image.PadRight(1001, 'a');
            //invoke the method 
            OK = AnJob.Valid(Job_Name, Job_Type, Job_Description, Job_Address, Job_Postcode, Job_Image);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void Job_ImageMid()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Job_Name = "Google";
            string Job_Type = "Admin";
            string Job_Description = "We are looking for an experianced admin";
            string Job_Address = "135 Sandhills avenue";
            string Job_Postcode = "LE5 1QN";
            string Job_Image = "";
            Job_Image = Job_Image.PadRight(500, 'a');
            //invoke the method 
            OK = AnJob.Valid(Job_Name, Job_Type, Job_Description, Job_Address, Job_Postcode, Job_Image);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void Job_ImageExtremeMax()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Job_Name = "Google";
            string Job_Type = "Admin";
            string Job_Description = "We are looking for an experianced admin";
            string Job_Address = "135 Sandhills avenue";
            string Job_Postcode = "LE5 1QN";
            string Job_Image = "";
            Job_Image = Job_Image.PadRight(5000, 'a');
            //invoke the method 
            OK = AnJob.Valid(Job_Name, Job_Type, Job_Description, Job_Address, Job_Postcode, Job_Image);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //boolean variable to store the reslt of the validation
            Boolean Found = false;
            //create some test data to use with the method
            int JobId = 4;
            //invoke the method
            Found = AnJob.Find(JobId);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestJobIdFound()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //boolean variable to store the reslt of the validation
            bool Found = false;
            //boolean variable to records if data is ok (Asume it is)
            bool OK = true;
            //create some test data to use with the method
            int JobId = 4;
            //invoke the method
            Found = AnJob.Find(JobId);
            //check the booking NO
            if (AnJob.JobId != 4)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestJob_NameFound()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //boolean variable to store the reslt of the validation
            bool Found = false;
            //boolean variable to records if data is ok (Asume it is)
            bool OK = true;
            //create some test data to use with the method
            int JobId = 4;
            //invoke the method
            Found = AnJob.Find(JobId);
            //check the booking NO
            if (AnJob.Job_Name != "Google")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestJob_TypeFound()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //boolean variable to store the reslt of the validation
            bool Found = false;
            //boolean variable to records if data is ok (Asume it is)
            bool OK = true;
            //create some test data to use with the method
            int JobId = 4;
            //invoke the method
            Found = AnJob.Find(JobId);
            //check the booking NO
            if (AnJob.Job_Type != "Administration")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestJob_DescriptionFound()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //boolean variable to store the reslt of the validation
            bool Found = false;
            //boolean variable to records if data is ok (Asume it is)
            bool OK = true;
            //create some test data to use with the method
            int JobId = 4;
            //invoke the method
            Found = AnJob.Find(JobId);
            //check the booking NO
            if (AnJob.Job_Description != "We are looking for an experienced administrator")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestJob_AddressFound()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //boolean variable to store the reslt of the validation
            bool Found = false;
            //boolean variable to records if data is ok (Asume it is)
            bool OK = true;
            //create some test data to use with the method
            int JobId = 4;
            //invoke the method
            Found = AnJob.Find(JobId);
            //check the booking NO
            if (AnJob.Job_Address != "135 sandhills avenue")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestJob_PostcodeFound()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //boolean variable to store the reslt of the validation
            bool Found = false;
            //boolean variable to records if data is ok (Asume it is)
            bool OK = true;
            //create some test data to use with the method
            int JobId = 4;
            //invoke the method
            Found = AnJob.Find(JobId);
            //check the booking NO
            if (AnJob.Job_Postcode != "LE5 1QN")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestJob_ImageFound()
        {
            //create an instance of the class we want to create 
            clsJob AnJob = new clsJob();
            //boolean variable to store the reslt of the validation
            bool Found = false;
            //boolean variable to records if data is ok (Asume it is)
            bool OK = true;
            //create some test data to use with the method
            int JobId = 4;
            //invoke the method
            Found = AnJob.Find(JobId);
            //check the booking NO
            if (AnJob.Job_Image != "images/6cRHsAZvNiGoogleImage.png")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
