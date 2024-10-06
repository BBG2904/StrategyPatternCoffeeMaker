using StrategyPatternCoffeeMaker.Strategy_Interface;

namespace StrategyPatternCoffeeMaker.Strategy_Implementation
{
    public class Coffee : ICoffeeMaker
    {
        public void DoOperation()
        {
            Console.WriteLine("Make Coffee");
        }
    }
}
