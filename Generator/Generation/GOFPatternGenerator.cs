using EnvDTE;
using Generator.ExtensionDeb;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Generator.Generation
{
    class GOFPatternGenerator
    {
        #region Public Methods
        #region Creational Patterns
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
        #endregion

        #region Structural Patterns
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

        #endregion

        #region Behavioral Patterns

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

        #endregion

        public async Task<bool> Generate(Patterns pattern, List<string> patternArguments, string filePath, string fileName)
        {
            if (!await CheckFileNameAndPathAsync(fileName, filePath))
                return false;

            var generatedPattern = GetPattern(pattern, patternArguments);

            if (string.IsNullOrEmpty(generatedPattern))
                return false;

            return GeneratePattern(generatedPattern, fileName, filePath);
        }

        public async Task<bool> Generate(Patterns pattern, List<string> patternArguments)
        {
            var activeDocumentPath = ExtensionHelper.GetActiveDocumentPath();
            var caretPosition = ExtensionHelper.GetCaretLine();
            var generatedPattern = GetPattern(pattern, patternArguments);
            if (string.IsNullOrEmpty(generatedPattern))
                return false;

            GeneratePattern(generatedPattern, activeDocumentPath, caretPosition);
            return true;
        }

        public string GetCurrentProjectPath()
        {
            return ExtensionHelper.GetCurrentProjectPath();
        }

        #endregion

        private string GetPattern(Patterns pattern, List<string> patternArguments)
        {
            string generatedPattern = "";
            switch (pattern)
            {
                case Patterns.AbstractFactory:
                    if (patternArguments.Count == 14)
                        generatedPattern = AbstractFactory(patternArguments[0], patternArguments[1], patternArguments[2], patternArguments[3],
                            patternArguments[4], patternArguments[5], patternArguments[6], patternArguments[7], patternArguments[8],
                            patternArguments[9], patternArguments[10], patternArguments[11], patternArguments[12], patternArguments[13]);
                    else
                        return generatedPattern;
                    break;
                case Patterns.Builder:
                    if (patternArguments.Count == 10)
                        generatedPattern = Builder(patternArguments[0], patternArguments[1], patternArguments[2], patternArguments[3],
                            patternArguments[4], patternArguments[5], patternArguments[6], patternArguments[7], patternArguments[8],
                            patternArguments[9]);
                    else
                        return generatedPattern;
                    break;
                case Patterns.FactoryMethod:
                    if (patternArguments.Count == 6)
                        generatedPattern = FactoryMethod(patternArguments[0], patternArguments[1], patternArguments[2], patternArguments[3],
                            patternArguments[4], patternArguments[5]);
                    else
                        return generatedPattern;
                    break;
                case Patterns.Prototype:
                    if (patternArguments.Count == 1)
                        generatedPattern = Prototype(patternArguments[0]);
                    else
                        return generatedPattern;
                    break;
                case Patterns.Singleton:
                    if (patternArguments.Count == 2)
                        generatedPattern = Singleton(patternArguments[0], patternArguments[1]);
                    else
                        return generatedPattern;
                    break;
                case Patterns.MultiThreadedSingleton:
                    if (patternArguments.Count == 2)
                        generatedPattern = MultiThreadedSingleton(patternArguments[0], patternArguments[1]);
                    else
                        return generatedPattern;
                    break;
                case Patterns.LazySingleton:
                    if (patternArguments.Count == 2)
                        generatedPattern = LazySingleton(patternArguments[0], patternArguments[1]);
                    else
                        return generatedPattern;
                    break;

                case Patterns.ObjectAdapter:
                    if (patternArguments.Count == 5)
                        generatedPattern = ObjectAdapter(patternArguments[0], patternArguments[1], patternArguments[2], patternArguments[3],
                            patternArguments[4]);
                    else
                        return generatedPattern;
                    break;
                case Patterns.ClassAdapter:
                    if (patternArguments.Count == 5)
                        generatedPattern = ClassAdapter(patternArguments[0], patternArguments[1], patternArguments[2], patternArguments[3],
                            patternArguments[4]);
                    else
                        return generatedPattern;
                    break;
                case Patterns.Decorator:
                    if (patternArguments.Count == 7)
                        generatedPattern = Decorator(patternArguments[0], patternArguments[1], patternArguments[2], patternArguments[3],
                            patternArguments[4], patternArguments[5], patternArguments[6]);
                    else
                        return generatedPattern;
                    break;
                case Patterns.Facade:
                    if (patternArguments.Count == 9)
                        generatedPattern = Facade(patternArguments[0], patternArguments[1], patternArguments[2], patternArguments[3],
                            patternArguments[4], patternArguments[5], patternArguments[6], patternArguments[7], patternArguments[8]);
                    else
                        return generatedPattern;
                    break;
                case Patterns.Flyweight:
                    if (patternArguments.Count == 7)
                        generatedPattern = Flyweight(patternArguments[0], patternArguments[1], patternArguments[2], patternArguments[3],
                            patternArguments[4], patternArguments[5], patternArguments[6]);
                    else
                        return generatedPattern;
                    break;
                case Patterns.Proxy:
                    if (patternArguments.Count == 4)
                        generatedPattern = Proxy(patternArguments[0], patternArguments[1], patternArguments[2], patternArguments[3]);
                    else
                        return generatedPattern;
                    break;
                case Patterns.ProxyAmbassador:
                    if (patternArguments.Count == 5)
                        generatedPattern = ProxyAmbassador(patternArguments[0], patternArguments[1], patternArguments[2], patternArguments[3],
                            patternArguments[4]);
                    else
                        return generatedPattern;
                    break;
                case Patterns.ProxyCrud:
                    if (patternArguments.Count == 7)
                        generatedPattern = ProxyCrud(patternArguments[0], patternArguments[1], patternArguments[2], patternArguments[3],
                            patternArguments[4], patternArguments[5], patternArguments[6]);
                    else
                        return generatedPattern;
                    break;

                case Patterns.ChainOfResponsibility:
                    if (patternArguments.Count == 5)
                        generatedPattern = ChainOfResponsibility(patternArguments[0], patternArguments[1], patternArguments[2], patternArguments[3],
                            patternArguments[4]);
                    else
                        return generatedPattern;
                    break;
                case Patterns.Iterator:
                    if (patternArguments.Count == 9)
                        generatedPattern = Iterator(patternArguments[0], patternArguments[1], patternArguments[2], patternArguments[3],
                            patternArguments[4], patternArguments[5], patternArguments[6], patternArguments[7], patternArguments[8]);
                    else
                        return generatedPattern;
                    break;
                case Patterns.IteratorNET:
                    if (patternArguments.Count == 2)
                        generatedPattern = IteratorNET(patternArguments[0], patternArguments[1]);
                    else
                        return generatedPattern;
                    break;
                case Patterns.YieldIterator:
                    if (patternArguments.Count == 1)
                        generatedPattern = YieldIterator(patternArguments[0]);
                    else
                        return generatedPattern;
                    break;
                case Patterns.Command:
                    if (patternArguments.Count == 4)
                        generatedPattern = Command(patternArguments[0], patternArguments[1], patternArguments[2], patternArguments[3]);
                    else
                        return generatedPattern;
                    break;
                case Patterns.Mediator:
                    if (patternArguments.Count == 7)
                        generatedPattern = Mediator(patternArguments[0], patternArguments[1], patternArguments[2], patternArguments[3],
                            patternArguments[4], patternArguments[5], patternArguments[6]);
                    else
                        return generatedPattern;
                    break;
                case Patterns.Memento:
                    if (patternArguments.Count == 6)
                        generatedPattern = Memento(patternArguments[0], patternArguments[1], patternArguments[2], patternArguments[3],
                            patternArguments[4], patternArguments[5]);
                    else
                        return generatedPattern;
                    break;
                case Patterns.Observer:
                    if (patternArguments.Count == 8)
                        generatedPattern = Observer(patternArguments[0], patternArguments[1], patternArguments[2], patternArguments[3],
                            patternArguments[4], patternArguments[5], patternArguments[6], patternArguments[7]);
                    else
                        return generatedPattern;
                    break;
                case Patterns.ObserverEvent:
                    if (patternArguments.Count == 6)
                        generatedPattern = ObserverEvent(patternArguments[0], patternArguments[1], patternArguments[2], patternArguments[3],
                            patternArguments[4], patternArguments[5]);
                    else
                        return generatedPattern;
                    break;
                case Patterns.ObserverNET:
                    if (patternArguments.Count == 5)
                        generatedPattern = ObserverNET(patternArguments[0], patternArguments[1], patternArguments[2], patternArguments[3],
                            patternArguments[4]);
                    else
                        return generatedPattern;
                    break;
                case Patterns.State:
                    if (patternArguments.Count == 6)
                        generatedPattern = State(patternArguments[0], patternArguments[1], patternArguments[2], patternArguments[3],
                            patternArguments[4], patternArguments[5]);
                    else
                        return generatedPattern;
                    break;
                case Patterns.Strategy:
                    if (patternArguments.Count == 7)
                        generatedPattern = Strategy(patternArguments[0], patternArguments[1], patternArguments[2], patternArguments[3],
                            patternArguments[4], patternArguments[5], patternArguments[6]);
                    else
                        return generatedPattern;
                    break;
                case Patterns.Visitor:
                    if (patternArguments.Count == 12)
                        generatedPattern = Visitor(patternArguments[0], patternArguments[1], patternArguments[2], patternArguments[3],
                            patternArguments[4], patternArguments[5], patternArguments[6], patternArguments[7], patternArguments[8],
                            patternArguments[9], patternArguments[10], patternArguments[11]);
                    else
                        return generatedPattern;
                    break;
                case Patterns.TemplateMethod:
                    if (patternArguments.Count == 5)
                        generatedPattern = TemplateMethod(patternArguments[0], patternArguments[1], patternArguments[2], patternArguments[3],
                            patternArguments[4]);
                    else
                        return generatedPattern;
                    break;
            }
            return generatedPattern;
        }

        private string DeleteComments(string pattern)
        {
            pattern = Regex.Replace(pattern, "^//.*$", "", RegexOptions.Multiline);
            pattern = pattern.Substring(0, pattern.IndexOf("namespace")).Trim() + "\n\n" + pattern.Substring(pattern.IndexOf("namespace"));
            return pattern;
        }

        private bool GeneratePattern(string pattern, string fileName, string path)
        {
            using (FileStream fs = File.Create(Path.Combine(path, fileName)))
            {
                var patternBytes = Encoding.ASCII.GetBytes(pattern);
                fs.Write(patternBytes, 0, patternBytes.Length);
            }
            return true;
        }

        private bool GeneratePattern(string pattern, string filePath, int currentLine)
        {            
           
            string line = "";
            int counter = 1;
            StringBuilder resultText = new StringBuilder();
            using (StreamReader file = new StreamReader(filePath))
            {
                while ((line = file.ReadLine()) != null)
                {
                    if (currentLine != counter)
                    {
                        resultText.AppendLine(line);
                    }
                    else if (currentLine == counter)
                    {
                        resultText.Append(MakePatternForExistedFile(pattern));
                        resultText.AppendLine();
                        resultText.AppendLine(line);
                    }
                    counter++;
                }
            }
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.Write(resultText.ToString());
            }
                return true;
        }

        private string MakePatternForExistedFile(string pattern)
        {
            var startIndex = pattern.IndexOf("{");
            var endIndex = pattern.LastIndexOf("}");
            return pattern.Substring(startIndex + 1, endIndex - startIndex - 1);
        }

        private async Task<bool> CheckFileNameAndPathAsync(string fileName, string path)
        {
            if (string.IsNullOrEmpty(path))
                path = GetCurrentProjectPath();
            if (string.IsNullOrEmpty(path))
            {
                await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync();
                VsShellUtilities.ShowMessageBox(
                  ServiceProvider.GlobalProvider,
                   "Path is empty",
                   "Generate error",
                   OLEMSGICON.OLEMSGICON_INFO,
                   OLEMSGBUTTON.OLEMSGBUTTON_OK,
                   OLEMSGDEFBUTTON.OLEMSGDEFBUTTON_FIRST);
                return false;
            }

            if (string.IsNullOrEmpty(fileName) || fileName.Contains(" "))
            {
                await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync();
                VsShellUtilities.ShowMessageBox(
                  ServiceProvider.GlobalProvider,
                   "Incorrect file name",
                   "Generate error",
                   OLEMSGICON.OLEMSGICON_INFO,
                   OLEMSGBUTTON.OLEMSGBUTTON_OK,
                   OLEMSGDEFBUTTON.OLEMSGDEFBUTTON_FIRST);
                return false;
            }
            return true;
        }
    }
}
