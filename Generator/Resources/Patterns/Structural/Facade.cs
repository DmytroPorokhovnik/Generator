using System;

//Facade - 0
//SubSystemA - 1
//SubSystemB - 2
//SubSystemC - 3
//OperationA - 4
//OperationB - 5
//OperationC - 6
//OperationAB - 7
//OperationBC - 8
namespace {0}
{{
    class {0}
    {{
        {1} subSystemA = new {1}();
        {2} subSystemB = new {2}();
        {3} subSystemC = new {3}();

        public void {7}()
        {{
            subSystemA.{4}();
            subSystemB.{5}();
        }}

        public void {8}()
        {{
            subSystemB.{5}();
            subSystemC.{6}();
        }}
    }}

    class {1}
    {{
        public void {4}()
        {{
            //...
        }}
    }}

    class {2}
    {{
        public void {5}()
        {{
            //...
        }}
    }}

    class {3}
    {{
        public void {6}()
        {{
            //...
        }}
    }}
}}
