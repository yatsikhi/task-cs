using System;
using System.Collections.Generic;

class Animal
{
    public int Id { get; set;  }
    public string Name { get; set; } 
    public string  Country  { get; set; }
    public int Age { get; set; }
    public bool IsFed {  get; set; }


    public Animal(int id, string name , string country , int age , bool isfed)
    {
        Id = id;
        Name = name;
        Country = country;
        Age = age;
        IsFed = isfed;
    }
}


class AddAnimal
{
    static void Main()
    {
        List<Animal> animals = new List<Animal>
        {
            new Animal(1, "Kokofanto Elephanto" , "Italian" , 3 , true),
            new Animal(2, "Shimpanzini Bananini", "Italian", 500, true),
            new Animal(3, "Ornitorrinco Televisao", "Portugal", 40, true),
            new Animal(4, "Sovieto Elephino", "Russia", 1991, true)
        };
        PrintTable(animals);

        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            PrintTable(animals);

            Console.WriteLine("type in:");
            Console.WriteLine("1 - new    Name ");
            Console.WriteLine("2 - new    Counrty ");
            Console.WriteLine("3 - new    Age");
            Console.WriteLine("4 - change isfed");
            Console.WriteLine("5 - exit");
            

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    ChangeName(animals);
                    break;
                case "2":
                    ChangeCountry(animals);
                    break;
                case "3":
                    ChangeAge(animals);
                    break;
                case "4":
                    ChangeIsFed(animals);
                    break;
                case "5":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("error");
                    Console.ReadKey();
                    break;
            }
        }

        



    }
    static void PrintTable(List<Animal> animals)
    {
        Console.WriteLine("{0, -5} {1, -25} {2, -10} {3, -5} {4, -5}", "ID", "Name", "Country", "Age", "IsFed");
        Console.WriteLine(new string('-', 55));

        foreach (var animal in animals)
        {
            Console.WriteLine("{0, -5} {1, -25} {2, -10} {3, -5} {4, -5}",
                animal.Id, animal.Name, animal.Country, animal.Age, animal.IsFed);
        }
    }

    static void ChangeName(List<Animal> animals)
    {
        Console.Write("tape ID animal: ");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            var animal = animals.Find(a => a.Id == id);
            if (animal != null)
            {
                Console.Write("tape new name: ");
                animal.Name = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("nothing found");
            }
        }
        else
        {
            Console.WriteLine("wrong  ID.");
        }
    }

    static void ChangeCountry(List<Animal> animals)
    {
        Console.Write("tape ID animal: ");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            var animal = animals.Find(a => a.Id == id);
            if (animal != null)
            {
                Console.Write("tape new coyntry:");
                animal.Country = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("nothing found");
            }
        }
        else
        {
            Console.WriteLine("wrong  ID.");
        }
    }

    static void ChangeAge(List<Animal> animals)
    {
        Console.Write("tape ID animal: ");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            var animal = animals.Find(a => a.Id == id);
            if (animal != null)
            {
                Console.Write("tape new age: ");
                if (int.TryParse(Console.ReadLine(), out int age))
                {
                    animal.Age = age;
                }
                
            }
            else
            {
                Console.WriteLine("nothing found");
            }
        }
        else
        {
            Console.WriteLine("wrong  ID.");
        }
    }

    static void ChangeIsFed(List<Animal> animals)
    {
        Console.Write("tape ID animal: ");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            var animal = animals.Find(a => a.Id == id);
            if (animal != null)
            {
                Console.Write("(true/false): ");
                if (bool.TryParse(Console.ReadLine(), out bool isFed))
                {
                    animal.IsFed = isFed;
                }
                else
                {
                    Console.WriteLine("wrong ");
                }
            }
            else
            {
                Console.WriteLine("nothing found");
            }
        }
        else
        {
            Console.WriteLine("wrong  ID.");
        }
    }
}
