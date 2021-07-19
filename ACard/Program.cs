using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace ACard
{
    class Program
    {
        public static List<Game> games = new List<Game>();
        private static string savesPath = ".\\saves.json";

        static void Main(string[] args)
        {
            LoadData();

            switch (args[0])
            {
                case "add":
                    switch (args[1])
                    {
                        case "game":
                            AddGame(args[2], args[3]);
                            break;
                        case "profile":
                            AddProfile(args[2], args[3], args[4]);
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
            SaveData();
        }

        private static void LoadData()
        {
            try
            {
                using (StreamReader jsonStream = File.OpenText(savesPath))
                {
                    var json = jsonStream.ReadToEnd();
                    games = JsonConvert.DeserializeObject<List<Game>>(json);
                }
            }
            catch
            {
                System.IO.File.WriteAllText(savesPath, "[]");
            }
            

        }

        private static void SaveData()
        {
            System.IO.File.WriteAllText(savesPath, JsonConvert.SerializeObject(games));
        }

        private static void AddGame(string name, string location)
        {
            bool add = true;

            foreach (Game game in games)
            {
                if(game.Name == name)
                {
                    Console.WriteLine("Game already added.");
                    add = false;
                    break;
                }
            }

            if(add) games.Add(new Game(name, location));
        }

        private static void AddProfile(string gameName, string name, string id)
        {
            bool add = false;

            foreach (Game game in games)
            {
                if (game.Name == gameName)
                {
                    add = true;
                    foreach(Profile profile in game.Profiles)
                    {
                        if(profile.Name == name)
                        {
                            Console.WriteLine("Profile already added.");
                            add = false;
                            break;
                        }
                    }

                    if (add) game.Profiles.Add(new Profile(name, id));
                    add = true;
                }
            }
            if (!add) Console.WriteLine("Game \"" + gameName + "\" not added.");
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
