using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator.Generation
{
    class GOFPatternGenerator
    {
        private static string ResourceFolder = Directory.GetCurrentDirectory();

        // creational Patterns
        public string AbstractFactory(string abstractFactoryClass, string abstractProductAClass, string abstractProductBClass, string productA1Class, 
            string productA2, string ProductB1, string ProductB2, string ConcreteFactory1, string ConcreteFactory2, string client, 
            string runMethod, string CreateProductA, string CreateProductB, string interact)
        {
            var template = GetPatternTemplate("AbstractFactory.cs");
            return string.Format(template, abstractFactoryClass, abstractProductAClass, abstractProductBClass, productA1Class, productA2, ProductB1, ProductB2,
                ConcreteFactory1, ConcreteFactory2, client, runMethod, CreateProductA, CreateProductB, interact);
        }

        public string Builder(string builder, string director, string concreteBuilder, string Product, string GetResult,
            string BuildPartA, string buildPartB, string BuildPartC, string consrtuct, string show)
        {
            var template = GetPatternTemplate("Builder.cs");
            return string.Format(template, builder, director, concreteBuilder, Product, GetResult, BuildPartA, buildPartB, BuildPartC, consrtuct, show);
        }

        public string FactoryMethod(string factoryMethod, string creator, string product, string concreteCreator, string concreteProduct, string anOperation)
        {
            var template = GetPatternTemplate("FactoryMethod.cs");
            return string.Format(template, factoryMethod, creator, product, concreteCreator, concreteProduct, anOperation);
        }

        public string Prototype(string prototype)
        {
            var template = GetPatternTemplate("Prototype.cs");
            return string.Format(template, prototype);
        }

        public string Singleton(string singleton, string instance)
        {
            var template = GetPatternTemplate("Singleton.cs");
            return string.Format(template, singleton, instance);
        }

        public string MultiThreadedSingleton(string singleton, string instance)
        {
            var template = GetPatternTemplate("MultiThreadedSingleton.cs");
            return string.Format(template, singleton, instance);
        }

        public string LazySingleton(string singleton, string instance)
        {
            var template = GetPatternTemplate("LazySingleton.cs");
            return string.Format(template, singleton, instance);
        }

        private string GetPatternTemplate(string fileName)
        {
          return File.ReadAllText(ResourceFolder + "//" + fileName);           
        }
    }
}
