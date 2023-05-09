using System;
using System.Threading;
using System.Diagnostics;

namespace OOP_Uppgift {

    public class Program {
        static void Main(string[] args) {

            // === Ship Declerations === \\
            PlayerShip playerShip;
            EnemyShip enemyShip;

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
            Random rng = new Random();
            int[] temp = Enumerable
                .Repeat(Min, Max)
                .Select(i => rng.Next(Min, Max))
                .ToArray();

            foreach (int element in temp) {
                Console.WriteLine(element);
            }
        }

    }

}
