using System;


//Adapter - 0
//Target - 1
//Adaptee - 2
//Request - 3
//SpecificRequest - 4
namespace {0}
{{
    abstract class {1}
    {{
        public abstract void {3}();
    }}

    class {0} : {1}
    {{
        {2} adaptee = new {2}();

        public override void {3}()
        {{
            adaptee.{4}();
        }}
    }}

    class {2}
    {{
        public void {4}()
        {{
            // ...
        }}
    }}
}}
