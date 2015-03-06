using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsManager.Model
{
    public class Meeting
    {
        public List<string> students = new List<string>();
        public List<string> hours = new List<string>();
        public string location;
        public string desc;
    }
}
