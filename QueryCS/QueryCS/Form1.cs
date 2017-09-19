using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;







namespace QueryCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0) { SelectData(textBox1.Text); }
        }

        private void SelectData(string selectCommandText)
        {
            try
            {

                string SelectConnection =
              @"Data Source = BRASS\ATLANTIS; Initial Catalog = AdventureWorks2014; Integrated Security = True";
                SqlDataAdapter dataAdapter =
                    new SqlDataAdapter(
                        selectCommandText, SelectConnection);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                dataGridView1.DataSource = table;




            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message);
            }





        } 
           
        
           

    
       
           






    }
}


