using System;
using System.Collections;

//Observer - 0
//Subject - 1
//ConcreteSubject - 2
//ConcreteObserver - 3
//Update - 4
//Attach - 5
//Detach - 6
//Notify - 7
namespace {0}
{
    abstract class {0}
    {
        public abstract void {4}();
    }

    abstract class {1}
    {
        ArrayList observers = new ArrayList();

        public void {5}({0} observer)
        {
            observers.Add(observer);
        }

        public void {6}({0} observer)
        {
            observers.Remove(observer);
        }

        public void {7}()
        {
            foreach ({0} observer in observers)
                observer.{4}();
        }
    }

    class {2} : {1}
    {
        public string State { get; set; }
    }

    class {3} : {0}
    {
        string observerState;
        {2} subject;

        public {3}({2} subject)
        {
            this.subject = subject;
        }

        public override void {4}()
        {
            observerState = subject.State;
        }
    }
}
