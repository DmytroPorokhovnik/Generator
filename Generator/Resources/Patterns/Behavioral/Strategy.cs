using System;

//Strategy - 0
//ConcreteStrategyA - 1
//ConcreteStrategyB - 2
//ConcreteStrategyC - 3
//Context - 4
//AlgorithmInterface - 5
//ContextInterface - 6
namespace {0}
{
    abstract class {0}
    {
        public abstract void {5}();
    }

    class {1} : {0}
    {
        public override void {5}()
        {
           //...
        }
    }

    class {2} : {0}
    {
        public override void {5}()
        {
            //...
        }
    }

    class {3} : {0}
    {
        public override void {5}()
        {
            //...
        }
    }

    class {4}
    {
        {0} strategy;

        public {4}({0} strategy)
        {
            this.strategy = strategy;
        }

        public void {6}()
        {
            strategy.{5}();
        }
    }
}
