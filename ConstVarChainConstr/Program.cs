using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVarChainConstr
{
    class Program
    {
        static void Main(string[] args)
        {
            const string welcome = "Welcome to C#";
            Console.WriteLine("{0}, what is your name?", welcome);
            var name = Console.ReadLine();
            Console.WriteLine("{0}, {1}", welcome, name);
            Student student = new Student();
            Console.WriteLine("ID: {0}\nName: {1}\nGUID: {2}", student.name, student.id, student.guid );
        }
    }

    public class Student
    {
        public int id;
        public string name;
        public Guid guid; 
        public Student() : this(0, "Not specified"){}
        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
            Guid guid = Guid.NewGuid();
            this.guid = guid;
        }
        
    }
}
