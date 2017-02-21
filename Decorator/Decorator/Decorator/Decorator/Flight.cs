using System;
using Decorator.Component;

namespace Decorator.Decorator
{
    public class Flight : AbilitiesDecorator
    {
        public Flight(Person person): base(person)
        {
            Abilities = "flight";
        }

        public override string GetAbilities()
        {
            return String.Format("{0}, {1}", _person.GetAbilities(), Abilities);
        }
    }
}
