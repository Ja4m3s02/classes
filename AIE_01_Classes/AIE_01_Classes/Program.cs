using System;
using Raylib_cs;

namespace AIE_01_Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            Person james = new Person();
            james.name = "James";
            james.age = 8;
            james.height = 140;

            Person jarred = new Person();
            jarred.name = "jarred";
            jarred.age = 8;
            jarred.height = 140;

            GameSettings gs = new GameSettings(800, 450, "hello raylib");
            
            Raylib.InitWindow(gs.windowWidth, gs.windowLength, gs.windowTitle);

            while(Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(ConsoleColor.WHITE);
                Raylib.EndDrawing();
            }
            Raylib.CloseWindow();
        }

        class Person
        {
            public string name = "James";
            public int age;
            public float height;
        }

            



        
 



        
    }
}