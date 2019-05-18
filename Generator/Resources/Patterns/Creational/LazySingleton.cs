using System;

//Singleton - 0
//Instance - 1
namespace {0}
{
    class {0}
    {
        static Lazy<{0}> instance = new Lazy<{0}>();

        public static {0} {1}
        {
            get
            {
                return instance.Value;
            }
        }
    }
}
