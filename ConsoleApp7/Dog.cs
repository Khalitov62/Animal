using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class Dog:Animal
    {
        public string Smell;



        public Dog(string smell, string meal)
        {
            Smell = smell;
           


            Dog dog = new Dog($"Iy bilme qabiliyyeti gucludu","Et yiyir");
            dog.Dog1();
        }
        public string Dog1()
        {
            return $"Smell: {Smell}, Meal: {Meal}";
        }
    }
    
}
