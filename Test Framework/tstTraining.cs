using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace Test_Framework
{
    [TestClass]
    public class tstTraining
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsTraining AnTraining = new clsTraining();
            //test to see that it exists
            Assert.IsNotNull(AnTraining);
        }
        [TestMethod]
        public void Training_Course_NameOK()
        {
            //create an instance of the class we want to create
            clsTraining AnTraining = new clsTraining();
            //create some test data to assign to the property
            string TestData = "Runner";
            //assign the data to the property
            AnTraining.Training_Course_Name = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnTraining.Training_Course_Name, TestData);
        }
        [TestMethod]
        public void Training_Course_TypeOK()
        {
            //create an instance of the class we want to create
            clsTraining AnTraining = new clsTraining();
            //create some test data to assign to the property
            string TestData = "Software Developer";
            //assign the data to the property
            AnTraining.Training_Course_Type = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnTraining.Training_Course_Type, TestData);
        }
        [TestMethod]
        public void Training_Course_DescriptionOK()
        {
            //create an instance of the class we want to create
            clsTraining AnTraining = new clsTraining();
            //create some test data to assign to the property
            string TestData = "Runner is a great training course to enrol in";
            //assign the data to the property
            AnTraining.Training_Course_Description = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnTraining.Training_Course_Description, TestData);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create 
            clsTraining AnTraining = new clsTraining();
            //string variable to store any error message
            Boolean OK = false;
            //create some test data to pass to the method
            string Training_Course_Name = "Runner";
            string Training_Course_Type = "Software Developer";
            string Training_Course_Description = "Runner is a great training course to enrol in";
            //invoke the method 
            OK = AnTraining.Valid(Training_Course_Name, Training_Course_Type, Training_Course_Description);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Training_Course_NameMinLessOne()
        {
            //create an instance of the class we want to create 
            clsTraining AnTraining = new clsTraining();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Training_Course_Name = "";//This should trigger an error
            string Training_Course_Type = "Software Developer";
            string Training_Course_Description = "Runner is a great training course to enrol in";
            //invoke the method 
            OK = AnTraining.Valid(Training_Course_Name, Training_Course_Type, Training_Course_Description);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void Training_Course_NameMin()
        {
            //create an instance of the class we want to create 
            clsTraining AnTraining = new clsTraining();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Training_Course_Name = "a";//This should trigger an Pass
            string Training_Course_Type = "Software Developer";
            string Training_Course_Description = "Runner is a great training course to enrol in";
            //invoke the method 
            OK = AnTraining.Valid(Training_Course_Name, Training_Course_Type, Training_Course_Description);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Training_Course_NameMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsTraining AnTraining = new clsTraining();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Training_Course_Name = "aa";//This should trigger an Pass
            string Training_Course_Type = "Software Developer";
            string Training_Course_Description = "Runner is a great training course to enrol in";
            //invoke the method 
            OK = AnTraining.Valid(Training_Course_Name, Training_Course_Type, Training_Course_Description);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Training_Course_NameMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsTraining AnTraining = new clsTraining();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Training_Course_Name = "aaaaaaaaaaaaaaaaaaaaa";//This should trigger an Pass
            string Training_Course_Type = "Software Developer";
            string Training_Course_Description = "Runner is a great training course to enrol in";
            //invoke the method 
            OK = AnTraining.Valid(Training_Course_Name, Training_Course_Type, Training_Course_Description);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Training_Course_NameMax()
        {
            //create an instance of the class we want to create 
            clsTraining AnTraining = new clsTraining();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Training_Course_Name = "aaaaaaaaaaaaaaaaaaaaaa";//This should trigger an Pass
            string Training_Course_Type = "Software Developer";
            string Training_Course_Description = "Runner is a great training course to enrol in";
            //invoke the method 
            OK = AnTraining.Valid(Training_Course_Name, Training_Course_Type, Training_Course_Description);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Training_Course_NameMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsTraining AnTraining = new clsTraining();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Training_Course_Name = "aaaaaaaaaaaaaaaaaaaaaaa";//This should trigger an Error
            string Training_Course_Type = "Software Developer";
            string Training_Course_Description = "Runner is a great training course to enrol in";
            //invoke the method 
            OK = AnTraining.Valid(Training_Course_Name, Training_Course_Type, Training_Course_Description);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void Training_Course_TypeMinLessOne()
        {
            //create an instance of the class we want to create 
            clsTraining AnTraining = new clsTraining();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Training_Course_Name = "Runner";
            string Training_Course_Type = "";//This should trigger an error
            string Training_Course_Description = "Runner is a great training course to enrol in";
            //invoke the method 
            OK = AnTraining.Valid(Training_Course_Name, Training_Course_Type, Training_Course_Description);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void Training_Course_TypeMin()
        {
            //create an instance of the class we want to create 
            clsTraining AnTraining = new clsTraining();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Training_Course_Name = "Runner";
            string Training_Course_Type = "a";//This should trigger an Pass
            string Training_Course_Description = "Runner is a great training course to enrol in";
            //invoke the method 
            OK = AnTraining.Valid(Training_Course_Name, Training_Course_Type, Training_Course_Description);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Training_Course_TypeMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsTraining AnTraining = new clsTraining();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Training_Course_Name = "Runner";
            string Training_Course_Type = "aa";//This should trigger an Pass
            string Training_Course_Description = "Runner is a great training course to enrol in";
            //invoke the method 
            OK = AnTraining.Valid(Training_Course_Name, Training_Course_Type, Training_Course_Description);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Training_Course_TypeMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsTraining AnTraining = new clsTraining();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Training_Course_Name = "Runner";
            string Training_Course_Type = "aaaaaaaaaaaaaaaaaaaaa";//This should trigger an Pass
            string Training_Course_Description = "Runner is a great training course to enrol in";
            //invoke the method 
            OK = AnTraining.Valid(Training_Course_Name, Training_Course_Type, Training_Course_Description);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Training_Course_TypeMax()
        {
            //create an instance of the class we want to create 
            clsTraining AnTraining = new clsTraining();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Training_Course_Name = "Runner";
            string Training_Course_Type = "aaaaaaaaaaaaaaaaaaaaaa";//This should trigger an Pass
            string Training_Course_Description = "Runner is a great training course to enrol in";
            //invoke the method 
            OK = AnTraining.Valid(Training_Course_Name, Training_Course_Type, Training_Course_Description);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Training_Course_TypeMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsTraining AnTraining = new clsTraining();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Training_Course_Name = "Runner";
            string Training_Course_Type = "aaaaaaaaaaaaaaaaaaaaaaa";//This should trigger an False
            string Training_Course_Description = "Runner is a great training course to enrol in";
            //invoke the method 
            OK = AnTraining.Valid(Training_Course_Name, Training_Course_Type, Training_Course_Description);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void Training_Course_DescriptionMinLessOne()
        {
            //create an instance of the class we want to create 
            clsTraining AnTraining = new clsTraining();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Training_Course_Name = "Runner";
            string Training_Course_Type = "Software Developer";
            string Training_Course_Description = "";//This should trigger an error
            //invoke the method 
            OK = AnTraining.Valid(Training_Course_Name, Training_Course_Type, Training_Course_Description);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void Training_Course_DescriptionMin()
        {
            //create an instance of the class we want to create 
            clsTraining AnTraining = new clsTraining();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Training_Course_Name = "Runner";
            string Training_Course_Type = "Software Developer";
            string Training_Course_Description = "a";//This should trigger an Pass
            //invoke the method 
            OK = AnTraining.Valid(Training_Course_Name, Training_Course_Type, Training_Course_Description);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Training_Course_DescriptionMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsTraining AnTraining = new clsTraining();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Training_Course_Name = "Runner";
            string Training_Course_Type = "Software Developer";
            string Training_Course_Description = "aa";//This should trigger an Pass
            //invoke the method 
            OK = AnTraining.Valid(Training_Course_Name, Training_Course_Type, Training_Course_Description);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Training_Course_DescriptionMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsTraining AnTraining = new clsTraining();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Training_Course_Name = "Runner";
            string Training_Course_Type = "Software Developer";
            string Training_Course_Description = "";//This should trigger an Pass
            Training_Course_Description = Training_Course_Description.PadRight(99, 'a');
            //invoke the method 
            OK = AnTraining.Valid(Training_Course_Name, Training_Course_Type, Training_Course_Description);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Training_Course_DescriptionMax()
        {
            //create an instance of the class we want to create 
            clsTraining AnTraining = new clsTraining();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Training_Course_Name = "Runner";
            string Training_Course_Type = "Software Developer";
            string Training_Course_Description = "";//This should trigger an Pass
            Training_Course_Description = Training_Course_Description.PadRight(100, 'a');
            //invoke the method 
            OK = AnTraining.Valid(Training_Course_Name, Training_Course_Type, Training_Course_Description);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Training_Course_DescriptionMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsTraining AnTraining = new clsTraining();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Training_Course_Name = "Runner";
            string Training_Course_Type = "Software Developer";
            string Training_Course_Description = "";//This should trigger an False
            Training_Course_Description = Training_Course_Description.PadRight(101, 'a');
            //invoke the method 
            OK = AnTraining.Valid(Training_Course_Name, Training_Course_Type, Training_Course_Description);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create 
            clsTraining AnTraining = new clsTraining();
            //boolean variable to store the reslt of the validation
            Boolean Found = false;
            //create some test data to use with the method
            int Training_CourseId = 1;
            //invoke the method
            Found = AnTraining.Find(Training_CourseId);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestTraining_CourseIdFound()
        {
            //create an instance of the class we want to create 
            clsTraining AnTraining = new clsTraining();
            //boolean variable to store the reslt of the validation
            bool Found = false;
            //boolean variable to records if data is ok (Asume it is)
            bool OK = true;
            //create some test data to use with the method
            int Training_CourseId = 1;
            //invoke the method
            Found = AnTraining.Find(Training_CourseId);
            //check the booking NO
            if (AnTraining.Training_CourseId != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTraining_Course_NameFound()
        {
            //create an instance of the class we want to create 
            clsTraining AnTraining = new clsTraining();
            //boolean variable to store the reslt of the validation
            bool Found = false;
            //boolean variable to records if data is ok (Asume it is)
            bool OK = true;
            //create some test data to use with the method
            int Training_CourseId = 1;
            //invoke the method
            Found = AnTraining.Find(Training_CourseId);
            //check the booking NO
            if (AnTraining.Training_Course_Name != "Runner")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTraining_Course_TypeFound()
        {
            //create an instance of the class we want to create 
            clsTraining AnTraining = new clsTraining();
            //boolean variable to store the reslt of the validation
            bool Found = false;
            //boolean variable to records if data is ok (Asume it is)
            bool OK = true;
            //create some test data to use with the method
            int Training_CourseId = 1;
            //invoke the method
            Found = AnTraining.Find(Training_CourseId);
            //check the booking NO
            if (AnTraining.Training_Course_Type != "Software Developer")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTraining_Course_DescriptionFound()
        {
            //create an instance of the class we want to create 
            clsTraining AnTraining = new clsTraining();
            //boolean variable to store the reslt of the validation
            bool Found = false;
            //boolean variable to records if data is ok (Asume it is)
            bool OK = true;
            //create some test data to use with the method
            int Training_CourseId = 1;
            //invoke the method
            Found = AnTraining.Find(Training_CourseId);
            //check the booking NO
            if (AnTraining.Training_Course_Description != "Runner is a great training course to enrol in")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

    }
}
