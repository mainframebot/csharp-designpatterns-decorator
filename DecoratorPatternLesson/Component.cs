using DecoratorPatternLesson.Interfaces;

namespace DecoratorPatternLesson
{
    public class Component : IComponent
    {
        public string Operation()
        {
            return "I am walking ";
        }
    }
}
