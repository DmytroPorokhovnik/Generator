using System;

//ConcreteCommand - 0
//Invoker - 1
//Receiver - 2
//Action - 3
namespace PatternCommand
{{
    abstract class Command
    {{
        protected {2} receiver;

        public Command({2} receiver)
        {{
            this.receiver = receiver;
        }}

        public abstract void Execute();
    }}

    class {0} : Command
    {{
        public {0}({2} receiver)
            : base(receiver)
        {{
        }}

        public override void Execute()
        {{
            receiver.{3}();
        }}
    }}

    class {1}
    {{
        Command command;

        public void StoreCommand(Command command)
        {{
            this.command = command;
        }}

        public void ExecuteCommand()
        {{
            command.Execute();
        }}
    }}

    class {2}
    {{
        public void {3}()
        {{
           //...
        }}
    }}
}}
