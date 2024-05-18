using System.Drawing.Text;
using System.Data.SqlClient;
using System.Data;

namespace LibraryManageSystem
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=ELPROF;Initial Catalog=LibrarySystem;Integrated Security=True;Encrypt=False");



        private void Form1_Load(object sender, EventArgs e)
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
                if(c is Button)
                {

                    c.Cursor = Cursors.Hand;
                }
            }


        }



        private void loginBtn_Click(object sender, EventArgs e)
        {
            String userName = userBox.Text;
            String userPass = passBox.Text;

            try
            {
                String query = "SELECT * FROM Users WHERE username = '" + userName + "' AND userPass  = '" + userPass + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);

                DataTable dTable = new DataTable();
                sda.Fill(dTable);

                if (dTable.Rows.Count > 0)
                {
                    userName = userBox.Text;
                    userPass = passBox.Text;
                    GlobalVariables.UserName = dTable.Rows[0][0].ToString();
                    GlobalVariables.UserID = Convert.ToInt32(dTable.Rows[0][1]);
                    GlobalVariables.UserPass = dTable.Rows[0][2].ToString();
                    GlobalVariables.UserType = dTable.Rows[0][3].ToString();

                    Home otherForm = new Home();
                    otherForm.Show();
                    this.Hide();

                }

                else
                {
                    MessageBox.Show("Invalid UserName or Password!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    userBox.Clear();
                    passBox.Clear();

                }

            }
            catch
            {
                MessageBox.Show("ERROR!");
            }
            finally
            {
                conn.Close();
            }
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            SignUp otherForm = new SignUp();
            otherForm.Show();
        }
    }
    public static class GlobalVariables
    {
        public static int UserID { get; set; }
        public static String UserType { get; set; }
        public static String UserPass { get; set;}
        public static String UserName { get; set; }
    }


}
