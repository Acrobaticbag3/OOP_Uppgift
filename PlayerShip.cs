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
        private int score;  
        public PlayerShip(int weaponClass, int weaponRange, int armorClass, int hull, int systemIntegraty) : base(weaponClass, weaponRange, armorClass, hull, systemIntegraty) {
           wp = weaponClass;
           wr = weaponRange;
           ac = armorClass;
           hl = hull;
           si = systemIntegraty;

        }

        public void AddScore() {
            score++;
        }

        public void Death() {     
            if (hl <= 0) {
                Console.WriteLine("Your ship becomes a lifeless drifting husk. Wheter because of ship wide system failiuer or crew casualty rates, the survivours are left to fend for them selves. Your fate becomes unknown");
            } 
            Console.WriteLine(score);
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