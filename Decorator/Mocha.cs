namespace Decorator
{
    class Mocha : CondimentDecorator
    {
        public Beverage beverage { get; set; }
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
            description = beverage.getDescription() + ", Mocha";
        }

        public override string getDescription()
        {
            return beverage.getDescription();
        }


        public override double cost()
        {
            return 0.20 + beverage.cost();
        }
    }
}