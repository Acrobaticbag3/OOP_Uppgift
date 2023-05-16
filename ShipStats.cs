using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_Uppgift {

    class ShipStats {
        private int _weaponClass;  // 1 = light, 2 = medium, 3 = heavy, 4 = torpedos, 5 = artilery 
        private int _weaponRange;  // 1 = 4km, 2 = 8km, 3 = 12km, 4 = 16km, 5 = 20km,
        private int _armorClass;  //  1 = light, 2 = medium, 3 = heavy,
        private int _hull;
        private int _systemIntegraty;

        public ShipStats(int weaponClass, int weaponRange, int armorClass, int hull, int systemIntegraty) {
            this._weaponClass = weaponClass;
            this._weaponRange = weaponRange;
            this._armorClass = armorClass;
            this._hull = hull;
            this._systemIntegraty = systemIntegraty;
        }

        public int Attack() {
            Random rng = new Random();
            
            switch (_weaponClass) {
                case 1:
                    _weaponRange = 4; 
                    Console.Write("ships light weapons deal: ");
                    return rng.Next(1, 10);

                case 2:
                    _weaponRange = 8;
                    Console.Write("ships medium weapons deal: ");
                    return rng.Next(3, 30);

                case 3:
                    _weaponRange = 12;
                    Console.Write("ships heavy weapons deal: ");;
                    return rng.Next(4, 40);

                case 4:
                    _weaponRange = 16;
                    Console.Write("ships torpedos weapons deal: ");
                    return rng.Next(20, 200);

                case 5:
                    _weaponRange = 20;
                    Console.Write("ships artilery weapons deal: ");
                    return rng.Next(6, 60);    
            }

            return 0;
        }

        public int SetAurmour() {
            Random rng = new Random();
            
            switch (_armorClass) {
                case 1:
                    Console.Write("Ships armor: ");     // Debug testing 
                    return 2;      // maybe use return instead?

                case 2:
                    Console.Write("Ships armor: ");     // Debug testing 
                    return 3;      // maybe use return instead?

                case 3:
                    Console.Write("Ships armor: ");     // Debug testing 
                    return 4;      // maybe use return instead?
            }

            return 0;
        }
        
    }

}