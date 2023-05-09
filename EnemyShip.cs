using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_Uppgift {

    class EnemyShip : ShipStats {
        public EnemyShip(int weaponClass, int weaponRange, int aurmorClass, int hull, int systemIntegraty) : base(weaponClass, weaponRange, aurmorClass, hull, systemIntegraty) {
           
        }  
    }

}