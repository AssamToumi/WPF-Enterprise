using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WpfEntreprise
{
    /// <summary>
    /// Interaction logic for Buttons.xaml
    /// </summary>
    public partial class Buttons : Page
    {
        public Buttons()
        {
            InitializeComponent();
        }

        private void OrdinaryButton_OnClick(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Ordinary Button");
        }

        private void RepeatButton_OnClick(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Repeat Button");
        }
        private void ToggleButton_OnClick(object sender, RoutedEventArgs e) 
        {
            Debug.WriteLine("Toggle Button");
        }
        #region Checked-Uncheched-Indeterminate
        private void ToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            var toggleButton = (ToggleButton) sender;
            Debug.WriteLine("{0} is checked. Now IsChecked={1}", toggleButton.Name, toggleButton.IsChecked);
        }

        private void ToggleButton_UnChecked(object sender, RoutedEventArgs e)
        {
            var toggleButton = (ToggleButton)sender;
            Debug.WriteLine("{0} is checked. Now IsChecked={1}", toggleButton.Name, toggleButton.IsChecked);

        }
        private void ToggleButton_Indeterminate(object sender, RoutedEventArgs e)
        {
            var toggleButton = (ToggleButton)sender;
            Debug.WriteLine("{0} is checked. Now IsChecked={1}", toggleButton.Name, toggleButton.IsChecked);

        }
        #endregion
    }
}