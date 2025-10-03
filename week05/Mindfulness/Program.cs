using System;

//Showing creativity/Exceeding requirements: I added an animation for the breathing activity where the words "breathe in" expand with the count down, and the words "breathe out" contract with the count down.
class Program
{
    static void Main(string[] args)
    {
        //loop for mindfulness choices
        string choice;
        do
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Start breathing activity");
            Console.WriteLine("   2. Start reflecting activity");
            Console.WriteLine("   3. Start listening activity");
            Console.WriteLine("   4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
            }

            if (choice == "2")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
            }

            if (choice == "3")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
            }
        } while (choice != "4");

    }
}