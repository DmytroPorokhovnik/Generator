using System;

//Singleton - 0
//Instance - 0
namespace {0}
{{
    class {0}
    {{
        static {0} uniqueInstance;

        protected {0}()
        {{
        }}

        public static {0} {1}()
        {{
            if (uniqueInstance == null)
                uniqueInstance = new {0}();

            return uniqueInstance;
        }}        
    }}
}}
