using System.ComponentModel;

namespace Assignment4._1
{
    public class Person
    {
        //  FirstName , LastName , Mobile Phone , Work Phone and Address.
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string MobilePhone { get; set; } = string.Empty;

        public string WorkPhone { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        [Browsable(false)]
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public override string ToString()
        {
            return $"Name: {FullName}\n" +
                   $"Mobile Phone: {MobilePhone}\n" +
                   $"Work Phone: {WorkPhone}\n" +
                   $"Address: {Address}";
        }
    }
}
