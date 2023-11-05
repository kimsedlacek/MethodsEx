using System.Runtime.InteropServices;

namespace MethodsExercise
{
    public class Program
    //Anna Explorer has discovered a new mammal
    //how many legs does it walk on
    //is its body covered with hair, fur or just skin
    //what is its primary color
    //is it a carnivore of herbivore
    //is it friendly 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string Name = Console.ReadLine();

            Console.WriteLine("How many years were you in the jungle of Nicaragua?");
            string Years = Console.ReadLine();

            Console.WriteLine("How many legs does this animal walk on?");
            string Legs = Console.ReadLine();

            Console.WriteLine("Is its body covered with hair, fur, or just skin?");
            string Body = Console.ReadLine();

            Console.WriteLine("What color is its fur?");
            string Fur = Console.ReadLine();

            Console.WriteLine("Is it a carnivore or herbivore or something else?");
            string Eats = Console.ReadLine();

            Console.WriteLine($"{Name} was in the jungle of Nicaragua for {Years} years! It has all paid off " +
            $"though, she has discovered a new mammal!  Here are some of the first facts we have about the animal. " +
            $"It has {Legs} legs, its body is covered with {Fur} color {Body} and it is a {Eats}. Good thing " +
            $"it's not a carnivore or {Name} may not have made it out to tell us about this interesting new " +
            $"discovery!");
        }
    }   
               
}
