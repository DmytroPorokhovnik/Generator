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

namespace Generator
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Window
    {
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
