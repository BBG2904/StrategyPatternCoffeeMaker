using StrategyPatternCoffeeMaker.Strategy_Interface;

namespace StrategyPatternCoffeeMaker.Strategy_Implementation
{
    public class Tea : ICoffeeMaker
    {
        public void DoOperation()
        {
            Console.WriteLine("Make Tea");
        }
    }
}
