using System;
using IntroToOOP_L;

    class User
    {
        public static int currentID;

        public readonly int HEIGHT;

        //all in caps with underscore for multiple words
        //depends on company, some use Pascal case
        public readonly int ID;

        public string race;

        private string username;
        private int password;

        public string Username
        {
            get
            {
                return "The username is " + username;
            }
        }

        public int Password
        {
            set
            {
                if (value >= 4 && value <= 10)
                {
                    password = value;
                }
                else
                {
                    Console.WriteLine("Oops, this is not a valid password! Please use a password between 4 and 10");
                }
            }
        }

        public User()
        {
            currentID++;
            ID = currentID;
        }

        public User(string username, string race)
        {
            currentID++;
            ID = currentID;
            this.username = username;
            this.race = race;

            if (this.race == "Martian")
            {
                HEIGHT = 100;
            }
            else if (this.race == "Earthling")
            {
                HEIGHT = 180;
            }
        }

    public void SayMyName()
    {
        Utilities.ColorfulWriteline(username, ConsoleColor.DarkGreen);
    }
    }