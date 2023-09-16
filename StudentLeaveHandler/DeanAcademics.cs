/******************************************************************************
 * Filename    = DeanAcademics.cs
 *
 * Author      = Likhith Reddy M
 *
 * Product     = ChainOfResponsibility
 * 
 * Project     = StudentLeaveHandler
 *
 * Description = Approves the LeaveApplication or suspends it
 *****************************************************************************/

namespace StudentLeaveHandler
{
    /// <summary>
    /// This is Concrete Handler 3
    /// Approves the LeaveApplication or suspends it.
    /// </summary>
    public class DeanAcademics : StudentLeave
	{
        // DeanAcademics can only approve up to 30 days of leave
        private readonly int _maxLeaves = 30;

        /// <summary>
        /// Checks if DeanAcademics can process this request.
        /// </summary>
        /// <param name="studentName">name of the student.</param>
        /// <param name="numberOfDaysLeave">no of days the student has requested to take leave.</param>
        public override string LeaveApplication(string studentName, uint numberOfDaysLeave)
        {
            if (numberOfDaysLeave <= _maxLeaves)
            {
                //Approves the LeaveApplication
                return $"DeanAcademics Approved {numberOfDaysLeave} Days Leave for the Student {studentName}";
            }
            //If DeanAcademics can't process the LeaveRequest, then LeaveApplication is suspended
            else
            {
                return $"Leave Application Suspended for Student {studentName}, Please contact DeanAcademics";
            }
        }
    }
}
