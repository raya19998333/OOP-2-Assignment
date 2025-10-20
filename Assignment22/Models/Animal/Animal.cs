using Assignment22.Models.Animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment22.Models.Animal
{
    abstract class Animal
    {
        // Property to store the name of the animal
        public string Name;

        // Constructor to initialize the animal's name \
        public Animal(string name)
        {
            Name = name;
            
        }
        // Abstract method MakeSound() to be implemented by derived classes
        public abstract void MakeSound();

    }
}
// Create three derived classes:
// - Dog (makes "Woof" sound)
//
class Dog : Animal
{
    // Constructor to initialize the dog's name
    
    public Dog(string name) : base(name) { }

    // Implement MakeSound() method
    public override void MakeSound()
    {
        
        Console.WriteLine($"{Name} says: Woof!");
    }
}

// - Cat (makes "Meow" sound)
class Cat : Animal
{
    // Constructor to initialize the cat's name
    public Cat(string name) : base(name) { }
    // Implement MakeSound() method
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} says: Meow!");
    }
}
// - Cow (makes "Moo" sound)
class Cow : Animal
{
    // Constructor to initialize the cow's name
    public Cow(string name) : base(name) { }
    // Implement MakeSound() method
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} says: Moo!");
    }
}



