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
            switch (args[0])
            {
                case "add":
                    switch (args[1])
                    {
                        case "game":
                            AddGame(args[2], args[3]);
                            break;
                        case "profile":
                            AddProfile(args[2], args[3]);
                            break;
                    }
                    break;

                case "remove":
                    switch (args[1])
                    {
                        case "game":
                            RemoveGame(args[2]);
                            break;
                        case "profile":
                            RemoveProfile(args[2]);
                            break;
                    }
                    break;

                case "switch":
                    SwitchProfile(args[1], args[2]);
                    break;
            }
        }

        private static void LoadData()
        {

        }

        private static void SaveData()
        {
            System.IO.File.WriteAllText(".\\saves.json", JsonSerializer.Serialize(games));
        }

        private static void AddGame(string name, string location)
        {

        }

        private static void AddProfile(string name, string id)
        {

        }

        private static void RemoveGame(string name)
        {

        }

        private static void RemoveProfile(string name)
        {

        }

        private static void SwitchProfile(string game, string profile)
        {

        }
    }
}
