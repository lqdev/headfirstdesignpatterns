namespace Decorator
{
    class Whip : CondimentDecorator
    {
        public Beverage beverage { get; set; }
        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
            description = beverage.getDescription() + ", Whip";
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