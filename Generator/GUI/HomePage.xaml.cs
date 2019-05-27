using Generator.ExtensionDeb;
using Generator.Generation;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Generator.GUI
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {

        private static DependencyProperty FilePathProperty = DependencyProperty.Register("FilePath", typeof(string), typeof(HomePage));
        private static DependencyProperty FileNameProperty = DependencyProperty.Register("FileName", typeof(string), typeof(HomePage));
        private static DependencyProperty IsSomeFileOpenedProperty = DependencyProperty.Register("IsSomeFileOpened", typeof(bool), typeof(HomePage));
        private ObservableCollection<PatternViewModel> PatternsElements { get; set; }
        private readonly GOFPatternGenerator gofGenerator = new GOFPatternGenerator();
        private Patterns currentPattern = new Patterns();

        private async void Generate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                List<string> patternArguments = new List<string>();
                bool result;
                foreach (var patternelement in PatternsElements)
                {
                    patternArguments.Add(patternelement.MemberName);
                }
                if (GenerateToCurrentPositionCheckBox.IsChecked ?? false)
                    result = await gofGenerator.Generate(currentPattern, patternArguments);
                else
                    result = await gofGenerator.Generate(currentPattern, patternArguments, FilePath, FileName);
                if (!result)
                {

                }
            }
            catch (Exception ex)
            {
                await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync();
                VsShellUtilities.ShowMessageBox(
                  ServiceProvider.GlobalProvider,
                   "Something went wrong: " + ex.Message,
                   "Generate error",
                   OLEMSGICON.OLEMSGICON_INFO,
                   OLEMSGBUTTON.OLEMSGBUTTON_OK,
                   OLEMSGDEFBUTTON.OLEMSGDEFBUTTON_FIRST);
            }
        }



        private string GetActiveDocumentPath()
        {
            return ExtensionHelper.GetActiveDocumentPath();
        }


        public void InitializePatternEditor(Patterns pattern)
        {
            currentPattern = pattern;
            FileName = pattern.ToString() + ".cs";
            PatternsElements.Clear();
            switch (pattern)
            {
                #region Creational Patterns
                case Patterns.AbstractFactory:
                    PatternsElements.Add(new PatternViewModel("Abstract Factory Class Name", "AbstractFactory"));
                    PatternsElements.Add(new PatternViewModel("Abstract Product 1 Class Name", "AbstractProductA"));
                    PatternsElements.Add(new PatternViewModel("Abstract Product 2 Class Name", "AbstractProductB"));
                    PatternsElements.Add(new PatternViewModel("ProductA 1 Class Name", "ProductA1"));
                    PatternsElements.Add(new PatternViewModel("ProductA 2 Class Name", "ProductA2"));
                    PatternsElements.Add(new PatternViewModel("ProductB 1 Class Name", "ProductB1"));
                    PatternsElements.Add(new PatternViewModel("ProductB 2 Class Name", "ProductB2"));
                    PatternsElements.Add(new PatternViewModel("Concrete Factory Class Name", "ConcreteFactory1"));
                    PatternsElements.Add(new PatternViewModel("Concrete Factory Class Name", "ConcreteFactory2"));
                    PatternsElements.Add(new PatternViewModel("Client Class Name", "Client"));
                    PatternsElements.Add(new PatternViewModel("Run Method Name", "Run"));
                    PatternsElements.Add(new PatternViewModel("CreateProductA Method Name", "CreateProductA"));
                    PatternsElements.Add(new PatternViewModel("CreateProductB Method Name", "CreateProductB"));
                    PatternsElements.Add(new PatternViewModel("Interact Method Name", "Interact"));
                    break;
                case Patterns.Builder:
                    PatternsElements.Add(new PatternViewModel("Builder Class Name", "Builder"));
                    PatternsElements.Add(new PatternViewModel("Director Class Name", "Director"));
                    PatternsElements.Add(new PatternViewModel("ConcreteBuilder Class Name", "ConcreteBuilder"));
                    PatternsElements.Add(new PatternViewModel("Product Class Name", "Product"));
                    PatternsElements.Add(new PatternViewModel("GetResult Method Name", "GetResult"));
                    PatternsElements.Add(new PatternViewModel("BuildPartA Method Name", "BuildPartA"));
                    PatternsElements.Add(new PatternViewModel("BuildPartB Method Name", "BuildPartB"));
                    PatternsElements.Add(new PatternViewModel("BuildPartC Method Name", "BuildPartC"));
                    PatternsElements.Add(new PatternViewModel("Construct Method Name", "Construct"));
                    PatternsElements.Add(new PatternViewModel("Show Method Name", "Show"));
                    break;
                case Patterns.FactoryMethod:
                    PatternsElements.Add(new PatternViewModel("Creator Class Name", "Creator"));
                    PatternsElements.Add(new PatternViewModel("Product Class Name", "Product"));
                    PatternsElements.Add(new PatternViewModel("ConcreteCreator Class Name", "ConcreteCreator"));
                    PatternsElements.Add(new PatternViewModel("ConcreteProduct Class Name", "ConcreteProduct"));
                    PatternsElements.Add(new PatternViewModel("FactoryMethod Method Name", "FactoryMethod"));
                    PatternsElements.Add(new PatternViewModel("GetResult Method Name", "AnOperation"));
                    break;
                case Patterns.Prototype:
                    PatternsElements.Add(new PatternViewModel("Prototype Class Name", "Prototype"));
                    break;
                case Patterns.Singleton:
                    PatternsElements.Add(new PatternViewModel("Singleton Class Name", "Singleton"));
                    PatternsElements.Add(new PatternViewModel("Instance Property Name", "Instance"));
                    break;
                case Patterns.LazySingleton:
                    PatternsElements.Add(new PatternViewModel("Singleton Class Name", "LazySingleton"));
                    PatternsElements.Add(new PatternViewModel("Instance Property Name", "Instance"));
                    break;
                case Patterns.MultiThreadedSingleton:
                    PatternsElements.Add(new PatternViewModel("Singleton Class Name", "MultiThreadedSingleton"));
                    PatternsElements.Add(new PatternViewModel("Instance Property Name", "Instance"));
                    break;
                #endregion
                #region Structural Patterns               
                case Patterns.ObjectAdapter:
                    PatternsElements.Add(new PatternViewModel("Adapter Class Name", "Adapter"));
                    PatternsElements.Add(new PatternViewModel("Adaptee Class Name", "Adaptee"));
                    PatternsElements.Add(new PatternViewModel("ITarget Interface Name", "ITarget"));
                    PatternsElements.Add(new PatternViewModel("Request Method Name", "Request"));
                    PatternsElements.Add(new PatternViewModel("Request Method Name", "SpecificRequest"));
                    break;
                case Patterns.ClassAdapter:
                    PatternsElements.Add(new PatternViewModel("Adapter Class Name", "Adapter"));
                    PatternsElements.Add(new PatternViewModel("Adaptee Class Name", "Adaptee"));
                    PatternsElements.Add(new PatternViewModel("Target Class Name", "Target"));
                    PatternsElements.Add(new PatternViewModel("Request Method Name", "Request"));
                    PatternsElements.Add(new PatternViewModel("Request Method Name", "SpecificRequest"));
                    break;
                case Patterns.Bridge:
                    PatternsElements.Add(new PatternViewModel("Abstraction Class Name", "Abstraction"));
                    PatternsElements.Add(new PatternViewModel("Implementor Class Name", "Implementor"));
                    PatternsElements.Add(new PatternViewModel("RefinedAbstraction Class Name", "RefinedAbstraction"));
                    PatternsElements.Add(new PatternViewModel("ConcreteImplementor 1 Class Name", "ConcreteImplementorA"));
                    PatternsElements.Add(new PatternViewModel("ConcreteImplementor 2 Class Name", "ConcreteImplementorB"));
                    PatternsElements.Add(new PatternViewModel("Operation Method Name", "Operation"));
                    PatternsElements.Add(new PatternViewModel("OperationImp Method Name", "OperationImp"));
                    break;
                case Patterns.Composite:
                    PatternsElements.Add(new PatternViewModel("Composite Class Name", "Composite"));
                    PatternsElements.Add(new PatternViewModel("Component Class Name", "Component"));
                    PatternsElements.Add(new PatternViewModel("Leaf Class Name", "Leaf"));
                    PatternsElements.Add(new PatternViewModel("Operation Method Name", "Operation"));
                    PatternsElements.Add(new PatternViewModel("GetChild Method Name", "GetChild"));
                    break;
                case Patterns.Decorator:
                    PatternsElements.Add(new PatternViewModel("Decorator Class Name", "Decorator"));
                    PatternsElements.Add(new PatternViewModel("Component Class Name", "Component"));
                    PatternsElements.Add(new PatternViewModel("RefinedAbstraction Class Name", "ConcreteComponent"));
                    PatternsElements.Add(new PatternViewModel("ConcreteDecorator 1 Class Name", "ConcreteDecoratorA"));
                    PatternsElements.Add(new PatternViewModel("ConcreteDecorator 2 Class Name", "ConcreteDecoratorB"));
                    PatternsElements.Add(new PatternViewModel("Operation Method Name", "Operation"));
                    PatternsElements.Add(new PatternViewModel("AddedBehavior Property Name", "AddedBehavior"));
                    break;
                case Patterns.Facade:
                    PatternsElements.Add(new PatternViewModel("Facade Class Name", "Facade"));
                    PatternsElements.Add(new PatternViewModel("SubSystem 1 Class Name", "SubSystemA"));
                    PatternsElements.Add(new PatternViewModel("SubSystem 2 Class Name", "SubSystemB"));
                    PatternsElements.Add(new PatternViewModel("SubSystem 3 Class Name", "SubSystemC"));
                    PatternsElements.Add(new PatternViewModel("Operation 1 Method Name", "OperationA"));
                    PatternsElements.Add(new PatternViewModel("Operation 2 Method Name", "OperationB"));
                    PatternsElements.Add(new PatternViewModel("Operation 3 Method Name", "OperationC"));
                    PatternsElements.Add(new PatternViewModel("Operation 1-2 Method Name", "OperationAB"));
                    PatternsElements.Add(new PatternViewModel("Operation 2-3 Method Name", "OperationBC"));
                    break;
                case Patterns.Flyweight:
                    PatternsElements.Add(new PatternViewModel("Flyweight Class Name", "Flyweight"));
                    PatternsElements.Add(new PatternViewModel("ConcreteFlyweight Class Name", "ConcreteFlyweight"));
                    PatternsElements.Add(new PatternViewModel("UnsharedConcreteFlyweight Class Name", "UnsharedConcreteFlyweight"));
                    PatternsElements.Add(new PatternViewModel("FlyweightFactory Class Name", "FlyweightFactory"));
                    PatternsElements.Add(new PatternViewModel("Operation Method Name", "Operation"));
                    PatternsElements.Add(new PatternViewModel("GetConcreteFlyweight Method Name", "GetConcreteFlyweight"));
                    PatternsElements.Add(new PatternViewModel("GetUnsharedConcreteFlyweight Method Name", "GetUnsharedConcreteFlyweight"));
                    break;
                case Patterns.Proxy:
                    PatternsElements.Add(new PatternViewModel("Proxy Class Name", "Proxy"));
                    PatternsElements.Add(new PatternViewModel("RealSubject Class Name", "RealSubject"));
                    PatternsElements.Add(new PatternViewModel("Subject Class Name", "Subject"));
                    PatternsElements.Add(new PatternViewModel("Request Method Name", "Request"));
                    break;
                case Patterns.ProxyAmbassador:
                    PatternsElements.Add(new PatternViewModel("ISubject Class Name", "ISubject"));
                    PatternsElements.Add(new PatternViewModel("RealSubject Class Name", "RealSubject"));
                    PatternsElements.Add(new PatternViewModel("Client Class Name", "Client"));
                    PatternsElements.Add(new PatternViewModel("Server Class Name", "Server"));
                    PatternsElements.Add(new PatternViewModel("Say Method Name", "Say"));
                    break;
                case Patterns.ProxyCrud:
                    PatternsElements.Add(new PatternViewModel("Proxy Class Name", "Proxy"));
                    PatternsElements.Add(new PatternViewModel("RealSubject Class Name", "RealSubject"));
                    PatternsElements.Add(new PatternViewModel("Subject Class Name", "Subject"));
                    PatternsElements.Add(new PatternViewModel("Create Method Name", "Create"));
                    PatternsElements.Add(new PatternViewModel("Read Method Name", "Read"));
                    PatternsElements.Add(new PatternViewModel("Update Method Name", "Update"));
                    PatternsElements.Add(new PatternViewModel("Delete Method Name", "Delete"));
                    break;
                #endregion
                #region Behavioral Patterns    
                case Patterns.ChainOfResponsibility:
                    PatternsElements.Add(new PatternViewModel("Handler Class Name", "Handler"));
                    PatternsElements.Add(new PatternViewModel("ConcreteHandler1 Class Name", "ConcreteHandler1"));
                    PatternsElements.Add(new PatternViewModel("ConcreteHandler2 Class Name", "ConcreteHandler2"));
                    PatternsElements.Add(new PatternViewModel("HandleRequest Method Name", "HandleRequest"));
                    PatternsElements.Add(new PatternViewModel("Successor Property Name", "Successor"));
                    break;
                case Patterns.Command:
                    PatternsElements.Add(new PatternViewModel("ConcreteCommand Class Name", "ConcreteCommand"));
                    PatternsElements.Add(new PatternViewModel("Invoker Class Name", "Invoker"));
                    PatternsElements.Add(new PatternViewModel("Receiver Class Name", "Receiver"));
                    PatternsElements.Add(new PatternViewModel("Action Method Name", "Action"));
                    break;
                case Patterns.Interpreter:
                    PatternsElements.Add(new PatternViewModel("Context Class Name", "Context"));
                    PatternsElements.Add(new PatternViewModel("AbstractExpression Class Name", "AbstractExpression"));
                    PatternsElements.Add(new PatternViewModel("NonterminalExpression Class Name", "NonterminalExpression"));
                    PatternsElements.Add(new PatternViewModel("TerminalExpression Class Name", "TerminalExpression"));
                    PatternsElements.Add(new PatternViewModel("Interpret Method Name", "Interpret"));
                    PatternsElements.Add(new PatternViewModel("Source Property Name", "Source"));
                    PatternsElements.Add(new PatternViewModel("Vocabulary Property Name", "Vocabulary"));
                    PatternsElements.Add(new PatternViewModel("Result Property Name", "Result"));
                    PatternsElements.Add(new PatternViewModel("Position Property Name", "Position"));
                    break;
                case Patterns.Iterator:
                    PatternsElements.Add(new PatternViewModel("Iterator Class Name", "Iterator"));
                    PatternsElements.Add(new PatternViewModel("Aggregate Class Name", "Aggregate"));
                    PatternsElements.Add(new PatternViewModel("ConcreteIterator Class Name", "ConcreteIterator"));
                    PatternsElements.Add(new PatternViewModel("ConcreteAggregate Class Name", "ConcreteAggregate"));
                    PatternsElements.Add(new PatternViewModel("CreateIterator Method Name", "CreateIterator"));
                    PatternsElements.Add(new PatternViewModel("First Property Name", "First"));
                    PatternsElements.Add(new PatternViewModel("Next Property Name", "Next"));
                    PatternsElements.Add(new PatternViewModel("IsDone Property Name", "IsDone"));
                    PatternsElements.Add(new PatternViewModel("CurrentItem Property Name", "CurrentItem"));
                    break;
                case Patterns.IteratorNET:
                    PatternsElements.Add(new PatternViewModel("Iterator Class Name", "Enumerator"));
                    PatternsElements.Add(new PatternViewModel("Aggregate Class Name", "Enumerable"));
                    break;
                case Patterns.YieldIterator:
                    PatternsElements.Add(new PatternViewModel("Aggregate Class Name", "Enumerable"));
                    break;
                case Patterns.Mediator:
                    PatternsElements.Add(new PatternViewModel("Mediator Class Name", "Mediator"));
                    PatternsElements.Add(new PatternViewModel("Colleague Class Name", "Colleague"));
                    PatternsElements.Add(new PatternViewModel("ConcreteColleague 1 Class Name", "ConcreteColleague1"));
                    PatternsElements.Add(new PatternViewModel("ConcreteColleague 2 Class Name", "ConcreteColleague1"));
                    PatternsElements.Add(new PatternViewModel("ConcreteMediator Class Name", "ConcreteMediator"));
                    PatternsElements.Add(new PatternViewModel("Send Method Name", "Send"));
                    PatternsElements.Add(new PatternViewModel("Notify Method Name", "Notify"));
                    break;
                case Patterns.Memento:
                    PatternsElements.Add(new PatternViewModel("Memento Class Name", "Memento"));
                    PatternsElements.Add(new PatternViewModel("Caretaker Class Name", "Caretaker"));
                    PatternsElements.Add(new PatternViewModel("Originator Class Name", "Originator"));
                    PatternsElements.Add(new PatternViewModel("SetMemento Method Name", "SetMemento"));
                    PatternsElements.Add(new PatternViewModel("CreateMemento Method Name", "CreateMemento"));
                    PatternsElements.Add(new PatternViewModel("State Property Name", "State"));
                    break;
                case Patterns.Observer:
                    PatternsElements.Add(new PatternViewModel("Observer Class Name", "Observer"));
                    PatternsElements.Add(new PatternViewModel("Subject Class Name", "Subject"));
                    PatternsElements.Add(new PatternViewModel("ConcreteSubject Class Name", "ConcreteSubject"));
                    PatternsElements.Add(new PatternViewModel("ConcreteObserver Class Name", "ConcreteObserver"));
                    PatternsElements.Add(new PatternViewModel("Update Method Name", "Update"));
                    PatternsElements.Add(new PatternViewModel("Attach Method Name", "Attach"));
                    PatternsElements.Add(new PatternViewModel("Detach Method Name", "Detach"));
                    PatternsElements.Add(new PatternViewModel("Notify Method Name", "Notify"));
                    break;
                case Patterns.ObserverEvent:
                    PatternsElements.Add(new PatternViewModel("Observer Class Name", "Observer"));
                    PatternsElements.Add(new PatternViewModel("Subject Class Name", "Subject"));
                    PatternsElements.Add(new PatternViewModel("ConcreteSubject Class Name", "ConcreteSubject"));
                    PatternsElements.Add(new PatternViewModel("Notify Method Name", "Notify"));
                    PatternsElements.Add(new PatternViewModel("State Property Name", "State"));
                    PatternsElements.Add(new PatternViewModel("Event Property Name", "Event"));
                    break;
                case Patterns.ObserverNET:
                    PatternsElements.Add(new PatternViewModel("Observer Class Name", "ConcreteObserver"));
                    PatternsElements.Add(new PatternViewModel("ConcreteSubject Class Name", "ConcreteSubject"));
                    PatternsElements.Add(new PatternViewModel("Unsubscriber Class Name", "Unsubscriber"));
                    PatternsElements.Add(new PatternViewModel("Notify Method Name", "Notify"));
                    PatternsElements.Add(new PatternViewModel("State Property Name", "State"));
                    break;
                case Patterns.State:
                    PatternsElements.Add(new PatternViewModel("State Class Name", "State"));
                    PatternsElements.Add(new PatternViewModel("Context Class Name", "Context"));
                    PatternsElements.Add(new PatternViewModel("ConcreteState 1 Class Name", "ConcreteStateA"));
                    PatternsElements.Add(new PatternViewModel("ConcreteState 2 Class Name", "ConcreteStateB"));
                    PatternsElements.Add(new PatternViewModel("Handle Method Name", "Handle"));
                    PatternsElements.Add(new PatternViewModel("Request Method Name", "Request"));
                    break;
                case Patterns.Strategy:
                    PatternsElements.Add(new PatternViewModel("Strategy Class Name", "Strategy"));
                    PatternsElements.Add(new PatternViewModel("ConcreteStrategy 1 Class Name", "ConcreteStrategyA"));
                    PatternsElements.Add(new PatternViewModel("ConcreteStrategy 2 Class Name", "ConcreteStrategyB"));
                    PatternsElements.Add(new PatternViewModel("ConcreteStrategy 3 Class Name", "ConcreteStrategyC"));
                    PatternsElements.Add(new PatternViewModel("Context Class Name", "Context"));
                    PatternsElements.Add(new PatternViewModel("AlgorithmInterface Method Name", "AlgorithmInterface"));
                    PatternsElements.Add(new PatternViewModel("ContextInterface Method Name", "ContextInterface"));
                    break;
                case Patterns.TemplateMethod:
                    PatternsElements.Add(new PatternViewModel("AbstractClass Class Name", "AbstractClass"));
                    PatternsElements.Add(new PatternViewModel("ConcreteClass Class Name", "ConcreteClass"));
                    PatternsElements.Add(new PatternViewModel("TemplateMethod Method Name", "TemplateMethod"));
                    PatternsElements.Add(new PatternViewModel("PrimitiveOperation 1 Method Name", "PrimitiveOperation1"));
                    PatternsElements.Add(new PatternViewModel("PrimitiveOperation 2 Method Name", "PrimitiveOperation2"));
                    break;
                case Patterns.Visitor:
                    PatternsElements.Add(new PatternViewModel("Visitor Class Name", "Visitor"));
                    PatternsElements.Add(new PatternViewModel("Element Class Name", "Element"));
                    PatternsElements.Add(new PatternViewModel("ObjectStructure Class Name", "ObjectStructure"));
                    PatternsElements.Add(new PatternViewModel("ConcreteElement 1 Class Name", "ConcreteElementA"));
                    PatternsElements.Add(new PatternViewModel("ConcreteElement 2 Class Name", "ConcreteElementB"));
                    PatternsElements.Add(new PatternViewModel("ConcreteVisitor 1 Class Name", "ConcreteVisitor1"));
                    PatternsElements.Add(new PatternViewModel("ConcreteVisitor 2 Class Name", "ConcreteVisitor2"));
                    PatternsElements.Add(new PatternViewModel("VisitConcreteElementA Method Name", "VisitConcreteElementA"));
                    PatternsElements.Add(new PatternViewModel("VisitConcreteElementB Method Name", "VisitConcreteElementB"));
                    PatternsElements.Add(new PatternViewModel("Accept Method Name", "Accept"));
                    PatternsElements.Add(new PatternViewModel("OperationA Method Name", "OperationA"));
                    PatternsElements.Add(new PatternViewModel("OperationB Method Name", "OperationB"));
                    break;
                    #endregion
            }
        }

        public string FileName
        {
            get { return (string)this.GetValue(FileNameProperty); }
            set
            {
                this.SetValue(FileNameProperty, value);
            }
        }
        public bool IsSomeFileOpened
        {
            get { return (bool)this.GetValue(IsSomeFileOpenedProperty); }
            set
            {
                this.SetValue(IsSomeFileOpenedProperty, value);
            }
        }

        public string FilePath
        {
            get { return (string)this.GetValue(FilePathProperty); }
            set
            {
                this.SetValue(FilePathProperty, value);
                if (string.IsNullOrEmpty(value))
                {
                    filePathTextBox.BorderThickness = new Thickness(0);
                    filePathTextBox.Text = "There is no open project";
                }
                else
                    filePathTextBox.BorderThickness = new Thickness(1);
            }
        }

        public HomePage()
        {
            InitializeComponent();
            PatternsElements = new ObservableCollection<PatternViewModel>();
            elementsList.ItemsSource = PatternsElements;
            FilePath = ExtensionHelper.GetCurrentProjectPath();
            IsSomeFileOpened = !string.IsNullOrEmpty(ExtensionHelper.GetActiveDocumentPath());
        }
    }
}
