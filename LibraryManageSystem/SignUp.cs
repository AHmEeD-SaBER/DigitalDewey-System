using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManageSystem
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=ELPROF;Initial Catalog=LibrarySystem;Integrated Security=True;Encrypt=False");

        private void SignUp_Load(object sender, EventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(@"D:\Poppins-SemiBold.ttf");
            foreach (Control c in this.Controls)
            {
                c.Font = new Font(pfc.Families[0], c.Font.Size - 2F);
                if (c is Label)
                {
                    c.BackColor = Color.Transparent;
                }
                if (c is Button)
                {

                    c.Cursor = Cursors.Hand;
                }
            }
        }
        public String userType;

        private void SIgninBtn_Click(object sender, EventArgs e)
        {
            String userName = userNameBox.Text;
            String password = passBox.Text;
            String query = "INSERT INTO Users (username, userPass, userType) VALUES ('" + userName + "' , '" + password + "', '" + userType + "');";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                query = "select userID from Users where username = '" + userName + "';";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                GlobalVariables.UserID = Convert.ToInt32(dt.Rows[0][0]);
                if (userType == "Admin")
                {
                    query = "INSERT INTO [Admin] (AdminID) VALUES ('"+ GlobalVariables.UserID +"');";
                    cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }
                this.Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }
            finally
            {
                conn.Close();

            }
        }


        private void Radiobtn_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton.Checked)
            {
                userType = radioButton.Text;
            }
        }

    }
}
