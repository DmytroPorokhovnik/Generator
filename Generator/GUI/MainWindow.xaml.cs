using Generator.Generation;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using Microsoft.VisualStudio.Shell;

namespace Generator
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Window
    {

        private GOFPatternGenerator gofGenerator = new GOFPatternGenerator();
        public HomePage()
        {
            InitializeComponent();
        }


        #region Private Methods  

        private void CreationalPatternsToggleButton_Click(object sender, RoutedEventArgs e)
        {
            if(sender is ToggleButton button)
            {
                if((bool) button.IsChecked)
                    this.CreationalPatternsList.Visibility = Visibility.Visible;
                else
                    this.CreationalPatternsList.Visibility = Visibility.Collapsed;
            }

            var singleton = gofGenerator.Singleton("Singleton", "Instance");
            var multisingleton = gofGenerator.MultiThreadedSingleton("Singleton", "Instance");
            var lazy = gofGenerator.LazySingleton("Singleton", "Instance");
            var builder = gofGenerator.Builder("Builder", "Director", "ConcreteBuilder", "Product", "GetResult", "BuildPartA", "BuildPartB", "BuildPartC",
               "Construct", "Show");
            var prototype = gofGenerator.Prototype("Prototype");
            var abstractFactory = gofGenerator.AbstractFactory("AbstractFactory", "AbstraxtProductA", "AbstraxtProductB", "Product", "GetResult", "BuildPartA", "BuildPartB", "BuildPartC",
                "Construct", "Show", "run", "CreateProductA", "CreateProductB", "Interact");
            var factoryMethod = gofGenerator.FactoryMethod("FactoryMethod", "Crator", "Product", "ConcreteCreator", "CocreteProduct", "AnOperation");
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
            var button = sender as Button;
            switch(button.Content)
            {
                case "Abstract factory":
                    break;
            }
        }

        #endregion       
    }
}
