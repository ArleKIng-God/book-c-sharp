using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Room
    {
        public Room()
        {
            this.Patients = new List<string>();
        }

        public List<string> Patients { get; set; }
    }
}
