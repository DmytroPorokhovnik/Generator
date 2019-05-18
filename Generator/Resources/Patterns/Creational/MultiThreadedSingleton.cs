using System.Threading;

//Singleton - 0
//Instance - 1
namespace {0}
{
    class {0}
    {
        private static volatile {0} instance;
        private static Mutex mutex = new Mutex();

        private {0}() { }

        public static {0} {1}
        {
            get
            {
                Thread.Sleep(500);

                if (instance == null)
                {
                    mutex.WaitOne();

                    if (instance == null)
                        instance = new {0}();

                    mutex.ReleaseMutex();
                }

                return instance;
            }
        }
    }
}
