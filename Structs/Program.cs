using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    internal class Program
    {
        // structs

        struct Vector2
        {
            public int x;
            public int y;
        }




        //player 
        static Vector2 position;
        //....
        //....
        //....


        //enemies 
        static Vector2 enemy1Position;
        //....
        //....
        //....

        //enemies 
        static Vector2[] enemyPositions = new Vector2[100];

        struct Weapon
        {
           public int strength;
           public int durability;
           public int speed;
        }

        // weapons 
        static Weapon sword;
        static Weapon knife;
        static Weapon Deatomizer;

        

        static void Main(string[] args)
        {
            sword.strength = 20;
            sword.durability = 75;

            Deatomizer.strength = 100;
            Deatomizer.durability = 10;

            knife.strength = 5;
            knife.durability = 50;

            Console.WriteLine("Structs");

            Console.ReadKey(true);
        }
    }
}
