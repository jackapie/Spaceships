using Spaceships;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShipUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            var game = new GameArea();

            Task.Run(() =>
            {
                KeyHandling();
            });

            while (true)
            {
                Console.Clear();

                game.PlayTurn();

                switch(currentAction)
                {
                    case "LEFT":
                        game.ship.Move(-1, 0);
                        break;
                    case "RIGHT":
                        game.ship.Move(1, 0);
                        break;
                    case "FIRE":
                        game.Fire();
                        break;
                }

                currentAction = "";
                foreach (var alien in game.AlienSwarm.Aliens)
                {
                    Console.SetCursorPosition(alien.X, alien.Y);

                    Console.Write(alien.Colour[0]);
                }

                Console.SetCursorPosition(game.ship.X, game.ship.Y);
                Console.Write("S");

                if (game.Gun != null)
                {
                    Console.SetCursorPosition(game.Gun.X, game.Gun.Y);
                    Console.Write("X");
                }

                System.Threading.Thread.Sleep(300);
            }
        }

        static string currentAction = "";
        static void KeyHandling()
        {

            
            while (true)
            {
                var result = Console.ReadKey(true);

                switch (result.KeyChar)
                {
                    case 'z':
                    case 'Z':
                        currentAction = "LEFT";
                        break;
                    case 'x':
                    case 'X':
                        currentAction = "RIGHT";
                        break;
                    case ' ':
                        currentAction = "FIRE";
                        break;
                }
            }
            
        }
    }
}
