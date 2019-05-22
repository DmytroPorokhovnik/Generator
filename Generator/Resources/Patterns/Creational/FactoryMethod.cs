using System;

//FactoryMethod - 0
//Creator - 1
//Product - 2
//ConcreteCreator - 3
//ConcreteProduct - 4
//AnOperation - 5
namespace {0}
{{   
    abstract class {1}
    {{
        {2} product;

        public abstract {2} {0}();

        public void {5}()
        {{
            product = {0}();
        }}
    }}

    abstract class {2}
    {{
    }}

    class {3} : {1}
    {{
        public override {2} {0}()
        {{
            return new {4}();
        }}
    }}

     class {4} : {2}
    {{
        public {4}()
        {{
           //
        }}
    }}
}}
