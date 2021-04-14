using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class


            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            Bird tweety = new Bird() { Name = "Tweety", Age = 2, Legs = 2, Sex = "female", doesItFly = "flys", canItMimic = "mimics", featherColors = 2};

            Console.WriteLine($"{tweety.Name} is a {tweety.Sex}, {tweety.Age} year old bird, with {tweety.featherColors} feather colors, that {tweety.doesItFly} and {tweety.canItMimic} other birds.");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            Reptile scaley = new Reptile() { Name = "Scaley", Age = 5, Legs = 4, Sex = "male",  coldBlooded = "cold",  laysEggs = "lays",  scaleColors = 2 };

            Console.WriteLine($"{scaley.Name} is a {scaley.Sex}, {scaley.Age} year old reptile, with {scaley.scaleColors} scale colors, that {scaley.laysEggs} eggs and is {scaley.coldBlooded} blodded.");
        }
    }
}
