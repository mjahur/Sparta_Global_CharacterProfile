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
using Microsoft.Win32;
using System.IO;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AddProfile np;
        public MainWindow()
        {
            InitializeComponent();
            np = new AddProfile();
        }
        
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            np.Name = name.Text;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            np.Type = "Superhero";
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            np.Type = "Antihero";
        }

        private void Age_TextChanged(object sender, TextChangedEventArgs e)
        {
            np.Age = Int32.Parse(age.Text);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Please select an image image";
            ofd.Filter = "All supported graphics|*.jpg;*.jpeg;*.png";
            if (ofd.ShowDialog() == true)
            {
                image.Source = new BitmapImage(new Uri(ofd.FileName));
            }

            np.Filepath = image.Source;  
        }

        private void Villain_Checked(object sender, RoutedEventArgs e)
        {
            np.Type = "Villain";
        }

        private void Sidekick_Checked(object sender, RoutedEventArgs e)
        {
            np.Type = "Sidekick";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (np.Name != null && np.Age.ToString() != null && np.Type != null && np.Filepath != null)
            {

            }
            np.storeProfile();
            MessageBox.Show(np.Name + " " + np.Age.ToString() + " " + np.Type + " " + np.Filepath);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
