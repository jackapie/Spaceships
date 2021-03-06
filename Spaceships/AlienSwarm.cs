﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaceships
{
    public class AlienSwarm
    {

        //property
        public List<Alien> Aliens { get; set; }

        //Constructor function
        public AlienSwarm()
        {
            //The below code is equivalent to this.aliens = new List<Alien>();
            //this. denotes that aliens is the name of a property of the class AlienSwarm, for which this construcor is written.
            // Writing a return type before aliens (eg. var or List<Alien>) would create an object that would be unrelated to the property we want.

            Aliens = new List<Alien>();


            for (int Counter = 0; Counter < 10; Counter++)
            {
                var alienBlue = new BlueAlien(Counter, GameArea.maxY);
                Aliens.Add(alienBlue);
              


                var alienRed = new RedAlien(Counter, GameArea.maxY -1);
                Aliens.Add(alienRed);
               


                var alienGreen = new GreenAlien(Counter, GameArea.maxY -2);
                Aliens.Add(alienGreen);
               

            }



        }

        void AlienSwarmMoveRight()
        {
            foreach (var alien in Aliens)
            {
                alien.Move(1, 0);
            }
        
        }

        void AlienSwarmMoveLeft()
        {
            foreach (var alien in Aliens)
            {
                alien.Move(-1, 0);
             
            }
        }

        void AlienSwarmMoveDown()
        {
            foreach (var alien in Aliens)
            {
                alien.Move(0, -1);
               
            }
        }

        //Write a function so that: 
        //if any alien has x = MaxX, then run AlienSwarmMoveDown, followed by AlienSwarmMoveLeft, 
        //repeat AlienSwarmMoveLeft until any alien has x=0.
        //if any alien has x = 0, then run AlienSwarmMoveDown, followed by AlienSwarmMoveRight, 
        //repeat AlienSwarmMoveRight until any alien has x=MaxX.



        bool MovingRight = true;


        public void AlienSwarmMove(int maxX)
        {
            var MovingDown = false;

            // BLOCK FOR WORKING OUT WHAT WE'RE DOING
            {
                
                foreach (var alien in Aliens)
                {
                    if (alien.X == maxX)
                    {
                       

                        MovingDown = true;

                        MovingRight = false;
                    }
                }

                foreach (var alien in Aliens)
                {
                    if (alien.X == 0)
                    {
                        MovingDown = true;
                       
                        MovingRight = true;
                    }
                }
            }

            // BLOCK FOR ACTUALLY MOVING THE SWARM
            {
                if (MovingRight == true)
                {
                    AlienSwarmMoveRight();
                }
                else
                {
                    AlienSwarmMoveLeft();
                }

                if (MovingDown == true)
                {
                    AlienSwarmMoveDown();
                }
                
            }
        }

    }
}
