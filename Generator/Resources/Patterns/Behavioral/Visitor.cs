using System;

//Visitor - 0
//Element - 1
//ObjectStructure - 2
//ConcreteElementA - 3
//ConcreteElementB - 4
//ConcreteVisitor1 - 5
//ConcreteVisitor2 - 6
//VisitConcreteElementA - 7
//VisitConcreteElementB - 8
//Accept - 9
//OperationA - 10
//OperationB - 11
namespace {0}
{{
    abstract class {0}
    {{
        public abstract void {7}({3} elementA);
        public abstract void {8}({4} elementB);
    }}

    abstract class {1}
    {{
        public abstract void {9}({0} visitor);
    }}

    class {2}
    {{
        ArrayList elements = new ArrayList();

        public void Add({1} element)
        {{
            elements.Add(element);
        }}

        public void Remove({1} element)
        {{
            elements.Remove(element);
        }}

        public void {9}({0} visitor)
        {{
            foreach ({1} element in elements)
                element.{9}(visitor);
        }}
    }}

    class {3} : {1}
    {{
        public override void {9}({0} visitor)
        {{
            visitor.{7}(this);
        }}

        public void {10}()
        {{
            //...
        }}
    }}

    class {4} : {1}
    {{
        public override void {9}({0} visitor)
        {{
            visitor.{8}(this);
        }}

        public void {11}()
        {{
            //...
        }}
    }}

    class {5} : {0}
    {{
        public override void {7}({3} elementA)
        {{
            elementA.{10}();
        }}

        public override void {8}({4} elementB)
        {{
            elementB.{11}();
        }}
    }}

    class {6} : {0}
    {{
        public override void {7}({3} elementA)
        {{
            elementA.{10}();
        }}

        public override void {8}({4} elementB)
        {{
            elementB.{11}();
        }}
    }}
}}
