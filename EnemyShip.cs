using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_Uppgift {

    class EnemyShip : ShipStats {
        private int wp; 
        private int wr;
        private int ac;
        public int hl;
        private int si;    
        public EnemyShip(int weaponClass, int weaponRange, int armorClass, int hull, int systemIntegraty) : base(weaponClass, weaponRange, armorClass, hull, systemIntegraty) {
           wp = weaponClass;
           wr = weaponRange;
           ac = armorClass;
           hl = hull;
           si = systemIntegraty;
        }

        public void Death() {     
            if (hl <= 0) {
                Console.WriteLine("As you keep pelting away at the enemy ship it eventualy comes to a drift. The ship a broken mess, littered with breaches. As you see lifepods ejecting from the ship you note down you fallen foe as a nother kill.");
            } 
        }

        public string CheckStats() {
            int[] statArray = new int[5] {wp, wr, ac, hl, si};

            Console.WriteLine("=================================");
            foreach (int item in statArray) {
                Console.WriteLine(item);
            }
            Console.WriteLine("=================================");
            
            return null; 
        }
    }

}