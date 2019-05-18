using System;

//Proxy - 0
//RealSubject - 1
//Subject - 2
//Request - 3
namespace {0}
{
    class {0} : {2}
    {
        {1} realSubject;

        public override void {3}()
        {
            if (realSubject == null)
                realSubject = new {1}();

            realSubject.{3}();
        }
    }

    abstract class {2}
    {
        public abstract void {3}();
    }

    class {1} : {2}
    {
        public override void {3}()
        {
            //...
        }
    }
}
