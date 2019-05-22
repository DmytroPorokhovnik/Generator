using System;

//State - 0
//Context - 1
//ConcreteStateA - 2
//ConcreteStateB - 3
//Handle - 4
//Request - 5
namespace {0}
{{
    abstract class {0}
    {{
        public abstract void {4}({1} context);
    }}

    class {1}
    {{
        public {0} {0} {{ get; set; }}

        public {1}({0} state)
        {{
            this.{0} = state;
        }}

        public void {5}()
        {{
            this.{0}.{4}(this);
        }}
    }}

    class {2} : {0}
    {{
        public override void {4}({1} context)
        {{
            context.{0} = new {3}();
        }}
    }}

    class {3} : {0}
    {{
        public override void {4}({1} context)
        {{
            context.{0} = new {2}();
        }}
    }}
}}
