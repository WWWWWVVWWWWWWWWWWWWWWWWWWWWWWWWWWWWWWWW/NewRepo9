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

namespace WpfApp5
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void OnDeleteAppointment_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Функция удаления записи пока не реализована.");
        }

        private void OnEditAppointmen_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Функция изменения записи пока не реализована.");
        }

        private void OnAddAppointment_Click(object sender, RoutedEventArgs e)
        {
            var addEditWindow = new Page2();
            addEditWindow.ShowDialog();
        }
    }
}
