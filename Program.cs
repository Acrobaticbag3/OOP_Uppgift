using System;
using System.Threading;
using System.Diagnostics;

namespace OOP_Uppgift {

    public class Program {
        static void Main(string[] args) {

            // === Ship Declerations === \\
            

            int currentTurn = 0;

            TurnState turnState = TurnState.PlayerTurn;
            if (turnState == TurnState.PlayerTurn) {
                

            } else if(turnState == TurnState.EnemyTurn) {
                

            }

            StatsDecleration();
            Console.ReadKey();
        }

        public static  void StatsDecleration() {
            // === Stats Declerations === \\
            int Min = 1;
            int Max = 5;

            int hull = 500;
            int integraty = 1000;

            Random rng = new Random();

            // === Player Stats Declerations === \\
            int playerWeapon = rng.Next(Min, Max);
            int playerRange = rng.Next(Min, Max);
            int playerClass = rng.Next(Min, Max);

            // === Enemy Stats Declerations === \\
            int enemyWeapon = rng.Next(Min, Max);
            int enemyRange = rng.Next(Min, Max);
            int enemyClass = rng.Next(Min, Max);

            PlayerShip playerShip = new PlayerShip(playerWeapon, playerRange, playerClass, hull, integraty);
            EnemyShip enemyShip = new EnemyShip(enemyWeapon, enemyRange, enemyClass, hull, integraty);

            for (int i = 1; i < 10; i++) {
                Console.WriteLine(playerShip.Attack());
                Console.WriteLine(enemyShip.Attack());   
            }
            
        }

    }

}
