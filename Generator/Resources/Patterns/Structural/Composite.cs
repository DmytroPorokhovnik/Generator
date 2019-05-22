using System;
using System.Collections;

//Composite - 0
//Component - 1
//Leaf - 2
//Operation - 3
//GetChild - 4
namespace {0}
{{
    abstract class {1}
    {{
        protected string name;

        public {1}(string name)
        {{
            this.name = name;
        }}

        public abstract void {3}();
        public abstract void Add({1} component);
        public abstract void Remove({1} component);
        public abstract {1} {4}(int index);
    }}

    class {0} : {1}
    {{
        ArrayList nodes = new ArrayList();

        public {0}(string name)
            : base(name)
        {{
        }}

        public override void {3}()
        {{
            //...

            foreach ({1} component in nodes)
                component.{3}();
        }}

        public override void Add({1} component)
        {{
            nodes.Add(component);
        }}

        public override void Remove({1} component)
        {{
            nodes.Remove(component);
        }}

        public override {1} {4}(int index)
        {{
            return nodes[index] as {1};
        }}
    }}

    class {2} : {1}
    {{
        public {2}(string name)
            : base(name)
        {{
        }}

        public override void {3}()
        {{
            //...
        }}

        public override void Add({1} component)
        {{
            throw new InvalidOperationException();
        }}

        public override void Remove({1} component)
        {{
            throw new InvalidOperationException();
        }}

        public override {1} {4}(int index)
        {{
            throw new InvalidOperationException();
        }}
    }}
}}
