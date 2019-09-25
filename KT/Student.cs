using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT
{
    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool IsStudying { get; set; }

        public StudentStatus Status { get; set; }

        public Student(string firstName, string lastName, string isStudying)
        {
            FirstName = firstName;
            LastName = lastName;
            Enum.TryParse(isStudying, true, out StudentStatus studentStatus);
            Status = studentStatus;
            if(Status == StudentStatus.Studying)
            {
                IsStudying = true;
            }
            else
            {
                IsStudying = false;
            }
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName}, {IsStudying}";
        }

        public enum StudentStatus
        {
            Studying,
            Graduated,
            Exmatriculated,
            OnAcademicLeave
        }

    }
}
