using System;
using System.Collections.Generic;

//ConcreteObserver - 0
//ConcreteSubject - 1
//Unsubscriber - 2
//Notify - 3
//State - 4
// - 5
// - 6
namespace Observer
{
    class {0} : IObserver<string>
    {
        string name;
        string observerState;
        IDisposable unsubscriber;

        public {0}(string name, IObservable<string> subject)
        {
            this.name = name;
            unsubscriber = subject.Subscribe(this);
        }        

        public void OnCompleted()
        {
            unsubscriber.Dispose();
        }

        public void OnError(Exception error)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Observer {0}, Error: {1}", name, error.Message);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        
        public void OnNext(string value)
        {
            observerState = value;
            Console.WriteLine("Observer {0}, {4} = {1}", name, observerState);
        }
    }

     class {1} : IObservable<string>, IDisposable
    {
        public string {4} { get; set; }

        List<IObserver<string>> observers = new List<IObserver<string>>();

        public void {3}()
        {
            foreach (IObserver<string> observer in observers)
            {
                if (this.{4} == null)
                    observer.OnError(new NullReferenceException());
                else
                    observer.OnNext(this.{4});
            }
        }
        
        public IDisposable Subscribe(IObserver<string> observer)
        {
            if (!observers.Contains(observer))
                observers.Add(observer);

            return new {2}(observers, observer);
        }

        public void Dispose()
        {
            observers.Clear();
        }

        // Nested Class
        class {2} : IDisposable
        {
            List<IObserver<string>> observers;
            IObserver<string> observer;

            public {2}(List<IObserver<string>> observers, IObserver<string> observer)
            {
                this.observers = observers;
                this.observer = observer;
            }

            public void Dispose()
            {
                if (observers.Contains(observer))
                    observers.Remove(observer);
                else
                    observer.OnError(new Exception("...."));
            }
        }
    }
}
