using DecoratorPatternLesson;
using NUnit.Framework;

namespace DecoratorPatternTests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Testing()
        {
            var component = new Component();

            var componentTest = component.Operation();

            var decoratorA = new DecoratorA(component);
            var decoratorB = new DecoratorB(component);

            var decoratorATest = decoratorA.Operation();
            var decoratorBTest = decoratorB.Operation();

            var decoratorBA = new DecoratorB(new DecoratorA(component));
            var decoratorAB = new DecoratorA(new DecoratorB(component));

            var decoratorBATest = decoratorBA.Operation();
            var decoratorABTest = decoratorAB.Operation();

            var result = decoratorB.AddedState + decoratorB.AddedBehavior();
        }
    }
}
