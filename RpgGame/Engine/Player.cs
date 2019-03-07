using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    // Inherits from the LivingCreature base class
    public class Player : LivingCreature
    {
        public int Gold { get; set; }
        public int Experience { get; set; }
        public int Level { get; set; }

        public List<InventoryItem> Inventory { get; set; }
        public List<PlayerQuest> Quests { get; set; }

        public Player(int currentHitPoints, int maxHitPoints, int gold, int experience, 
                      int level) : base(currentHitPoints, maxHitPoints)
        {
            Gold = gold;
            Experience = experience;
            Level = level;

            Inventory = new List<InventoryItem>();
            Quests = new List<PlayerQuest>();

        }
    }
}
