using Decorator.Component;

namespace Decorator.ConcreteComponent
{
    class SuperHero : Person
    {
        public SuperHero()
        {
            Abilities = "Extraordinary abilities";
        }

        public override string GetAbilities()
        {
            return Abilities;
        }
    }
}
