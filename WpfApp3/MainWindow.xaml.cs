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
using WpfApp3.DataSet1TableAdapters;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        UsersTableAdapter user = new UsersTableAdapter();
        List<string> listLog = new List<string>();
        List<string> Role = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Vxod_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                for (int i = 0; i < user.GetData().Count(); i++)
                {
                    listLog.Add(user.GetData().Rows[i][1].ToString() + user.GetData().Rows[i][2].ToString());
                }
                for (int i = 0; i < user.GetData().Count(); i++)
                {
                    Role.Add(user.GetData().Rows[i][3].ToString());
                }

                for (int i = 0; i < listLog.Count; i++)
                {
                    if (LoginBox.Text + PasswordBox.Password == listLog[i] && Role[i] == "2")
                    {
                        Sotrudnik sotrudnik = new Sotrudnik();
                        sotrudnik.Show();
                        this.Close();
                        break;
                    }
                    else if (LoginBox.Text + PasswordBox.Password == listLog[i] && Role[i] == "1")
                    {
                        Admin admin = new Admin();
                        admin.Show();
                        this.Close();
                        break;
                    }

                }

                listLog.Clear();
            }
            catch
            {
                MessageBox.Show("Проверьте правильность написания данных :)");
            }
        }

        private void Gost_Click(object sender, RoutedEventArgs e)
        {
            Client client = new Client();
            client.Show();
            this.Close();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
