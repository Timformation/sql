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

namespace getCityState
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            {
                getCityState(int.Parse(txtZip.Text));
            }
            private string getCityState(int Zip);

            String cnStr = "Data Source=134.39.173.35;Initial Catalog=tsirchuk_w17;User ID=tsirchuk_w17;password=Checkmate!";


            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = cnStr;

            cn.Open();
            SqlCommand cmd = new SqlCommand("Select city,state,zip from tblZipcodes where zip='" + Zip + "'", cn);
            SqlDataReader rdrZip;
            try
            {
                rdrZip = cmd.ExecuteReader();
                if (!rdrZip.HasRows) 
                
               
            {


                MessageBox.Show("Error.");

            }
        

            
            string city = rdrZip["city"].ToString();
            string state = rdrZip["state"].ToString();

            string cityState = city + ", " + state;
            return cityState;
        
        }
    }
}
    
