/******************************************************************************
 * Filename    = Professor.cs
 *
 * Author      = Likhith Reddy M
 *
 * Product     = ChainOfResponsibility
 * 
 * Project     = StudentLeaveHandler
 *
 * Description = Approves the LeaveApplication or passes it to HigherUp(HeadOfDepartment)
 *****************************************************************************/

namespace StudentLeaveHandler
{
    /// <summary>
    /// This is Concrete Handler 1
    /// Approves the LeaveApplication or passes it to HigherUp(HeadOfDepartment).
    /// </summary>
    public class Professor : StudentLeave
    {
        // Professor can only approve up to 5 days of leave
        private readonly int _maxLeaves = 5;

        /// <summary>
        /// Checks if Professor can process this request.
        /// </summary>
        /// <param name="studentName">name of the student.</param>
        /// <param name="numberOfDaysLeave">no of days the student has requested to take leave.</param>
        public override string LeaveApplication(string studentName, uint numberOfDaysLeave)
        {
            if (numberOfDaysLeave <= _maxLeaves)
            {
                //Approves the LeaveApplication
                return $"Professor Approved {numberOfDaysLeave} Days Leave for the Student {studentName}";
            }
            //If Professor can't process the LeaveRequest, then pass it on to the HigherUp(HeadOfDepartment)
            else
            {
                return _higherUp!.LeaveApplication(studentName, numberOfDaysLeave);
            }
        }
    }
}
