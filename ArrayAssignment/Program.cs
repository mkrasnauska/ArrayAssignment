using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        int[] numArray = { 2, 4, 8, 16, 32, 64, 128, 256, 512 };
        Console.WriteLine("Please select an index number from 0 to 8");
        string Number = Console.ReadLine();

        if (Convert.ToInt32(Number) < 8 && Convert.ToInt32(Number) > 0)
        {


            int indexNum = Convert.ToInt32(Number);
            Console.WriteLine(numArray[indexNum]);

        }
        else
        {
            Console.WriteLine("Wrong index please try again");
            Console.WriteLine("Please select an index number from 0 to 8");
            Number = Console.ReadLine();
            int indexNum = Convert.ToInt32(Number);
            Console.WriteLine(numArray[indexNum]);
            Console.ReadLine();
        }


        string[] stringArray = { "A", "B", "C", "D", "E", "F", "G", "H", "I" };
        Console.WriteLine("\nPlease select an index number from 0 to 8");
        string Number1 = Console.ReadLine();
        if (Convert.ToInt32(Number1) < 8 && Convert.ToInt32(Number1) > 0)
        {


            int indexNum = Convert.ToInt32(Number);
            Console.WriteLine(stringArray[indexNum]);

        }
        else
        {
            Console.WriteLine("Wrong index please try again");
            Console.WriteLine("Please select an index number from 0 to 8");
            Number = Console.ReadLine();
            int indexNum = Convert.ToInt32(Number);
            Console.WriteLine(numArray[indexNum]);

        }

        List<string> stringList = new List<string>();
        stringList.Add("Hello");
        stringList.Add("Friend");
        stringList.Add("How");
        stringList.Add("Are");
        stringList.Add("You");
        Console.WriteLine("Please select index Number from 0 To 4");
        string number2 = Console.ReadLine();
        int indexNumber = Convert.ToInt32(number2);
        Console.WriteLine(stringList[indexNumber]);
        Console.ReadLine();

    }
}