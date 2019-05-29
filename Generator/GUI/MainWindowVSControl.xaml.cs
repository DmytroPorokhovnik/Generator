namespace Generator
{
    using Generator.ExtensionDeb;
    using Generator.Generation;
    using Generator.GUI;
    using MaterialDesignColors;
    using MaterialDesignThemes.Wpf;
    using System.Collections.ObjectModel;
    using System.Diagnostics.CodeAnalysis;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Controls.Primitives;
    using System.Windows.Media;

    /// <summary>
    /// Interaction logic for MainWindowVSControl.
    /// </summary>
    public partial class MainWindowVSControl : UserControl
    {
        public Patterns CurrentPattern { get; set; }
        private static DependencyProperty FilePathProperty = DependencyProperty.Register("FilePath", typeof(string), typeof(MainWindowVSControl));
        private static DependencyProperty FileNameProperty = DependencyProperty.Register("FileName", typeof(string), typeof(MainWindowVSControl));
        private static DependencyProperty IsSomeFileOpenedProperty = DependencyProperty.Register("IsSomeFileOpened", typeof(bool), typeof(MainWindowVSControl));
        private ObservableCollection<PatternViewModel> PatternsElements { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindowVSControl"/> class.
        /// </summary>
        public MainWindowVSControl()
        {
            var card = new Card();
            var hue = new Hue("Dummy", Colors.Black, Colors.White);

            this.InitializeComponent();

            PatternsElements = new ObservableCollection<PatternViewModel>();
            //elementsList.ItemsSource = PatternsElements;
            FilePath = ExtensionHelper.GetCurrentProjectPath();
            IsSomeFileOpened = !string.IsNullOrEmpty(ExtensionHelper.GetActiveDocumentPath());
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
                    filePathTextBox.Text = "There is no open project";
                }                
            }
        }

        #region Private Methods  
        /// <summary>
        /// Handles click on the button by displaying a message box.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event args.</param>
        [SuppressMessage("Microsoft.Globalization", "CA1300:SpecifyMessageBoxOptions", Justification = "Sample code")]
        [SuppressMessage("StyleCop.CSharp.NamingRules", "SA1300:ElementMustBeginWithUpperCaseLetter", Justification = "Default event handler naming pattern")]
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
                string.Format(System.Globalization.CultureInfo.CurrentUICulture, "Invoked '{0}'", this.ToString()),
                "MainWindowVS");
        }

        private void CreationalPatternsToggleButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is ToggleButton button)
            {
                if ((bool)button.IsChecked)
                    this.CreationalPatternsList.Visibility = Visibility.Visible;
                else
                    this.CreationalPatternsList.Visibility = Visibility.Collapsed;
            }
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
        #endregion

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

            //p_home.Visibility = Visibility.Visible;
        }
    }
}