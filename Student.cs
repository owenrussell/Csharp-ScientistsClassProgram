using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWKpart1students
{
    class Student
    {
        public string name;
        public int id;
        public int age;

        // building a constructor to specify student information

        public Student(string Name, int ID, int Age)
        {
            name = Name;
            id = ID;
            age = Age;
        }

        // properties for the respective variables

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        // creating a function using a concatenation of variables and string

        public string GetInfo()
        {
            return "ID:" + ID + "  Name:" + Name + "    Age(at death):" + Age;
        }
    }
}
