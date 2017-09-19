using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ParameterizedSP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetTotalSalesButton_Click(object sender, EventArgs e)
        {
            var result = GetTotalSales(CustomerIDTextBox.Text);

            if (result == 0)
                TotalSalesLabel.Text = "user not found";
            else
                TotalSalesLabel.Text = String.Format("Total Sales: {0}", result);

        }
        private double GetTotalSales(string xxcustomerId)
        {
            double totalSales = 0;
            try
            {    
                string connectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=NORTHWND;Data Source=BRASS\ATLANTIS";

                SqlConnection connection = new SqlConnection(connectionString);

                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "GetCustomerSales";
                command.Parameters.AddWithValue("@CustomerId", xxcustomerId);
                command.Parameters.AddWithValue("@TotalSales", null);   
                command.Parameters["@TotalSales"].DbType= DbType.Currency;
                command.Parameters["@TotalSales"].Direction = ParameterDirection.Output;

                connection.Open();
                command.ExecuteNonQuery();

                var returnResults = command.Parameters["@TotalSales"].Value.ToString();

                if (returnResults == "")
                    returnResults = "0";

                totalSales = Double.Parse(returnResults);
                connection.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return totalSales;
        }
    }
}
