using StrategyPatternCoffeeMaker.Strategy_Interface;

namespace StrategyPatternCoffeeMaker.Strategy_Implementation
{
    public class Milk : ICoffeeMaker
    {
        public void DoOperation()
        {
            Console.WriteLine("Make Milk");
        }
    }
}
