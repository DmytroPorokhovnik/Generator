using System;

//Memento - 0
//Caretaker - 1
//Originator - 2
//SetMemento - 3
//CreateMemento - 4
//State - 5
namespace {0}
{{
    class {0}
    {{
        public string {5} {{ get; private set; }}

        public {0}(string state)
        {{
            this.{5} = state;
        }}
    }}

    class {1}
    {{
        public {0} {0} {{ get; set; }}
    }}

    class {2}
    {{
        public string {5} {{ get; set; }}

        public void {3}({0} memento)
        {{
            {5} = memento.{5};
        }}

        public {0} {4}()
        {{
            return new {0}({5});
        }}
    }}
}}
