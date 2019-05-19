using System;

//Iterator - 0
//Aggregate - 1
//ConcreteIterator - 2
//ConcreteAggregate - 3
//CreateIterator - 4
//First - 5
//Next - 6
//IsDone - 7
//CurrentItem - 8
namespace {0}
{
    abstract class {0}
    {
        public abstract object {5}();
        public abstract object {6}();
        public abstract bool {7}();
        public abstract object {8}();
    }

    abstract class {1}
    {
        public abstract {0} {4}();
        public abstract int Count { get; }
        public abstract object this[int index] { get; set; }
    }

    class {2} : {0}
    {
        private {1} aggregate;
        private int current = 0;

        public {2}({1} aggregate)
        {
            this.aggregate = aggregate;
        }

        public override object {5}()
        {
            return aggregate[0];
        }

        public override object {6}()
        {
            if (current++ < aggregate.Count - 1)
                return aggregate[current];
            else
                return null;
        }

        public override object {8}()
        {
            return aggregate[current];
        }

        public override bool {7}()
        {
            if (current < aggregate.Count)
                return false;

            current = 0;
            return true;
        }
    }

    class {3} : {1}
    {
        private ArrayList items = new ArrayList();

        public override {0} {4}()
        {
            return new {2}(this);
        }

        public override int Count
        {
            get { return items.Count; }
        }

        public override object this[int index]
        {
            get { return items[index]; }
            set { items.Insert(index, value); }
        }
    }
}