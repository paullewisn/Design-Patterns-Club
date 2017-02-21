using Decorator.Component;

namespace Decorator.Decorator
{
    public class AbilitiesDecorator : Person
    {
        protected Person _person;

        public AbilitiesDecorator(Person person)
        {
            _person = person;
        }
        public override string GetAbilities()
        {
            return _person.GetAbilities();
        }
    }
}
