using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace King_Cambit_Extended
{
    public class King
    {
        public King(string name)
        {
            this.Name = name;
        }

        public event EventHandler Attacked;

        public string Name { get; set; }

        public void TakeAttack()
        {
            this.OnAttacked();
        }
        protected virtual void OnAttacked()
        {
            Console.WriteLine($"King {this.Name} is under attack!");

            if (this.Attacked != null)
            {
                this.Attacked(this, EventArgs.Empty);
            }
        }
    }
}
