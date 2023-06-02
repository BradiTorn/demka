using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
    
    

    public partial class Sotrudnik : Window
    {

        TovarTableAdapter tovar = new TovarTableAdapter();

        public Sotrudnik()
        {
            InitializeComponent();
            ListTovar.ItemsSource = tovar.GetData();
            //ListTovar.DisplayMemberPath = "Name";
            //ListTovar.DisplayMemberPath = "Cena";
            //ListTovar.DisplayMemberPath = "Image";

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //public void Read()
        //{
        //    DataTable dt = ExecuteSql("SELECT * FROM Tovar");
        //    ListTovar.ItemsSource = dt.DefaultView;
        //}

        //static DataTable ExecuteSql(string sql)
        //{
        //    DataTable dt = new DataTable();
        //    SqlConnection conn = new SqlConnection(
        //        "Data Source=.\\SQLEXPRESS;Integrated Security=True;Initial Catalog=demka"
        //        );

        //    using (conn)
        //    {
        //        conn.Open();

        //        SqlCommand cmd = new SqlCommand(sql, conn);
        //        SqlDataReader read = cmd.ExecuteReader();

        //        using (read)
        //        {
        //            dt.Load(read);
        //        }
        //    }

        //    return dt;
        //}

    }
}
