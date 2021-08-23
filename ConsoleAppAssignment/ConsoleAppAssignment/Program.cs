using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        //string[] names = { "Tom", "Westen", "Shadow", "Amy", "Ebony" };
        //Console.WriteLine("Type \"funny\", \"nice\", or \"happy\", then press enter.");
        //string adjective = Console.ReadLine();

        // for (int i = 0; i < names.Length; i++)
        // {
        //  names[i] = names[i] + " is " + adjective;
        // }

        // for (int i = 0; i < names.Length; i++)
        // {
        //     Console.WriteLine(names[i]);
        // }
        // Console.ReadLine();

        //while (true)
        //{
        //    Console.WriteLine("Hello, World!");
        //}

        //while (true)
        //{
        //    Console.WriteLine("Hello, World!");
        //    Console.ReadLine();
        //}

        //List<int> testScores = new List<int>() { 98, 99, 81, 72, 70 };

        //foreach (int score in testScores)
        //{
        //    if (score < 80)
        //    {
        //        Console.WriteLine("Passing test score:" + score);
        //    }
        //}

        //Console.ReadLine();

        //List<int> testScores = new List<int>() { 98, 99, 81, 72, 70 };

        //foreach (int score in testScores)
        //{
        //    if (score <= 81)
        //    {
        //        Console.WriteLine("Passing test score:" + score);
        //    }
        //}

        //Console.ReadLine();

        //List<string> colours = new List<string>() { "red", "blue", "green", "purple", "pink", "yellow", "orange" };
        //Console.WriteLine("Type a colour in lowercase to find the index");
        //string colour = Console.ReadLine();
        //int index = -1;


        //for (int i = 0; i < colours.Count; i++)
        //{
        //    if(colours[i] == colour)
        //    {
        //        index = i;

        //    }


        //}

        //if (index != -1) 
        //{
        //    Console.WriteLine("The matching index is:" + index);

        //}

        //else
        //{
        //    Console.WriteLine("No mathcing index.");
        //}

        //Console.ReadLine();

        //List<string> carMakes = new List<string>() { "toyota", "ford", "nissan", "chevy", "honda", "toyota", "kia" };
        //Console.WriteLine("type a car company in lowercase to find the index");
        //string carMake = Console.ReadLine();
        //List<int> indices = new List<int>() {};
        //bool result = false;


        //for (int i = 0; i < carMakes.Count; i++)
        //{
        //    if (carMakes[i] == carMake)
        //    {
        //        indices.Add(i);
        //        result = true;

        //    }


        //}


        //if  (result == true)
        //{
        //    Console.WriteLine("The matching indices are:");

        //    foreach (int index in indices)
        //    {
        //        Console.WriteLine(index);
        //    }

        //}

        //else
        //{
        //    Console.WriteLine("No mathcing indices.");
        //}

        //Console.ReadLine();

        List<string> names = new List<string>() { "Tom", "Jesse", "Derek", "Tom", "Sarah" };
        List<string> names2 = new List<string>();
        bool result = false;
        string matchingName;

        foreach (string name in names)
        {

            names2.Add(name);
            names.Remove(name);

            foreach (string name2 in names2)
            {
                if (names.Contains(name2))
                {
                    result = true;
                    matchingName = name2;

                    Console.WriteLine("The name " + matchingName + " is a duplicate.");
                    break;
                }

            }
        }



        if (result != true)
        {
            Console.WriteLine("There are no matching names");
        }


        Console.ReadLine();


    }
}
