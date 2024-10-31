using System.Collections.Generic;

namespace ArrayListsDemoCSharp_51;

class Program
{
    static void Main(string[] args)
    {
        //Arrays
        //Arrays have set size that you will definte at creation and that size cannot change
        int[] numbers = new int[] { 12, 33, 4, 50, 55, 87, 900, 33, 87, 1 };

        numbers[9] = 1000;
        
        // foreach (var thing in numbers)
        // {
        //     Console.WriteLine(thing);
        // }

        var names = new string[] { "Seth", "Cruz", "Miah" };
        
        //Arrays have a property called 'Length' that shows you the number of items in the array
        Console.WriteLine(names.Length);
        Console.WriteLine(names.Length - 1);

        // for (int i = 0; i <= names.Length - 1; i++)
        // {
        //     Console.WriteLine(names[i]);
        // }

        // for (int i = names.Length - 1; i >= 0; i--)
        // {
        //     Console.WriteLine(names[i]);
        // }
        
        //Lists
        //Lists have a size that you can change all you want
        List<int> numbersList = new List<int>();

        for (int i = 1; i <= 100; i++)
        {
            numbersList.Add(i);
        }
        
        numbersList.Add(2000);
        numbersList.Remove(2000);
        
        //Lists have property called 'Count' that shows the amount of items in the List

        for (int i = 0; i <= numbersList.Count - 1; i++)
        {
            Console.WriteLine(numbersList[i]);
        }

    }
}