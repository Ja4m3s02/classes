﻿using System;
using Raylib_cs;

namespace AIE_01_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            GameSettings gs = new GameSettings(800, 450, "hello raylib");
            
            Raylib.InitWindow(gs.windowWidth, gs.windowHeight, gs.windowTitle);

            while(Raylib.WindowsShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(ConsoleColor.RAYWHITE);
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

            // lets create a Person instance
            Person James = new Person();
            James.name = "James";
            James.age = 8;
            James.height = 140;

        
    }
}