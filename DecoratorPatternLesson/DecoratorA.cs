using DecoratorPatternLesson.Interfaces;

namespace DecoratorPatternLesson
{
    public class DecoratorA : IComponent
    {
        private readonly IComponent _component;

        public DecoratorA(IComponent component)
        {
            _component = component;
        }

        public string Operation()
        {
            var result = _component.Operation();
            result += "and listening to Classic FM ";

            return result;
        }
    }
}
