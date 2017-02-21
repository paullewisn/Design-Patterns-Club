using Decorator.Component;

namespace Decorator.ConcreteComponent
{
    class NonSuperButVeryTalentedIndividual : Person
    {
        public NonSuperButVeryTalentedIndividual()
        {
            Abilities = "Slightly Above Average Abilities";
        }
        public override string GetAbilities()
        {
            return Abilities;
        }
    }
}
