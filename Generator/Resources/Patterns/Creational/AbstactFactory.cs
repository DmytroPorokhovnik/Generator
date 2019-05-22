using System;

// AbstractFactory - 0
//{AbstractProductA} - 1
//{AbstractProductB} - 2
//{ProductA1} - 3
//{ProductA2} - 4
//{ProductB1} - 5
//{ProductB2} - 6
//{ConcreteFactory1} - 7
//{ConcreteFactory2} - 8
//{Client} - 9
//{Run} - 10
//{CreateProductA} -11
//{CreateProductB} - 12
//{Interact} - 13
namespace {0}
{{
    abstract class {0}
    {{
        public abstract {1} {11}();
        public abstract {2} {12}();
    }}

    abstract class {1}
    {{
    }}

    abstract class {2}
    {{
        public abstract void {13}({1} a);
    }}

    class {3} : {1}
    {{
    }}

    class {4} : {1}
    {{
    }}

    class {5} : {2}
    {{
        public override void {13}({1} apa)
        {{
            Console.WriteLine(this + " interacts with " + apa);
        }}
    }}

    class {6} : {2}
    {{
        public override void {13}({1} apa)
        {{
            Console.WriteLine(this + " interacts with " + apa);
        }}
    }}

    class {7} : {0}
    {{
        public override {1} {11}()
        {{
            return new {3}();
        }}

        public override {2} {12}()
        {{
            return new {5}();
        }}
    }}

    class {8} : {0}
    {{
        public override {1} {11}()
        {{
            return new {4}();
        }}

        public override {2} {12}()
        {{
            return new {6}();
        }}
    }}

    class {9}
    {{
        private {1} abstractProductA = null;
        private {2} abstractProductB = null;

        public {9}({0} factory)
        {{
            this.abstractProductA = factory.{11}();
            this.abstractProductB = factory.{12}();
        }}

        public void {10}()
        {{
            this.abstractProductB.{13}(this.abstractProductA);
        }}
    }}
}}
