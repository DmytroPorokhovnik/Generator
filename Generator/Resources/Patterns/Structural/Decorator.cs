using System;

//Decorator - 0
//Component - 1
//ConcreteComponent - 2
//ConcreteDecoratorA - 3
//ConcreteDecoratorB - 4
//Operation - 5
//AddedBehavior - 6
namespace {0}
{
    abstract class {0} : {1}
    {
        public {1} {1} { protected get; set; }

        public override void {5}()
        {
            if ({1} != null)
                {1}.{5}();
        }
    }

    abstract class {1}
    {
        public abstract void {5}();
    }

    class {2} : {1}
    {
        public override void {5}()
        {
            //...
        }
    }

    class {3} : {0}
    {
        string addedState = "Some State";

        public override void {5}()
        {
            base.{5}();
            //...
        }
    }

    class {4} : {0}
    {
        void {6}()
        {
            //...
        }

        public override void {5}()
        {
            base.{5}();
            {6}();
        }
    }
}
