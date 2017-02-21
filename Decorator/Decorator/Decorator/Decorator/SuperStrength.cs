using System;
using Decorator.Component;

namespace Decorator.Decorator
{
    public class SuperStrength : AbilitiesDecorator
    {
        public SuperStrength(Person person) : base(person)
        {
            Abilities = "super strength";
        }

        public override string GetAbilities()
        {
            return String.Format("{0}, {1}", _person.GetAbilities(), Abilities);
        }
    }
}
