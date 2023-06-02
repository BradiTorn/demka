using System;
using System.Collections.Generic;
using System.Data;
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
using WpfApp3.DataSet1TableAdapters;

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {

        TovarTableAdapter tovar = new TovarTableAdapter();

        public Admin()
        {
            InitializeComponent();
            ListTovar.ItemsSource = tovar.GetData();
        }

    

        private void Dob_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(NameTovar.Text != "" && CenaTovara.Text != "")
                {
                    new TovarTableAdapter().InsertQuery(NameTovar.Text, Convert.ToDouble(CenaTovara.Text), ImageTovar.Text);
                    MessageBox.Show("Товар добавлен!");
                    ListTovar.ItemsSource = tovar.GetData();
                }
                else
                {
                    MessageBox.Show("Введите нормальные данные!");
                }
                
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void UpdBut_Click(object sender, RoutedEventArgs e)
        {
            object id = (ListTovar.SelectedItem as DataRowView).Row[0];
            tovar.UpdateQuery(NameTovar.Text, Convert.ToDouble(CenaTovara.Text), ImageTovar.Text, Convert.ToInt32(id));
            ListTovar.ItemsSource = tovar.GetData();
        }

        private void DelBut_Click(object sender, RoutedEventArgs e)
        {
            object id = (ListTovar.SelectedItem as DataRowView).Row[0];
            tovar.DeleteQuery(Convert.ToInt32(id));
            ListTovar.ItemsSource = tovar.GetData();
        }
    }
}
