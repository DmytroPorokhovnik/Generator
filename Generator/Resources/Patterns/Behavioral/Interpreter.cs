using System;

//Context - 0
//AbstractExpression - 1
//NonterminalExpression - 2
//TerminalExpression - 3
//Interpret - 4
//Source - 5
//Vocabulary - 6
//Result - 7
//Position - 8
namespace Interpreter
{{
    class {0}
    {{
        public string {5} {{ get; set; }}
        public char {6} {{ get; set; }}
        public bool {7} {{ get; set; }}
        public int {8} {{ get; set; }}
    }}

    abstract class {1}
    {{
        public abstract void {4}({0} context);
    }}

    class {2} : {1}
    {{
        {1} nonterminalExpression;
        {1} terminalExpression;

        public override void {4}({0} context)
        {{
            if (context.{8} < context.{5}.Length)
            {{
                terminalExpression = new {3}();
                terminalExpression.{4}(context);
                context.{8}++;

                if (context.{7})
                {{
                    nonterminalExpression = new {2}();
                    nonterminalExpression.{4}(context);
                }}
            }}
        }}
    }}

    class {3} : {1}
    {{
        public override void {4}({0} context)
        {{
            context.{7} = context.{5}[context.{8}] == context.{6};
        }}
    }}
}}
