using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsManager.Model
{
    public class Assignment
    {
        public string desc;
        public string creationDate;
        public string dueDate;
        public List<int> projects = new List<int>();
    }
}
