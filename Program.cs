using System;

namespace Polymor_New
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.Goes();

            Dog dog = new Dog();
            dog.Goes();
        }
    }
}
