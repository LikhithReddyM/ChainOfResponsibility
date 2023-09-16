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
        private readonly int MAX_LEAVES_CAN_APPROVE = 30;

        /// <summary>
        /// Checks if DeanAcademics can process this request.
        /// </summary>
        /// <param name="StudentName">name of the student.</param>
        /// <param name="NumberOfDaysLeave">no of days the student has requested to take leave.</param>
        public override string LeaveApplication(string StudentName, uint NumberOfDaysLeave)
        {
            if (NumberOfDaysLeave <= MAX_LEAVES_CAN_APPROVE)
            {
                //Approves the LeaveApplication
                return $"DeanAcademics Approved {NumberOfDaysLeave} Days Leave for the Student {StudentName}";
            }
            //If DeanAcademics can't process the LeaveRequest, then LeaveApplication is suspended
            else
            {
                return $"Leave Application Suspended for Student {StudentName}, Please contact DeanAcademics";
            }
        }
    }
}
