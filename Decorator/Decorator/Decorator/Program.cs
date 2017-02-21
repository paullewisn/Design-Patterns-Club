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
            Person pilot = new NonSuperButVeryTalentedIndividual();
            pilot = new Flight(pilot);

            Person superman = new SuperHero();
            superman = new Flight(superman);
            superman = new SuperStrength(superman);
            // TODO give superman xray vision by creating a new decorator
            // superman = new X-RayVision(superman);

            // TODO create a new superhero with whichever powers you'd like

            Console.WriteLine("Superman: " + superman.GetAbilities());
            Console.WriteLine("Pilot: " + pilot.GetAbilities());
        }

    }
}
