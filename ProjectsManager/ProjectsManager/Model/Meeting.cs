using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsManager.Model
{
    public class Meeting
    {
        public List<int> students = new List<int>();
        public List<string> hours = new List<string>();
        public string location;
        public string desc;
        public string header;
        public string creator;
    }
}
