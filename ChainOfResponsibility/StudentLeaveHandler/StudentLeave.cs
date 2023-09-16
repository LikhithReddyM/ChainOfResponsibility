/******************************************************************************
 * Filename    = StudentLeave.cs
 *
 * Author      = Likhith Reddy M
 *
 * Product     = ChainOfResponsibility
 * 
 * Project     = StudentLeaveHandler
 *
 * Description = Implimentation of chaining behaviour
 *****************************************************************************/

namespace StudentLeaveHandler
{
    /// <summary>
    /// Abstraxt class for implimenting 'Default Chaining Behavior'.
    /// </summary>
    public abstract class StudentLeave
	{
        protected StudentLeave? _higherUp; //reference for the Next Handler

        /// <summary>
        /// Initializing _higherUp reference using the class constructor.
        /// </summary>
        /// <param name="higherUp">The reference for handler.</param>
        public void SetNext_higherUp(StudentLeave higherUp)
        {
            this._higherUp = higherUp;
        }

        /// <summary>
        /// Abstraxt class for handling the request(LeaveApplication).
        /// </summary>
        /// <param name="StudentName">name of the student.</param>
        /// <param name="NumberOfDaysLeave">no of days the student has requested to take leave.</param>
        public abstract string LeaveApplication(string studentName, uint numberOfDaysLeave);
    }
}
