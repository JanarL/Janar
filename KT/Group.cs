using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT
{
    public class Group
    {
        public string Name { get; set; }

        public List<Student> Students { get; set; }

        public Group(string name)
        {
            Name = name;
            Students = new List<Student>();
        }
        
        public void AddToGroup(Student student)
        {
            Students.Add(student);
        }
        public void Print()
        {
            Console.WriteLine("Group name " + Name);
            foreach(var item in Students)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }

        }
        
    }
}
