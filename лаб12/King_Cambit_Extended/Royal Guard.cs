using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace King_Cambit_Extended
{
    class Royal_Guard : Soldier
    {
        public Royal_Guard(string name)
           : base(name)
        {
        }

        public override void OnKingAttacked(object source, EventArgs args)
        {
            Console.WriteLine($"Royal_Guard {this.Name} is defending!");
        }
    }
}
