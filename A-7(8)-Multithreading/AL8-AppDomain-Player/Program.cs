﻿using System;

namespace Advanced_Lesson_6_AppDomain_Player
{
    public class Program
    {
        static void Main(string[] args)
        {
            var playerName = args.Length > 0 ? args[0] : "Undefined";
            var player = new Player($"Player {playerName}");
            player.Play();            
        }
    }
}
