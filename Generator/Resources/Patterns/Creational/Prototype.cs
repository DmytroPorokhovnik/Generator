using System;

//Prototype - 0
namespace {0}
{{
   class {0} : ICloneable
    {{        
        public string State {{ get; set; }}

        public {0} Clone()
        {{
            return this.MemberwiseClone() as {0};
        }}
    }}
}}
