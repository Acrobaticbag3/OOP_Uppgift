using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_Uppgift {

    class PlayerShip : ShipStats {
        private int wp; 
        private int wr;
        private int ac;
        private int hl;
        private int si;    
        public PlayerShip(int weaponClass, int weaponRange, int armorClass, int hull, int systemIntegraty) : base(weaponClass, weaponRange, armorClass, hull, systemIntegraty) {
           wp = weaponClass;
           wr = weaponRange;
           ac = armorClass;
           hl = hull;
           si = systemIntegraty;

        }

        public bool CheckStats() {
            int[] statArray = new int[5] {wp, wr, ac, hl, si};

            Console.WriteLine("=================================");
            foreach (int item in statArray) {
                Console.WriteLine(item);
            }
            Console.WriteLine("=================================");
            
            return false;
        }
    }

}