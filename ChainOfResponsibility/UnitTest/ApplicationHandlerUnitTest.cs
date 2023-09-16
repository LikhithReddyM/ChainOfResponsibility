/******************************************************************************
 * Filename    = ApplicationHandlerUnitTests.cs
 *
 * Author      = Likhith Reddy M
 *
 * Product     = ChainOfResponsibility
 * 
 * Project     = StudentLeaveHandler
 *
 * Description = Unit tests for the StudentLeaveHandler
 *****************************************************************************/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentLeaveHandler;

namespace UnitTest
{
    /// <summary>
    /// Unit tests for the StudentLeaveHandler.
    /// </summary>
    [TestClass]
    public class StudentLeaveHandlerUnitTests
    {
        /// <summary>
        /// Tests Professor Handler.
        /// </summary>
        [TestMethod]
        public void TestProfessor()
        {
            Professor Professor = new Professor();
            HeadOfDepartment headOfDepartment = new HeadOfDepartment();
            DeanAcademics deanAcademics = new DeanAcademics();

            Professor.SetNextHigherUp(headOfDepartment);
            headOfDepartment.SetNextHigherUp(deanAcademics);

            string testCase1 = Professor.LeaveApplication("Anurag", 2);
            string applicationStatus = "Professor Approved 2 Days Leave for the Student Anurag";
            Assert.AreEqual(testCase1, applicationStatus);
        }

        /// <summary>
        /// Tests HeadOfdepartment Handler and predecessor handlers.
        /// </summary>
        [TestMethod]
        public void TestHeadOfDepartment()
        {
            Professor Professor = new Professor();
            HeadOfDepartment headOfDepartment = new HeadOfDepartment();
            DeanAcademics deanAcademics = new DeanAcademics();

            Professor.SetNextHigherUp(headOfDepartment);
            headOfDepartment.SetNextHigherUp(deanAcademics);

            string testCase2 = Professor.LeaveApplication("Pranaya", 14);
            string applicationStatus = "HeadOfDepartment Approved 14 Days Leave for the Student Pranaya";
            Assert.AreEqual(testCase2, applicationStatus);
        }

        /// <summary>
        /// Tests DeanAcademics Handler and predecessor handlers.
        /// </summary>
        [TestMethod]
        public void TestDeanAcademics()
        {
            Professor Professor = new Professor();
            HeadOfDepartment headOfDepartment = new HeadOfDepartment();
            DeanAcademics deanAcademics = new DeanAcademics();

            Professor.SetNextHigherUp(headOfDepartment);
            headOfDepartment.SetNextHigherUp(deanAcademics);

            string testCase3 = Professor.LeaveApplication("Priyanka", 30);
            string applicationStatus = "DeanAcademics Approved 30 Days Leave for the Student Priyanka";
            Assert.AreEqual(testCase3, applicationStatus);
        }

        /// <summary>
        /// Tests that request is suspended when student asks for leaves more than the upper cap.
        /// </summary>
        [TestMethod]
        public void TestExcessiveLeaveApplication()
        {
            Professor Professor = new Professor();
            HeadOfDepartment headOfDepartment = new HeadOfDepartment();
            DeanAcademics deanAcademics = new DeanAcademics();

            Professor.SetNextHigherUp(headOfDepartment);
            headOfDepartment.SetNextHigherUp(deanAcademics);

            string testCase4 = Professor.LeaveApplication("Ramesh", 50);
            string applicationStatus = "Leave Application Suspended for Student Ramesh, Please contact DeanAcademics";
            Assert.AreEqual(testCase4, applicationStatus);
        }
    }
}
