using System;
using System.Collections.Generic;

//Observer - 0
//Subject - 1
//ConcreteSubject - 2
//Notify - 3
//State - 4
//Event - 5
namespace {0}
{{
    delegate void {0}(string state);  

    abstract class {1}
    {{
        protected {0} observers = null;

        public event {0} {5}
        {{
            add {{ observers += value; }}
            remove {{ observers -= value; }}
        }}

        public abstract string {4} {{ get; set; }}
        public abstract void {3}();
    }}  

    class {2} : {1}
    {{
        public override string {4} {{ get; set; }}

        public override void {3}()
        {{
            observers.Invoke({4});
        }}
    }}
}}
