using System;

//AbstractClass - 0
//ConcreteClass - 1
//PrimitiveOperation1 - 2
//PrimitiveOperation2 - 3
//TemplateMethod - 4
namespace Template
{
    abstract class {0}
    {
        public abstract void {2}();
        public abstract void {3}();

        public void {4}()
        {
            {2}();
            {3}();
        }
    }

    class {1} : {0}
    {
        public override void {2}()
        {
            //...
        }

        public override void {3}()
        {
            //...
        }
    }
}
