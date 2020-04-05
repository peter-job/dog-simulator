using System;

namespace SmartDog
{
    class Program
    {
        static void Main(string[] args)
        {
           var dog = new SmartDog();
           dog.Talk();
           dog.Talk();
           dog.Talk();
           dog.StartTellingMusings();
           dog.Talk();
           dog.Talk();
           dog.StartSingingSongs();
           dog.Talk();
           dog.Talk();
           dog.Talk();
           Console.WriteLine("The end.");
        }
    }
}