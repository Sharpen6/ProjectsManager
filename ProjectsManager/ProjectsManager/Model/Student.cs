using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsManager.Model
{
    class Student
    {
        public int id;
        public string name;

        public Student(int p1, string name)
        {
            id = p1;
            this.name = name;
        }
    }
}
