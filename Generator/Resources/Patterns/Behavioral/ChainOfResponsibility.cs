using System;

//Handler - 0
//ConcreteHandler1 - 1
//ConcreteHandler2 - 2
//HandleRequest - 3
//Successor - 4
namespace Chain
{
    abstract class {0}
    {
        public {0} {4} { get; set; }
        public abstract void {3}(int request);
    }

    class {1} : {0}
    {
        public override void {3}(int request)
        {
            if (request == 2)
            {
                //...
            }
            else if ({4} != null)
                {4}.{3}(request);
        }
    }

    class {2} : {0}
    {
        public override void {3}(int request)
        {
            if (request == 1)
            {  
                //...
            }
            else if ({4} != null)
                {4}.{3}(request);
        }
    }
}
