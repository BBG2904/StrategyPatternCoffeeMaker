using StrategyPatternCoffeeMaker.Strategy_Interface;

namespace StrategyPatternCoffeeMaker
{
    public class CoffeeMakerContext
    {
        private  ICoffeeMaker? _coffeeMaker = null;

        public CoffeeMakerContext()
        {
        }

        public void ChooseOption(ICoffeeMaker optionSelected)
        {
            _coffeeMaker = optionSelected;
        }

        public void DoOperation()
        {
            _coffeeMaker?.DoOperation();
        }
    }
}
