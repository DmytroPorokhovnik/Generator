using Generator.ExtensionDeb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public static readonly DependencyProperty CompanyNameProperty =DependencyProperty.Register("FilePath", typeof(string), typeof(HomePage));

        public string FilePath
        {
            get { return (string)this.GetValue(CompanyNameProperty); }
            set { this.SetValue(CompanyNameProperty, value); }
        }
        public HomePage()
        {
            InitializeComponent();
            FilePath = ExtensionHelper.GetCurrentProjectPath();
        }
    }
}
