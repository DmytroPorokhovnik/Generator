using System;
using System.ServiceModel;

//ISubject - 0
//RealSubject - 1
//Client - 2
//Server - 3
//Say - 4
namespace Ambassador
{{    
    [ServiceContract]
    interface {0}
    {{
        [OperationContract]
        void {4}(string input);
    }}

    class {1} : {0}
    {{
        public void {4}(string input)
        {{
            Console.WriteLine("Got: " + input);
        }}
    }}

    class {2}
    {{
        static void Run()
        {{
            Console.Title = "CLIENT";

            Uri address = new Uri("http://localhost:4000/{0}"); 
            BasicHttpBinding binding = new BasicHttpBinding();         
            EndpointAddress endpoint = new EndpointAddress(address);

            ChannelFactory<{0}> factory = new ChannelFactory<{0}>(binding, endpoint);  


            {0} channel = factory.CreateChannel();
 
            // Использование proxy для отправки сообщения предназначенного realsubject.
            channel.{4}("Hello !");

            // Задержка.
            Console.ReadKey();
        }}
    }}

    class {3}
    {{        
        static void Run()
        {{
            Console.Title = "SERVER";
          
            Uri address = new Uri("http://localhost:4000/{0}"); 
            BasicHttpBinding binding = new BasicHttpBinding(); 
            Type contract = typeof({0});           

            ServiceHost host = new ServiceHost(typeof({1}));
            host.AddServiceEndpoint(contract, binding, address);
            host.Open();

            Console.WriteLine("Ready");
            Console.ReadKey();

            host.Close();
        }}
    }}
}}


