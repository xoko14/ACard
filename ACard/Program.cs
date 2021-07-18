using System;
using System.Collections.Generic;
using System.Text.Json;

namespace ACard
{
    class Program
    {
        public static List<Game> games = new List<Game>();

        static void Main(string[] args)
        {
            
        }

        static void LoadData()
        {

        }

        static void SaveData()
        {
            System.IO.File.WriteAllText(".\\saves.json", JsonSerializer.Serialize(games));
        }
    }
}
