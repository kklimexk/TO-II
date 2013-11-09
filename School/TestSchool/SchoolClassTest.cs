using School.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using NMock2;
using System.Linq;

namespace TestSchool
{
    
    /// <summary>
    ///This is a test class for SchoolClassTest and is intended
    ///to contain all SchoolClassTest Unit Tests
    ///</summary>
    [TestClass]
    public class SchoolClassTest
    {

        private Mockery _mockery;

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion

        [TestInitialize]
        public void SetUp()
        {
            _mockery = new Mockery();         
        }

        /// <summary>
        ///A test for AddStudent
        ///</summary>
        [TestMethod]
        public void AddStudentTest()
        {
            SchoolClass schoolClass = new SchoolClass("4A");
            Student mockStudent = _mockery.NewMock<Student>("Ala", "Nowak");
            schoolClass.AddStudent(mockStudent);
            List<Student> students = schoolClass.Students.ToList();
            Assert.IsTrue(students.Contains(mockStudent));
        }

        /// <summary>
        ///A test for FindPersonsBySurname
        ///</summary>
        [TestMethod]
        public void FindPersonsBySurnameTest()
        {

            var target = new SchoolClass("4C");
            
            var mockStudent = _mockery.NewMock<Student>("Ala", "Nowak");
            var mockStudent2 = _mockery.NewMock<Student>("Marek", "Kowalski");
            var mockTeacher = _mockery.NewMock<Teacher>("Jas", "Kowalski", "Matematyka");

            target.AddStudent(mockStudent);
            target.AddStudent(mockStudent2);
            target.Teacher = mockTeacher;

            IEnumerable<Person> foundPersons = target.FindPersonsBySurname("Kowalski");
            Assert.IsFalse(foundPersons.Contains(mockStudent));
            Assert.IsTrue(foundPersons.Contains(mockStudent2));
            Assert.IsTrue(foundPersons.Contains(mockTeacher));
        }
    }
}
