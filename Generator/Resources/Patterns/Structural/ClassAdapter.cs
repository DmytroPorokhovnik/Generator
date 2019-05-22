using System;

//Adapter - 0
//ITarget - 1
//Adaptee - 2
//Request - 3
//SpecificRequest - 4
namespace {0}
{{
    class {0} : {2}, {1}
    {{
        public void {3}()
        {{
            base.{4}();
        }}
    }}

    interface {1}
    {{
        void {3}();
    }}

    class {2}
    {{
        public void {4}()
        {{
           //...
        }}
    }}
}}
