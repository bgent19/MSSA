namespace Assignment3._3._2.Models
{
    /// <summary>
    /// Enumeration of valid grade letters for a student.
    /// </summary>
    public enum Grade
    {
        A,
        B,
        C,
        D,
        F
    }

    /// <summary>
    /// Enumeration of valid months for admission.
    /// </summary>
    public enum Month
    {
        January = 1,
        February = 2,
        March = 3,
        April = 4,
        May = 5,
        June = 6,
        July = 7,
        August = 8,
        September = 9,
        October = 10,
        November = 11,
        December = 12
    }

    /// <summary>
    /// Represents a student record with personal and academic information.
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Gets or sets the unique identifier for the student. Defaults to 0.
        /// </summary>
        public int StudentId { get; set; } = 0;

        /// <summary>
        /// Gets or sets the student's first name. This field is required.
        /// </summary>
        public required string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the student's last name. This field is required.
        /// </summary>
        public required string LastName { get; set; }

        /// <summary>
        /// Gets or sets the student's address. This field is optional.
        /// </summary>
        public string? Address { get; set; }

        /// <summary>
        /// Gets or sets the month of admission. Defaults to January (1).
        /// </summary>
        public Month? MonthOfAdmission { get; set; }

        /// <summary>
        /// Gets or sets the student's grade letter (A-F).
        /// </summary>
        public Grade Grade { get; set; }
 
    }
}
