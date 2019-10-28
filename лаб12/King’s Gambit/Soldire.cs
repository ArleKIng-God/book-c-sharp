using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace King_s_Gambit
{
    public abstract class Soldier
    {
        public Soldier (string name)
        {
            this.Name = name;
        }
        public string Name { get; }

        public abstract void OnKingAttacked(object source, EventArgs args);
    }
}
