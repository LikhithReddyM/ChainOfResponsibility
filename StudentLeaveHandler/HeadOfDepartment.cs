/******************************************************************************
 * Filename    = HeadOfDepartment.cs
 *
 * Author      = Likhith Reddy M
 *
 * Product     = ChainOfResponsibility
 * 
 * Project     = StudentLeaveHandler
 *
 * Description = Approves the LeaveApplication or passes it to HigherUp(DeanAcademics)
 *****************************************************************************/

namespace StudentLeaveHandler
{
    /// <summary>
    /// This is Concrete Handler 2
    /// Approves the LeaveApplication or passes it to HigherUp(DeanAcademics).
    /// </summary>
    public class HeadOfDepartment : StudentLeave
    {
        // HeadOfDepartment can only approve up to 15 days of leave
        private readonly int _maxLeaves = 15;

        /// <summary>
        /// Checks if HeadOfDepartment can process this request.
        /// </summary>
        /// <param name="studentName">name of the student.</param>
        /// <param name="numberOfDaysLeave">no of days the student has requested to take leave.</param>
        public override string LeaveApplication(string studentName, uint numberOfDaysLeave)
        {
            if (numberOfDaysLeave <= _maxLeaves)
            {
                //Approves the LeaveApplication
                return $"HeadOfDepartment Approved {numberOfDaysLeave} Days Leave for the Student {studentName}";
            }
            //If HeadOfDepartment can't process the LeaveRequest, then pass it on to the HigherUp(DeanAcademics)
            else
            {
                return _higherUp!.LeaveApplication(studentName, numberOfDaysLeave);
            }
        }
    }
}
