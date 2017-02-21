using System;
using Decorator.Component;
using Decorator.ConcreteComponent;
using Decorator.Decorator;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Person superman = new SuperHero(); 
            Person pilot = new NonSuperButVeryTalentedIndividual();

            superman = new Flight(superman);
            superman = new SuperStrength(superman);

            pilot = new Flight(pilot);

            Console.WriteLine("Superman: " + superman.GetAbilities());
            Console.WriteLine("Pilot: " + pilot.GetAbilities());
        }

    }
}
