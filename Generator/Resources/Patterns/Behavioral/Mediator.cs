using System;

//Mediator - 0
//Colleague - 1
//ConcreteColleague1 - 2
//ConcreteColleague2 - 3
//ConcreteMediator - 4
//Send - 5
//Notify - 6
namespace {0}
{
    abstract class {0}
    {
        public abstract void {5}(string message, {1} colleague);
    }

    abstract class {1}
    {
        protected {0} mediator;

        public {1}({0} mediator)
        {
            this.mediator = mediator;
        }
    }

    class {2} : {1}
    {
        public {2}({0} mediator)
            : base(mediator)
        {
        }

        public void {5}(string message)
        {
            mediator.{5}(message, this);
        }

        public void {6}(string message)
        {
            //...
        }
    }

    class {3} : {1}
    {
        public {3}({0} mediator)
            : base(mediator)
        {
        }

        public void {5}(string message)
        {
            mediator.{5}(message, this);
        }

        public void {6}(string message)
        {
            //...
        }
    }

    class {4} : {0}
    {
        public {2} Colleague1 { get; set; }
        public {3} Colleague2 { get; set; }

        public override void {5}(string message, {1} colleague)
        {
            if (Colleague1 == colleague)
                Colleague2.{6}(message);
            else
                Colleague1.{6}(message);
        }
    }
}
