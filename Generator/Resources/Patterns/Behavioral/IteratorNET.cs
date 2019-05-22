using System.Collections;

//Enumerator - 0
//Enumerable - 1
namespace {0}
{{
    class {1} : IEnumerable
    {{
        private ArrayList items = new ArrayList();
        public object this[int index]
        {{
            get {{ return items[index]; }}
            set {{ items.Insert(index, value); }}
        }}
        public int Count
        {{
            get {{ return items.Count; }}
        }}
    
        public IEnumerator GetEnumerator()
        {{
            return new {0}(this);
        }}
    }}

    class {0} : IEnumerator
    {{
        private {1} enumerable;
        private int current = -1;
        public {0}({1} enumerable)
        {{
            this.enumerable = enumerable;
        }}
        
        public bool MoveNext()
        {{
            if(current < enumerable.Count - 1)
            {{
                current++;
                return true;
            }}
            return false;
        }}
        public void Reset()
        {{
            current = -1;
        }}
        public object Current
        {{
            get {{ return enumerable[current]; }}
        }}
    }}
}}