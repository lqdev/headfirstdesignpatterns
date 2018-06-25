namespace Decorator
{
    class SteamedMilk : CondimentDecorator
    {
        public Beverage beverage { get; set; }
        public SteamedMilk(Beverage beverage)
        {
            this.beverage = beverage;
            description = beverage.getDescription() + ", SteamedMilk";
        }

        public override string getDescription()
        {
            return beverage.getDescription();
        }


        public override double cost()
        {
            return 0.10 + beverage.cost();
        }
    }
}