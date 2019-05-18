using System;

//Abstraction - 0
//Implementor - 1
//RefinedAbstraction - 2
//ConcreteImplementorA - 3
//ConcreteImplementorB - 4
//Operation - 5
//OperationImp - 6
namespace Bridge
{
    abstract class {0}
    {
        protected {1} implementor = null;

        public {0}({1} implementor)
        {
            this.implementor = implementor;
        }

        public virtual void {5}()
        {
            implementor.{6}();
        }
    }

    abstract class {1}
    {
        public abstract void {6}();
    }

    class {2} : {0}
    {
        public {2}({1} implementor)
            : base(implementor)
        {
        }

        public override void {5}()
        {
            // ...
            base.{5}();
            // ...
        }
    }

    class {3} : {1}
    {
        public override void {6}()
        {
            //...
        }
    }

    class {4} : {1}
    {
        public override void {6}()
        {
            //...
        }
    }
}
