using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace King_Cambit_Extended
{
    class Program
    {
        static void Main(string[] args)
        {
            var soldiers = new List<Soldier>();
            var king = new King(Console.ReadLine());

            var royal_guard_name = Console.ReadLine().Split();

            foreach (string royal_Guard_Name in royal_guard_name)
            {
                var current_royal_guard = new Royal_Guard(royal_Guard_Name);
                soldiers.Add(current_royal_guard);
                king.Attacked += current_royal_guard.OnKingAttacked;
            }

            var footmen_name = Console.ReadLine().Split();

            foreach (string footMen_Name in footmen_name)
            {
                var current_footmen = new Footman(footMen_Name);
                soldiers.Add(current_footmen);
                king.Attacked += current_footmen.OnKingAttacked;
            }

            var command = Console.ReadLine().Split();

            while (command[0] != "End")
            {
                switch (command[0])
                {
                    case "Kill":

                        Soldier deadSoldier = soldiers.FirstOrDefault(s => s.Name.Equals(command[1]));
                        king.Attacked -= deadSoldier.OnKingAttacked;
                        soldiers.Remove(deadSoldier);
                        break;

                    case "Attack":

                        king.TakeAttack();
                        break;
                }
                command = Console.ReadLine().Split();
            }
        }
    }
}
