using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace King_s_Gambit
{
    public class Footman : Soldier
    {
        public Footman (string name) 
            : base(name)
        {   
        }
    
    public override void OnKingAttacked(object source, EventArgs args)
    {
        Console.WriteLine($"Footman {this.Name} is panicking!");
    }
    }
}
