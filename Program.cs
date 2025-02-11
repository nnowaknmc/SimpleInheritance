using System;

namespace Inheritance
{

    // base class
    class Animal
    {
        public string name;

        // constructor
        public Animal()
        {
            name = "";

        }
        //parameterized constructor
        public Animal(string name)
        {
            this.name = name;
        }

        public void display()
        {
            Console.WriteLine($"I am an animal, my name is {name}");
        }

    }

    // derived class of Animal 
    class Monkey : Animal
    {
        public string country;
        public int age;
        public string furColor;

        public Monkey()
            : base()
        {
            country = string.Empty;
            age = 0;
            furColor = string.Empty;
        }

        public Monkey(string name, string country, int age, string furColor)
            : base(name)
        {
            this.country = country;
            this.age = age;
            this.furColor = furColor;
        }

        public void display()
        {
            Console.WriteLine($"My name is {name}, I am a {age} year old monkey from {country}" +
                $" with {furColor} fur.");
        }
    }

    class Cow : Animal
    {
        public string country;
        public int age;
        public string furColor;

        public Cow()
            : base()
        {
            country = string.Empty;
            age = 0;
            furColor = string.Empty;
        }

        public Cow(string name, string country, int age, string furColor)
            : base(name)
        {
            this.country = country;
            this.age = age;
            this.furColor = furColor;
        }

        public void display()
        {
            Console.WriteLine($"My name is {name}, I am a {age} year old cow from {country}" +
                $" with {furColor} fur.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // object of base class
            Animal myPet = new Animal();
            myPet.name = "Sparky";
            myPet.display();

            // derived class object using default constructor
            Monkey myMonkey = new Monkey();
            myMonkey.name = "Bobo";
            myMonkey.country = "Brazil";
            myMonkey.age = 3;
            myMonkey.furColor = "Brown";
            myMonkey.display();

            //derived class object using parameterized constructor
            Monkey newMonkey = new Monkey("Gregory", "China", 5, "White");
            newMonkey.display();

            Cow myCow = new Cow();
            myCow.name = "Bessie";
            myCow.country = "USA";
            myCow.age = 2;
            myCow.furColor = "Brown";
            myCow.display();

            Cow newCow = new Cow("Milton", "Germany", 7, "black and white");
            newCow.display();
        }

    }
}
