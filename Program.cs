using System;
using System.Threading;
using System.Diagnostics;
using System.IO;


namespace OOP_Uppgift {

    public class Program {
        static void Main(string[] args) {

            int Min = 1;
            int Max = 5;

            int hull = 500;
            int integraty = 1000;

            Random rng = new Random();

            // === Player Stats Declerations === \\
            int playerWeapon = rng.Next(Min, Max);
            int playerRange = rng.Next(Min, Max);
            int playerarmorClass = rng.Next(Min, Max);

            // === Enemy Stats Declerations === \\
            int enemyWeapon = rng.Next(Min, Max);
            int enemyRange = rng.Next(Min, Max);
            int enemyarmorClass = rng.Next(Min, Max);

            PlayerShip playerShip = new PlayerShip(playerWeapon, playerRange, playerarmorClass, hull, integraty);
            EnemyShip enemyShip = new EnemyShip(enemyWeapon, enemyRange, enemyarmorClass, hull, integraty);

            playerShip.CheckStats();
            

            int currentTurn = 0;

            TurnState turnState = TurnState.PlayerTurn;
            if (turnState == TurnState.PlayerTurn) {
                

            } else if(turnState == TurnState.EnemyTurn) {
                

            }
            
            Console.ReadKey();

            
        }

    }

}
