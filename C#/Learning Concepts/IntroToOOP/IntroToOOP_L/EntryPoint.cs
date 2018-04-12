using System;
using IntroToOOP_L;

class EntryPoint
{
    static void Main()
    {
        User user = new User("Bloom", "Earthling");

        User secondUser = new User();

        User thirdUser = new User();

        Utilities.ColorfulWriteline(user.Username, ConsoleColor.DarkRed);


        Console.WriteLine(user.ID);
        Console.WriteLine(secondUser.ID);
        Console.WriteLine(thirdUser.ID);
        Console.WriteLine(User.currentID);


        Console.ReadLine();
    }
}

