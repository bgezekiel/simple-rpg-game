using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    // Inherits from the Item base class
    public class HealingPotion : Item
    {
        public int AmountHeal { get; set; }

        // custom construtor inheriting from base
        public HealingPotion(int id, string name, string namePlural, int amountHeal) : base(id, name, namePlural)
        {
            AmountHeal = amountHeal;
        }
    }
}
