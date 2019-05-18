using System;

//Flyweight - 0
//ConcreteFlyweight - 1
//UnsharedConcreteFlyweight - 2
//FlyweightFactory - 3
//Operation - 4
//GetConcreteFlyweight - 5
//GetUnsharedConcreteFlyweight - 6
namespace {0}
{
    abstract class {0}
    {
        public abstract void {4}(ConsoleColor extrinsicState);
    }

    class {1} : {0}
    {
        string intrinsicState = "{1} ";
        ConsoleColor extrinsicState;

        public override void {4}(ConsoleColor extrinsicState)
        {
            this.extrinsicState = extrinsicState;
            Console.ForegroundColor = this.extrinsicState;
            //....
        }
    }

    class {2} : {0}
    {
        string allState = "{2} ";

        public override void {4}(ConsoleColor extrinsicState)
        {
            Console.ForegroundColor = extrinsicState;
           //...
        }
    }

    class {3}
    {
        Hashtable pool = new Hashtable();

        public {0} {5}(string key)
        {
            if (!pool.ContainsKey(key))
                pool.Add(key, new {1}());

            return pool[key] as {0};
        }

        public {0} {6}()
        {
            return new {2}();
        }
    }
}
