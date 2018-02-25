using DecoratorPatternLesson.Interfaces;

namespace DecoratorPatternLesson
{
    public class DecoratorB : IComponent
    {
        private readonly IComponent _component;

        public string AddedState = "past the Coffee Shop ";

        public DecoratorB(IComponent component)
        {
            _component = component;
        }

        public string Operation()
        {
            var result = _component.Operation();
            result += "to school ";

            return result;
        }

        public string AddedBehavior()
        {
            return "and I bought a cappuccino ";
        }
    }
}
