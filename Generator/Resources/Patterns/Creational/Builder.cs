using System;

//{Builder} - {0}
//{Director} - 1
//{ConcreteBuilder} - 2
//{Product} - 3
//{GetResult} -4
//{BuildPartA} -5
//{BuildPartB} -6
//{BuildPartC} -7
//{Construct} -8
//{Show} -9
namespace {0}
{
    abstract class {0}
    {
        public abstract void {5}();
        public abstract void {6}();
        public abstract void {7}();
        public abstract {3} {4}();
    }

    class {1}
    {
        {0} builder;

        public {1}({0} builder)
        {
            this.builder = builder;
        }

        public void {8}()
        {
            builder.{5}();
            builder.{6}();
            builder.{7}();
        }
    }

    class {2} : {0}
    {
        {3} product = new {3}();

        public override void {5}()
        {
            product.Add("Part A");
        }

        public override void {6}()
        {
            product.Add("Part B");
        }

        public override void {7}()
        {
            product.Add("Part C");
        }

        public override {3} {4}()
        {
            return product;
        }
    }

    class {3}
    {
        ArrayList parts = new ArrayList();

        public void Add(string part)
        {
            parts.Add(part);
        }

        public void {9}()
        {
            foreach (string part in parts)
                Console.WriteLine(part);
        }
    }
}
