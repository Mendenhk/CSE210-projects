using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int choice = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (choice != 0)
        {
            Console.Write("Enter number: ");
            choice = int.Parse(Console.ReadLine());
            if (choice != 0)
            {
                numbers.Add(choice);
            }
        }

        int i = 0;
        int sum = 0;
        int largestNumber = -10000;
        int smallestPos = 10000000;
        foreach (int item in numbers)
        {
            sum += item;
            i++;
            if (item > largestNumber)
            {
                largestNumber = item;
            }
            if (item > 0 && item < smallestPos)
            {
                smallestPos = item;
            }
        }
        Console.WriteLine($"The sum is: {sum}");
        float average = (float)sum / i;  //changes sum to float so the average will calculate as a float
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
        Console.WriteLine($"The smallest positive number is: {smallestPos}");
        numbers.Sort();  //sorts the list
        Console.WriteLine("The sorted list is:");
        foreach (int item in numbers)
        {
            Console.WriteLine(item);
        }
    }
}