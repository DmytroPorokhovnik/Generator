using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindowVS : Window
    {

        //private GOFPatternGenerator gofGenerator = new GOFPatternGenerator();
        public MainWindowVS()
        {
            InitializeComponent();
            //CurrentPattern = Patterns.AbstractFactory;
        }

        //public Patterns CurrentPattern { get; set; }


        #region Private Methods  
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreationalPatternsToggleButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is ToggleButton button)
            {
                if ((bool)button.IsChecked)
                    this.CreationalPatternsList.Visibility = Visibility.Visible;
                else
                    this.CreationalPatternsList.Visibility = Visibility.Collapsed;
            }

            //var singleton = gofgenerator.singleton("singleton", "instance");
            //var multisingleton = gofgenerator.multithreadedsingleton("singleton", "instance");
            //var lazy = gofgenerator.lazysingleton("singleton", "instance");
            //var builder = gofgenerator.builder("builder", "director", "concretebuilder", "product", "getresult", "buildparta", "buildpartb", "buildpartc",
            //   "construct", "show");
            //var prototype = gofgenerator.prototype("prototype");
            //var abstractfactory = gofgenerator.abstractfactory("abstractfactory", "abstraxtproducta", "abstraxtproductb", "product", "getresult", "buildparta", "buildpartb", "buildpartc",
            //    "construct", "show", "run", "createproducta", "createproductb", "interact");
            //var factorymethod = gofgenerator.factorymethod("factorymethod", "creator", "product", "concretecreator", "concreteproduct", "anoperation");
            //await gofgenerator.generatepatternasync(factorymethod, "factoryethod.cs");
        }

        private void BehavioralPatternsToggleButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is ToggleButton button)
            {
                if ((bool)button.IsChecked)
                    this.BehavioralPatternsList.Visibility = Visibility.Visible;
                else
                    this.BehavioralPatternsList.Visibility = Visibility.Collapsed;
            }
        }

        private void StructuralPatternsToggleButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is ToggleButton button)
            {
                if ((bool)button.IsChecked)
                    this.StructuralPatternsList.Visibility = Visibility.Visible;
                else
                    this.StructuralPatternsList.Visibility = Visibility.Collapsed;
            }
        }

        private void PatternChosed_Click(object sender, RoutedEventArgs e)
        {
            //var button = sender as Button;
            //switch (button.Content)
            //{
            //    #region Creational
            //    case "Abstract factory":
            //        CurrentPattern = Patterns.AbstractFactory;
            //        (p_home.Content as HomePage).InitializePatternEditor(CurrentPattern);
            //        break;
            //    case "Builder":
            //        CurrentPattern = Patterns.Builder;
            //        (p_home.Content as HomePage).InitializePatternEditor(CurrentPattern);
            //        break;
            //    case "Factory method":
            //        CurrentPattern = Patterns.FactoryMethod;
            //        (p_home.Content as HomePage).InitializePatternEditor(CurrentPattern);
            //        break;
            //    case "Prototype":
            //        CurrentPattern = Patterns.Prototype;
            //        (p_home.Content as HomePage).InitializePatternEditor(CurrentPattern);
            //        break;
            //    case "Singleton":
            //        CurrentPattern = Patterns.Singleton;
            //        (p_home.Content as HomePage).InitializePatternEditor(CurrentPattern);
            //        break;
            //    case "Lazy Singleton":
            //        CurrentPattern = Patterns.LazySingleton;
            //        (p_home.Content as HomePage).InitializePatternEditor(CurrentPattern);
            //        break;
            //    case "Multithreaded Singleton":
            //        CurrentPattern = Patterns.MultiThreadedSingleton;
            //        (p_home.Content as HomePage).InitializePatternEditor(CurrentPattern);
            //        break;
            //    #endregion
            //    #region Structural
            //    case "Class Adapter":
            //        CurrentPattern = Patterns.ClassAdapter;
            //        (p_home.Content as HomePage).InitializePatternEditor(CurrentPattern);
            //        break;
            //    case "Object Adapter":
            //        CurrentPattern = Patterns.ObjectAdapter;
            //        (p_home.Content as HomePage).InitializePatternEditor(CurrentPattern);
            //        break;
            //    case "Bridge":
            //        CurrentPattern = Patterns.Bridge;
            //        (p_home.Content as HomePage).InitializePatternEditor(CurrentPattern);
            //        break;
            //    case "Composite":
            //        CurrentPattern = Patterns.Composite;
            //        (p_home.Content as HomePage).InitializePatternEditor(CurrentPattern);
            //        break;
            //    case "Decorator":
            //        CurrentPattern = Patterns.Decorator;
            //        (p_home.Content as HomePage).InitializePatternEditor(CurrentPattern);
            //        break;
            //    case "Facade":
            //        CurrentPattern = Patterns.Facade;
            //        (p_home.Content as HomePage).InitializePatternEditor(CurrentPattern);
            //        break;
            //    case "Flyweight":
            //        CurrentPattern = Patterns.Flyweight;
            //        (p_home.Content as HomePage).InitializePatternEditor(CurrentPattern);
            //        break;
            //    case "Proxy":
            //        CurrentPattern = Patterns.Proxy;
            //        (p_home.Content as HomePage).InitializePatternEditor(CurrentPattern);
            //        break;
            //    case "Proxy CRUD":
            //        CurrentPattern = Patterns.ProxyCrud;
            //        (p_home.Content as HomePage).InitializePatternEditor(CurrentPattern);
            //        break;
            //    case "Proxy Ambassador":
            //        CurrentPattern = Patterns.ProxyAmbassador;
            //        (p_home.Content as HomePage).InitializePatternEditor(CurrentPattern);
            //        break;
            //    #endregion
            //    #region Behavioral
            //    case "Chain of responsibility":
            //        CurrentPattern = Patterns.ChainOfResponsibility;
            //        (p_home.Content as HomePage).InitializePatternEditor(CurrentPattern);
            //        break;
            //    case "Command":
            //        CurrentPattern = Patterns.Command;
            //        (p_home.Content as HomePage).InitializePatternEditor(CurrentPattern);
            //        break;
            //    case "Iterator":
            //        CurrentPattern = Patterns.Iterator;
            //        (p_home.Content as HomePage).InitializePatternEditor(CurrentPattern);
            //        break;
            //    case ".Net Iterator":
            //        CurrentPattern = Patterns.IteratorNET;
            //        (p_home.Content as HomePage).InitializePatternEditor(CurrentPattern);
            //        break;
            //    case "Yield Iterator":
            //        CurrentPattern = Patterns.YieldIterator;
            //        (p_home.Content as HomePage).InitializePatternEditor(CurrentPattern);
            //        break;
            //    case "Mediator":
            //        CurrentPattern = Patterns.Mediator;
            //        (p_home.Content as HomePage).InitializePatternEditor(CurrentPattern);
            //        break;
            //    case "Memento":
            //        CurrentPattern = Patterns.Memento;
            //        (p_home.Content as HomePage).InitializePatternEditor(CurrentPattern);
            //        break;
            //    case "Observer":
            //        CurrentPattern = Patterns.Observer;
            //        (p_home.Content as HomePage).InitializePatternEditor(CurrentPattern);
            //        break;
            //    case "Observer Event":
            //        CurrentPattern = Patterns.ObserverEvent;
            //        (p_home.Content as HomePage).InitializePatternEditor(CurrentPattern);
            //        break;
            //    case "Observer(.NET interfaces)":
            //        CurrentPattern = Patterns.ObserverNET;
            //        (p_home.Content as HomePage).InitializePatternEditor(CurrentPattern);
            //        break;
            //    case "State":
            //        CurrentPattern = Patterns.State;
            //        (p_home.Content as HomePage).InitializePatternEditor(CurrentPattern);
            //        break;
            //    case "Strategy":
            //        CurrentPattern = Patterns.Strategy;
            //        (p_home.Content as HomePage).InitializePatternEditor(CurrentPattern);
            //        break;
            //    case "Template method":
            //        CurrentPattern = Patterns.TemplateMethod;
            //        (p_home.Content as HomePage).InitializePatternEditor(CurrentPattern);
            //        break;
            //    case "Visitor":
            //        CurrentPattern = Patterns.Visitor;
            //        (p_home.Content as HomePage).InitializePatternEditor(CurrentPattern);
            //        break;
            //        #endregion


            //}

            p_home.Visibility = Visibility.Visible;
        }

        #endregion       
    }
}
