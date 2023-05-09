using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_Uppgift {

    class ShipStats {
        private string _shipclass;
        private string _shipName;
        private int _weaponClass;  // 1 = light, 2 = medium, 3 = heavy, 4 = torpedos, 5 = artilery 
        private int _weaponRange;  // 1 = 4km, 2 = 8km, 3 = 12km, 4 = 16km, 5 = 20km,
        private int _aurmorClass;  //  1 = light, 2 = medium, 3 = heavy,
        private int _hull;
        private int _systemIntegraty;

        public ShipStats(string shipClass, string shipName, int weaponClass, int weaponRange, int aurmorClass, int hull, int systemIntegraty) {
            this._shipclass = shipClass;
            this._shipName = shipName;
            this._weaponClass = weaponClass;
            this._aurmorClass = aurmorClass;
            this._hull = hull;
            this._systemIntegraty = systemIntegraty;
        }
    }

}