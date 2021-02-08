using System;
using Raylib_cs;

namespace AIE_01_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
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

            // lets create a Person instance
            Person james = new Person();
            James.name = "James";
            James.age = 8;
            James.height = 140;



        }
 



        
    }
}