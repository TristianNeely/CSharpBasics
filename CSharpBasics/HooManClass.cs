using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    public class HooManClass
    {
        // Atributes
        public string name;
        public int age;
        public bool hasDog;
        public string dogName;

        // Methods

        public void Greeting()
        {
            if (hasDog == true)
            { 
                Console.WriteLine($"Hello {name}. Nice to meet you. I see you have a dog named {dogName}. Cool name bro. It's nice to see someone at the age of {age} that has a dog.");

        }
           else
           {
                Console.WriteLine($"What {name}!!! you don't own a dog? Someone {age} years old, should really own a dog");
           }

           }
    }
}
