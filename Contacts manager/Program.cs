using System;
using System.Collections.Generic;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        // Create a dictionary to store contact information
        Dictionary<string, string> dict = new Dictionary<string, string>();

        // Prompt the user for input and perform the requested operation
        bool quit = false;
        while (!quit)
        {
            Console.WriteLine("Enter a command (add, view, remove, list, quit):");
            string command = Console.ReadLine();

            if (command == "add")
            {
                //Complete this section
                string name = Console.ReadLine();
                string number = Console.ReadLine();
                dict.Add(name, number);
            }
            else if (command == "view")
            {
                //Complete this section
                string name = Console.ReadLine();
                foreach (KeyValuePair<string, string> n in dict)
                {
                    if (n.Key == name)
                    {
                        Console.WriteLine($"Phone number: {n.Value}");
                        continue;
                    }
                    Console.WriteLine("Contact not found");
                }
            }
            else if (command == "remove")
            {
                //Complete this section
                string name = Console.ReadLine();
                if (dict.ContainsKey(name))
                {
                    dict.Remove(name);
                }
            }
            else if (command == "list")
            {
                //Complete this section
                foreach (KeyValuePair<string, string> n in dict)
                {
                    Console.WriteLine($"{n.Key}: {n.Value}");
                }
            }
            else if (command == "quit")
            {
                quit = true;
            }
            else
            {
                Console.WriteLine("Invalid command.");
            }
        }
    }
}