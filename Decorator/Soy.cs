namespace Decorator
{
    class Soy : CondimentDecorator
    {
        public Beverage beverage { get; set; }
        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
            description = beverage.getDescription() + ", Soy";
        }

        public override string getDescription()
        {
            return beverage.getDescription();
        }


        public override double cost()
        {
            return 0.15 + beverage.cost();
        }
    }
}