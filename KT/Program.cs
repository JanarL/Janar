using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Janar", "Liiv", "Studying" );
            Student student1 = new Student("Heino", "Pärnpuu", "Studying" );
            Student student2 = new Student("Tõnu", "Säre", "Graduated" );

            Group larpe17 = new Group("LARpe17");

            larpe17.AddToGroup(student);
            larpe17.AddToGroup(student1);
            larpe17.AddToGroup(student2);

            larpe17.Print();

            Console.ReadKey();
        }
    }
}
