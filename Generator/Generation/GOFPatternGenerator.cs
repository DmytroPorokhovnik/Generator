using EnvDTE;
using Generator.ExtensionDeb;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

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
            var template = Properties.Resources.AbstactFactory;
            template = DeleteComments(template);
            return string.Format(template, abstractFactoryClass, abstractProductAClass, abstractProductBClass, productA1Class, productA2, ProductB1, ProductB2,
                ConcreteFactory1, ConcreteFactory2, client, runMethod, CreateProductA, CreateProductB, interact);
        }

        public string Builder(string builder, string director, string concreteBuilder, string Product, string GetResult,
            string BuildPartA, string buildPartB, string BuildPartC, string consrtuct, string show)
        {
            var template = Properties.Resources.Builder;
            template = DeleteComments(template);
            return string.Format(template, builder, director, concreteBuilder, Product, GetResult, BuildPartA, buildPartB, BuildPartC, consrtuct, show);
        }

        public string FactoryMethod(string factoryMethod, string creator, string product, string concreteCreator, string concreteProduct, string anOperation)
        {
            var template = Properties.Resources.FactoryMethod;
            template = DeleteComments(template);
            return string.Format(template, factoryMethod, creator, product, concreteCreator, concreteProduct, anOperation);
        }

        public string Prototype(string prototype)
        {
            var template = Properties.Resources.Prototype;
            template = DeleteComments(template);
            return string.Format(template, prototype);
        }

        public string Singleton(string singleton, string instance)
        {
            var template = Properties.Resources.Singleton;
            template = DeleteComments(template);
            return string.Format(template, singleton, instance);
        }

        public string MultiThreadedSingleton(string singleton, string instance)
        {
            var template = Properties.Resources.MultiThreadedSingleton;
            template = DeleteComments(template);
            return string.Format(template, singleton, instance);
        }

        public string LazySingleton(string singleton, string instance)
        {
            var template = Properties.Resources.LazySingleton;
            template = DeleteComments(template);
            return string.Format(template, singleton, instance);
        }

        public string ObjectAdapter(string adapter, string target, string adaptee, string request, string specificRequest)
        {
            var template = Properties.Resources.ObjectAdapter;
            template = DeleteComments(template);
            return string.Format(template, adapter, target, adaptee, request, specificRequest);
        }

        public string ClassAdapter(string adapter, string iTarget, string adaptee, string request, string specificRequest)
        {
            var template = Properties.Resources.ClassAdapter;
            template = DeleteComments(template);
            return string.Format(template, adapter, iTarget, adaptee, request, specificRequest);
        }

        public string Bridge(string abstraction, string implementor, string refinedAbstraction, string concreteImplementorA,
            string concreteImplementorB, string operation, string operationImp)
        {
            var template = Properties.Resources.Bridge;
            template = DeleteComments(template);
            return string.Format(template, abstraction, implementor, refinedAbstraction, concreteImplementorA,
                concreteImplementorB, operation, operationImp);
        }

        public string Proxy(string proxy, string realSubject, string subject, string request)
        {
            var template = Properties.Resources.Proxy;
            template = DeleteComments(template);
            return string.Format(template, proxy, realSubject, subject, request);
        }

        public string ProxyCrud(string proxy, string subject, string realSubject, string create, string read, string update, string delete)
        {
            var template = Properties.Resources.ProxyCRUD;
            template = DeleteComments(template);
            return string.Format(template, proxy, subject, realSubject, create, read, update, delete);
        }

        public string ProxyAmbassador(string iSubject, string realSubject, string client, string server, string say)
        {
            var template = Properties.Resources.ProxyAmbassador;
            template = DeleteComments(template);
            return string.Format(template, iSubject, realSubject, client, server, say);
        }

        public string Flyweight(string flyweight, string concreteFlyweight, string unsharedConcreteFlyweight, string flyweightFactory,
            string operation, string getConcreteFlyweight, string getUnsharedConcreteFlyweight)
        {
            var template = Properties.Resources.Flyweight;
            template = DeleteComments(template);
            return string.Format(template, flyweight, concreteFlyweight, unsharedConcreteFlyweight, flyweightFactory,
                operation, getConcreteFlyweight, getUnsharedConcreteFlyweight);
        }

        public string Facade(string facade, string subSystemA, string subSystemB, string subSystemC,
            string operationA, string operationB, string operationC, string operationAB, string operationBC)
        {
            var template = Properties.Resources.Facade;
            template = DeleteComments(template);
            return string.Format(template, facade, subSystemA, subSystemB, subSystemC,
                operationA, operationB, operationC, operationAB, operationBC);
        }

        public string Decorator(string decorator, string component, string concreteComponent, string concreteDecoratorA,
            string concreteDecoratorB, string operation, string addedBehavior)
        {
            var template = Properties.Resources.Decorator;
            template = DeleteComments(template);
            return string.Format(template, decorator, component, concreteComponent, concreteDecoratorA,
                concreteDecoratorB, operation, addedBehavior);
        }

        public string Composite(string composite, string component, string leaf, string operation,
            string getChild)
        {
            var template = Properties.Resources.Composite;
            template = DeleteComments(template);
            return string.Format(template, composite, component, leaf, operation,
                getChild);
        }

        public string ChainOfResponsibility(string handler, string concreteHandler1, string concreteHandler2, string handleRequest,
            string successor)
        {
            var template = Properties.Resources.ChainOfResponsibility;
            template = DeleteComments(template);
            return string.Format(template, handler, concreteHandler1, concreteHandler2, handleRequest,
                successor);
        }

        public string IteratorNET(string enumerator, string enumerable)
        {
            var template = Properties.Resources.IteratorNET;
            template = DeleteComments(template);
            return string.Format(template, enumerator, enumerable);
        }

        public string YieldIterator(string enumerable)
        {
            var template = Properties.Resources.YieldIterator;
            template = DeleteComments(template);
            return string.Format(template, enumerable);
        }

        public string Iterator(string iterator, string aggregate, string conctreteIterator, string concreteAggregate,
            string createIterator, string first, string next, string isDone, string currentItem)
        {
            var template = Properties.Resources.Iterator;
            template = DeleteComments(template);
            return string.Format(template, iterator, aggregate, conctreteIterator, concreteAggregate, createIterator, first, next, isDone, currentItem);
        }

        public string Command(string concreteCommand, string invoker, string receiver, string action)
        {
            var template = Properties.Resources.Command;
            template = DeleteComments(template);
            return string.Format(template, concreteCommand, invoker, receiver, action);
        }

        public string Interpreter(string context, string abstractExpression, string nonterminalExpression, string terminalExpression, string interpret,
            string source, string vocabulary, string result, string position)
        {
            var template = Properties.Resources.Interpreter;
            template = DeleteComments(template);
            return string.Format(template, context, abstractExpression, nonterminalExpression, terminalExpression, interpret, source, vocabulary, result, position);
        }

        public string Mediator(string mediator, string colleague, string concreteColleague1, string concreteColleague2, string concreteMediator,
            string send, string notify)
        {
            var template = Properties.Resources.Mediator;
            template = DeleteComments(template);
            return string.Format(template, mediator, colleague, concreteColleague1, concreteColleague2, concreteMediator, send, notify);
        }

        public string Memento(string memento, string caretaker, string originator, string setMemento, string createMemento,
           string state)
        {
            var template = Properties.Resources.Memento;
            template = DeleteComments(template);
            return string.Format(template, memento, caretaker, originator, setMemento, createMemento, state);
        }

        public string Observer(string observer, string subject, string concreteSubject, string concreteObserver, string update,
         string attach, string detach, string notify)
        {
            var template = Properties.Resources.Observer;
            template = DeleteComments(template);
            return string.Format(template, observer, subject, concreteSubject, concreteObserver, update, attach, detach, notify);
        }

        public string ObserverNET(string concreteObserver, string concreteSubject, string unsubscriber, string notify, string state)
        {
            var template = Properties.Resources.ObserverNET;
            template = DeleteComments(template);
            return string.Format(template, concreteObserver, concreteSubject, unsubscriber, notify);
        }

        public string ObserverEvent(string observer, string subject, string concreteSubject, string notify, string state, string eventName)
        {
            var template = Properties.Resources.ObserverEvent;
            template = DeleteComments(template);
            return string.Format(template, observer, subject, concreteSubject, notify, state, eventName);
        }

        public string State(string state, string context, string concreteStateA, string concreteStateB, string handle, string request)
        {
            var template = Properties.Resources.State;
            template = DeleteComments(template);
            return string.Format(template, state, context, concreteStateA, concreteStateB, handle, request);
        }

        public string Strategy(string strategy, string concreteStrategyA, string concreteStrategyB, string concreteStrategyC, string context, 
            string algorithmInterface, string contextInterface)
        {
            var template = Properties.Resources.Strategy;
            template = DeleteComments(template);
            return string.Format(template, strategy, concreteStrategyA, concreteStrategyB, concreteStrategyC, context, algorithmInterface, contextInterface);
        }

        public string TemplateMethod(string abstractClass, string concreteClass, string primitiveOperation1, string primitiveOperation2, string templateMethod)
        {
            var template = Properties.Resources.TemplateMethod;
            template = DeleteComments(template);
            return string.Format(template, abstractClass, concreteClass, primitiveOperation1, primitiveOperation2, templateMethod);
        }

        public string Visitor(string visitor, string element, string objectStructure, string concreteElementA, string concreteElementB,
            string concreteVisitor1, string concreteVisitor2, string visitConcreteElementA, string visitConcreteElementB, string accept,
            string operationA, string operationB)
        {
            var template = Properties.Resources.Visitor;
            template = DeleteComments(template);
            return string.Format(template, visitor, element, objectStructure, concreteElementA, concreteElementB, concreteVisitor1,
                concreteVisitor2, visitConcreteElementA, visitConcreteElementB, accept, operationA, operationB);
        }

        public async void GeneratePattern(string pattern, string fileName, string path = "")
        {           
            if (string.IsNullOrEmpty(path))
                path = getCurrentProjectPath();
            if(string.IsNullOrEmpty(path))
            {
                await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync();
                VsShellUtilities.ShowMessageBox(
                  ServiceProvider.GlobalProvider,
                   "Path is empty",
                   "Generate error",
                   OLEMSGICON.OLEMSGICON_INFO,
                   OLEMSGBUTTON.OLEMSGBUTTON_OK,
                   OLEMSGDEFBUTTON.OLEMSGDEFBUTTON_FIRST);
                return;
            }          
            using (FileStream fs = File.Create(Path.Combine(path, fileName)))
            {
                var patternBytes = Encoding.ASCII.GetBytes(pattern);
                fs.Write(patternBytes, 0, patternBytes.Length);
            }
        }

        public string getCurrentProjectPath()
        {
            ThreadHelper.ThrowIfNotOnUIThread();
            var proj = ExtensionHelper.GetActiveProject(Package.GetGlobalService(typeof(SDTE)) as DTE);
            if (proj == null)
            {
                //TODO:
                return null;
            }
            else
            {
                var currentProject = (VSLangProj.VSProject)proj.Object;
                return Path.GetDirectoryName(currentProject.Project.FileName);

            }
        }

        private string DeleteComments(string pattern)
        {
            pattern = Regex.Replace(pattern, "^//.*$", "", RegexOptions.Multiline);
            pattern = pattern.Substring(0, pattern.IndexOf("namespace")).Trim() + "\n\n" + pattern.Substring(pattern.IndexOf("namespace"));
            return pattern;
        }        
    }
}
