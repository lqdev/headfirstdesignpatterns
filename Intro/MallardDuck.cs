using System;

namespace Intro
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new Quack();
        }

        public override void display()
        {
            Console.WriteLine("I'm a real Mallard Duck");
        }
    }
}