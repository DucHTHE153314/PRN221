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
using System.Windows.Shapes;

namespace AllControlls
{
    /// <summary>
    /// Interaction logic for ComboBox.xaml
    /// </summary>
    public partial class ComboBox : Window
    {
        /// <summary>
        /// Initialize Component
        /// </summary>
        public ComboBox()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Call when color combobox changed.
        /// </summary>
        private void Color_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var Selected_Color = (StackPanel) Color.SelectedItem;
            var label = Selected_Color.Children[1] as Label;
            if (label != null)
            {
                String color = label.Content.ToString();
                color_selected.Content = "Your color is: " + color;
            }           

        }

        /// <summary>
        /// Call when user click to get city.
        /// </summary>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var Selected_City = (StackPanel)City.SelectedItem;
            var label = Selected_City.Children[0] as Label;
            if (label != null)
            {
                String city = label.Content.ToString();
                city_selected.Content = city;
            }
        }
    }
}
