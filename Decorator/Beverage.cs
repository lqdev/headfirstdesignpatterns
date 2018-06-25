namespace Decorator
{
    abstract class Beverage
    {
        public string description { get; set; } = "Unknown Beverage";

        public string getDescription()
        {
            return description;
        }

        public abstract double cost();
    }
}