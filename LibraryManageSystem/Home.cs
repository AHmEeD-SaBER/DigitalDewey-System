using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LibraryManageSystem
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            DisplayBooks();
        }



        private void Home_Load(object sender, EventArgs e)
        {
            saveUserBtn.Visible = false;
            deleteBookBtn.Visible = false;
            passBox.PasswordChar = '*';

            if (GlobalVariables.UserType.ToLower() == "admin")
            {
                addBookbtn.Visible = true;
                updateBookbtn.Visible = true;
            }
            else
            {
                addBookbtn.Visible = false;
                updateBookbtn.Visible = false;
            }
            foreach (Control c in sideBar.Controls)
            {
                if (c is Panel)
                {
                    foreach (Control button in c.Controls)
                    {
                        if (button is Button)
                        {
                            button.MouseEnter += onMouseEnter;
                            button.MouseLeave += onMouseLeave;
                            button.Cursor = Cursors.Hand;

                        }
                    }
                }
                else if (c is Button)
                {
                    c.MouseEnter += onMouseEnter;
                    c.MouseLeave += onMouseLeave;
                    c.Cursor = Cursors.Hand;
                }

                else if (c is Label)
                {
                    c.BackColor = Color.Transparent;
                }
                else if (c is FlowLayoutPanel)
                {
                    foreach (Control button in c.Controls)
                    {
                        if (button is Button)
                        {
                            button.MouseEnter += onMouseEnter;
                            button.MouseLeave += onMouseLeave;
                            button.Cursor = Cursors.Hand;
                        }
                    }
                }

            }


        }
        SqlConnection conn = new SqlConnection(@"Data Source=ELPROF;Initial Catalog=LibrarySystem;Integrated Security=True;Encrypt=False");
        private void DisplayBooks()
        {
            try
            {
                conn.Open();
                String query = "select title, categorName, price, A.secondName,P.secondName, B.ISBN from Book B , Category C,Author A, Publisher P,Book_Contained BC Where B.AuthorID = A.AuthorID AND B.PublisherID = P.PublisherID AND BC.bISBN = B.ISBN AND BC.cID = C.categoryID ";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                SqlCommandBuilder scb = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                addedBooksDGV.DataSource = ds.Tables[0];
                addedBooksDGV.Columns[0].HeaderText = "Title";
                addedBooksDGV.Columns[1].HeaderText = "Category";
                addedBooksDGV.Columns[2].HeaderText = "Price";
                addedBooksDGV.Columns[3].HeaderText = "Author";
                addedBooksDGV.Columns[4].HeaderText = "Publisher";
                addedBooksDGV.Columns[5].HeaderText = "ISBN";
                for (int i = 0; i < 6; i++)
                {
                    addedBooksDGV.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 15, FontStyle.Bold);
                }


                booksDGV.DataSource = ds.Tables[0];
                booksDGV.Columns[0].HeaderText = "Title";
                booksDGV.Columns[1].HeaderText = "Category";
                booksDGV.Columns[2].HeaderText = "Price";
                booksDGV.Columns[3].HeaderText = "Author";
                booksDGV.Columns[4].HeaderText = "Publisher";
                booksDGV.Columns[5].HeaderText = "ISBN";
                for (int i = 0; i < 6; i++)
                {
                    booksDGV.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 15, FontStyle.Bold);
                }

                updatedBooksDGV.DataSource = ds.Tables[0];
                updatedBooksDGV.Columns[0].HeaderText = "Title";
                updatedBooksDGV.Columns[1].HeaderText = "Category";
                updatedBooksDGV.Columns[2].HeaderText = "Price";
                updatedBooksDGV.Columns[3].HeaderText = "Author";
                updatedBooksDGV.Columns[4].HeaderText = "Publisher";
                updatedBooksDGV.Columns[5].HeaderText = "ISBN";
                for (int i = 0; i < 6; i++)
                {
                    updatedBooksDGV.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 15, FontStyle.Bold);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving the books: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }


        }

        private void onMouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Aqua;
            btn.ForeColor = Color.Black;
        }

        private void onMouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Transparent;
            btn.ForeColor = Color.White;
        }


        public bool isExpanded;
        private void sideBarTimer_Tick(object sender, EventArgs e)
        {
            if (isExpanded)
            {
                sideBar.Width = sideBar.Width - 40;
                if (sideBar.Width == sideBar.MinimumSize.Width)
                {
                    sideBarTimer.Stop();
                    isExpanded = false;
                }

            }
            else
            {
                sideBar.Width = sideBar.Width + 40;
                if (sideBar.Width == sideBar.MaximumSize.Width)
                {
                    sideBarTimer.Stop();
                    isExpanded = true;
                }

            }
            homePanel.Size = new Size(homePanel.Width - sideBar.Width, 0);

        }

        private void AddBook()
        {
            String bTitle, bAuthor, bPublisher, bISBN, bPrcie, bCategory;
            bTitle = titleBox.Text;
            bAuthor = authorBox.Text;
            bPublisher = publisherBox.Text;
            bISBN = ISBNBox.Text;
            bPrcie = priceBox.Text;
            bCategory = categoryBox.Text;
            int Price = (int)Convert.ToInt64(bPrcie);
            int ISBN = (int)Convert.ToInt64(bISBN);
            try
            {
                conn.Open();



                // Check if the author exists
                String query = "SELECT AuthorID FROM Author WHERE secondName = '" + bAuthor + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                SqlCommand sc;

                DataTable dTable = new DataTable();
                sda.Fill(dTable);
                int authorID;
                // If the author does not exist, insert them
                if (dTable.Rows.Count > 0)
                {
                    authorID = (int)dTable.Rows[0][0];
                }
                else
                {
                    query = "INSERT INTO Author (secondName) VALUES (@bAuthor)";
                    sc = new SqlCommand(query, conn);
                    sc.Parameters.AddWithValue("@bAuthor", bAuthor);
                    sc.ExecuteNonQuery();

                    query = "SELECT AuthorID FROM Author WHERE secondName = @bAuthor";
                    sc = new SqlCommand(query, conn);
                    sc.Parameters.AddWithValue("@bAuthor", bAuthor);
                    sda = new SqlDataAdapter(sc);
                    dTable = new DataTable();
                    sda.Fill(dTable);
                    authorID = (int)dTable.Rows[0][0];
                }



                // Check if the Category exists
                query = "SELECT categoryID FROM Category WHERE categorName = @bCategory";
                sc = new SqlCommand(query, conn);
                sc.Parameters.AddWithValue("@bCategory", bCategory);
                sda = new SqlDataAdapter(sc);

                dTable = new DataTable();
                sda.Fill(dTable);
                int categoryID;

                // If the Category does not exist, insert them
                if (dTable.Rows.Count > 0)
                {
                    categoryID = (int)dTable.Rows[0][0];
                }
                else
                {
                    query = "INSERT INTO Category (categorName) VALUES (@bCategory)";
                    sc = new SqlCommand(query, conn);
                    sc.Parameters.AddWithValue("@bCategory", bCategory);
                    sc.ExecuteNonQuery();

                    query = "SELECT categoryID FROM Category WHERE categorName = @bCategory";
                    sc = new SqlCommand(query, conn);
                    sc.Parameters.AddWithValue("@bCategory", bCategory);
                    sda = new SqlDataAdapter(sc);
                    dTable = new DataTable();
                    sda.Fill(dTable);
                    categoryID = (int)dTable.Rows[0][0];
                }

                // Check if the Publisher exists
                query = "SELECT PublisherID FROM Publisher WHERE secondName = @bPublisher";
                sc = new SqlCommand(query, conn);
                sc.Parameters.AddWithValue("@bPublisher", bPublisher);
                sda = new SqlDataAdapter(sc);

                dTable = new DataTable();
                sda.Fill(dTable);
                int publisherID;

                // If the Publisher does not exist, insert them
                if (dTable.Rows.Count > 0)
                {
                    publisherID = (int)dTable.Rows[0][0];
                }
                else
                {
                    query = "INSERT INTO Publisher (secondName) VALUES (@bPublisher)";
                    sc = new SqlCommand(query, conn);
                    sc.Parameters.AddWithValue("@bPublisher", bPublisher);
                    sc.ExecuteNonQuery();

                    query = "SELECT PublisherID FROM Publisher WHERE secondName = @bPublisher";
                    sc = new SqlCommand(query, conn);
                    sc.Parameters.AddWithValue("@bPublisher", bPublisher);
                    sda = new SqlDataAdapter(sc);
                    dTable = new DataTable();
                    sda.Fill(dTable);
                    publisherID = (int)dTable.Rows[0][0];
                }



                query = "INSERT INTO Book (title, ISBN, AuthorID, PublisherID,price) VALUES (@bTitle, @bISBN, @authorID, @publisherID, @Bprice)";
                sc = new SqlCommand(query, conn);
                sc.Parameters.AddWithValue("@bTitle", bTitle);
                sc.Parameters.AddWithValue("@bISBN", ISBN);
                sc.Parameters.AddWithValue("@authorID", authorID);
                sc.Parameters.AddWithValue("@publisherID", publisherID);
                sc.Parameters.AddWithValue("@Bprice", Price);
                sc.ExecuteNonQuery();

                query = "INSERT INTO Book_Contained (cID, bISBN) values(@categoryID, @bISBN)";
                sc = new SqlCommand(query, conn);
                sc.Parameters.AddWithValue("@categoryID", categoryID);
                sc.Parameters.AddWithValue("@bISBN", ISBN);
                sc.ExecuteNonQuery();

                query = "INSERT INTO  ADD_Book(ISBN, aID) values(@ISBN, @AID)";
                sc = new SqlCommand(query, conn);
                sc.Parameters.AddWithValue("@ISBN", ISBN);
                sc.Parameters.AddWithValue("@AID", GlobalVariables.UserID);
                sc.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the book: " + ex.Message);
            }
            finally
            {
                conn.Close();
                titleBox.Text = "";
                authorBox.Text = "";
                publisherBox.Text = "";
                ISBNBox.Text = "";
                priceBox.Text = "";
                categoryBox.Text = "";

            }
        }

        private void List_Click(object sender, EventArgs e)
        {
            sideBarTimer.Start();
        }

        private void Homebtn_Click(object sender, EventArgs e)
        {
            homePanel.BringToFront();
            DisplayBooks();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddBook();

            DisplayBooks();
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            userNameBox.Text = GlobalVariables.UserName;
            passBox.Text = GlobalVariables.UserPass;
            userPanel.BringToFront();

        }
        private int ISBNValue;

        private void guna2DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (updatedBooksDGV.SelectedRows.Count > 0)
            {

                DataGridViewRow row = updatedBooksDGV.SelectedRows[0];


                String titleValue = row.Cells[0].Value.ToString();
                String categoryValue = row.Cells[1].Value.ToString();
                String priceValue = row.Cells[2].Value.ToString();
                String authorValue = row.Cells[3].Value.ToString();
                String publisherValue = row.Cells[4].Value.ToString();
                ISBNValue = (int)Convert.ToInt64(row.Cells[5].Value.ToString());
                addAuthorBox.Text = authorValue;
                addCatBox.Text = categoryValue;
                addPriceBox.Text = priceValue;
                addPubBox.Text = publisherValue;
                addTitleBox.Text = titleValue;
                deleteBookBtn.Visible = true;

            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

            String bTitle, bAuthor, bPublisher, bISBN, bPrcie, bCategory;
            bTitle = addTitleBox.Text;
            bAuthor = addAuthorBox.Text;
            bPublisher = addPubBox.Text;
            bPrcie = addPriceBox.Text;
            bCategory = addCatBox.Text;
            int Price = (int)Convert.ToInt64(bPrcie);
            try
            {
                conn.Open();



                // Check if the author exists
                String query = "SELECT AuthorID FROM Author WHERE secondName = '" + bAuthor + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                SqlCommand sc;

                DataTable dTable = new DataTable();
                sda.Fill(dTable);
                int authorID;
                // If the author does not exist, insert them
                if (dTable.Rows.Count > 0)
                {
                    authorID = (int)dTable.Rows[0][0];
                }
                else
                {
                    query = "INSERT INTO Author (secondName) VALUES (@bAuthor)";
                    sc = new SqlCommand(query, conn);
                    sc.Parameters.AddWithValue("@bAuthor", bAuthor);
                    sc.ExecuteNonQuery();

                    query = "SELECT AuthorID FROM Author WHERE secondName = @bAuthor";
                    sc = new SqlCommand(query, conn);
                    sc.Parameters.AddWithValue("@bAuthor", bAuthor);
                    sda = new SqlDataAdapter(sc);
                    dTable = new DataTable();
                    sda.Fill(dTable);
                    authorID = (int)dTable.Rows[0][0];
                }



                // Check if the Category exists
                query = "SELECT categoryID FROM Category WHERE categorName = @bCategory";
                sc = new SqlCommand(query, conn);
                sc.Parameters.AddWithValue("@bCategory", bCategory);
                sda = new SqlDataAdapter(sc);

                dTable = new DataTable();
                sda.Fill(dTable);
                int categoryID;

                // If the Category does not exist, insert them
                if (dTable.Rows.Count > 0)
                {
                    categoryID = (int)dTable.Rows[0][0];
                }
                else
                {
                    query = "INSERT INTO Category (categorName) VALUES (@bCategory)";
                    sc = new SqlCommand(query, conn);
                    sc.Parameters.AddWithValue("@bCategory", bCategory);
                    sc.ExecuteNonQuery();

                    query = "SELECT categoryID FROM Category WHERE categorName = @bCategory";
                    sc = new SqlCommand(query, conn);
                    sc.Parameters.AddWithValue("@bCategory", bCategory);
                    sda = new SqlDataAdapter(sc);
                    dTable = new DataTable();
                    sda.Fill(dTable);
                    categoryID = (int)dTable.Rows[0][0];
                }

                // Check if the Publisher exists
                query = "SELECT PublisherID FROM Publisher WHERE secondName = @bPublisher";
                sc = new SqlCommand(query, conn);
                sc.Parameters.AddWithValue("@bPublisher", bPublisher);
                sda = new SqlDataAdapter(sc);

                dTable = new DataTable();
                sda.Fill(dTable);
                int publisherID;

                // If the Publisher does not exist, insert them
                if (dTable.Rows.Count > 0)
                {
                    publisherID = (int)dTable.Rows[0][0];
                }
                else
                {
                    query = "INSERT INTO Publisher (secondName) VALUES (@bPublisher)";
                    sc = new SqlCommand(query, conn);
                    sc.Parameters.AddWithValue("@bPublisher", bPublisher);
                    sc.ExecuteNonQuery();

                    query = "SELECT PublisherID FROM Publisher WHERE secondName = @bPublisher";
                    sc = new SqlCommand(query, conn);
                    sc.Parameters.AddWithValue("@bPublisher", bPublisher);
                    sda = new SqlDataAdapter(sc);
                    dTable = new DataTable();
                    sda.Fill(dTable);
                    publisherID = (int)dTable.Rows[0][0];
                }



                query = "update Book set title = @bTitle, AuthorID = @authorID, PublisherID =  @publisherID ,price = @Bprice where ISBN = @bISBN";
                sc = new SqlCommand(query, conn);
                sc.Parameters.AddWithValue("@bTitle", bTitle);
                sc.Parameters.AddWithValue("@authorID", authorID);
                sc.Parameters.AddWithValue("@publisherID", publisherID);
                sc.Parameters.AddWithValue("@Bprice", Price);
                sc.Parameters.AddWithValue("@bISBN", ISBNValue);
                sc.ExecuteNonQuery();

                query = "update Book_Contained set cID = @categoryID where bISBN = @bISBN";
                sc = new SqlCommand(query, conn);
                sc.Parameters.AddWithValue("@categoryID", categoryID);
                sc.Parameters.AddWithValue("@bISBN", ISBNValue);
                sc.ExecuteNonQuery();

                query = "INSERT INTO  updateBookDetails (bISBN, aID) values(@ISBN, @AID)";
                sc = new SqlCommand(query, conn);
                sc.Parameters.AddWithValue("@AID", GlobalVariables.UserID);
                sc.Parameters.AddWithValue("@ISBN", ISBNValue);
                sc.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updatting the book: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            DisplayBooks();
            updateBookPanel.BringToFront();
            addAuthorBox.Text = "";
            addCatBox.Text = "";
            addPriceBox.Text = "";
            addPubBox.Text = "";
            addTitleBox.Text = "";
        }

        private void updateBookbtn_Click(object sender, EventArgs e)
        {
            updateBookPanel.BringToFront();
            addAuthorBox.Text = "";
            addCatBox.Text = "";
            addPriceBox.Text = "";
            addPubBox.Text = "";
            addTitleBox.Text = "";

            DisplayBooks();
        }

        private void deleteUserBtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                String query = "delete from ADD_Book where aID  = @userID";
                SqlCommand sc = new SqlCommand(query, conn);
                sc.Parameters.AddWithValue("@userID", GlobalVariables.UserID);
                sc.ExecuteNonQuery();

                query = "delete from updateBookDetails where aID  = @userID";
                sc = new SqlCommand(query, conn);
                sc.Parameters.AddWithValue("@userID", GlobalVariables.UserID);
                sc.ExecuteNonQuery();

                query = "DELETE FROM Borrowed_Book WHERE UserID = @userID";
                sc = new SqlCommand(query, conn);
                sc.Parameters.AddWithValue("@userID", GlobalVariables.UserID);
                sc.ExecuteNonQuery();


                query = "DELETE FROM Admin WHERE AdminID = @userID";
                sc = new SqlCommand(query, conn);
                sc.Parameters.AddWithValue("@userID", GlobalVariables.UserID);
                sc.ExecuteNonQuery();

                query = "DELETE FROM Users WHERE UserID = @userID";
                sc = new SqlCommand(query, conn);
                sc.Parameters.AddWithValue("@userID", GlobalVariables.UserID);
                sc.ExecuteNonQuery();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the user: " + ex.Message);
            }
            finally
            {
                conn.Close();
                Application.Exit();
            }
        }

        private void addBookbtn_Click(object sender, EventArgs e)
        {
            addBookPanel.BringToFront();
            DisplayBooks();
        }

        private void textBox_Changed(object sender, EventArgs e)
        {
            if (userNameBox.Modified)
            {
                saveUserBtn.Visible = true;
            }
            if (passBox.Modified)
            {
                saveUserBtn.Visible = true;
                showPassBtn1.Visible = true;
            }
        }

        private void saveUserBtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                String query = "update Users set username = @userName, userPass = @userPass where UserID = @userID";
                SqlCommand sc = new SqlCommand(query, conn);
                sc.Parameters.AddWithValue("@userName", userNameBox.Text);
                sc.Parameters.AddWithValue("@userPass", passBox.Text);
                sc.Parameters.AddWithValue("@userID", GlobalVariables.UserID);
                GlobalVariables.UserName = userNameBox.Text;
                GlobalVariables.UserPass = passBox.Text;
                sc.ExecuteNonQuery();
                saveUserBtn.Visible = false;
                MessageBox.Show("User details updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("An error occurred while updating the user details");
            }
            finally
            {
                conn.Close();
            }
        }

        private void deleteBookBtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                String query = "DELETE FROM Book_Contained WHERE  bISBN = @ISBN";
                SqlCommand sc = new SqlCommand(query, conn);
                sc.Parameters.AddWithValue("@ISBN", ISBNValue);
                sc.ExecuteNonQuery();

                query = "DELETE FROM ADD_Book WHERE  ISBN = @ISBN";
                sc = new SqlCommand(query, conn);
                sc.Parameters.AddWithValue("@ISBN", ISBNValue);
                sc.ExecuteNonQuery();

                query = "DELETE FROM updateBookDetails WHERE  bISBN = @ISBN";
                sc = new SqlCommand(query, conn);
                sc.Parameters.AddWithValue("@ISBN", ISBNValue);
                sc.ExecuteNonQuery();

                query = "DELETE FROM Borrowed_Book WHERE  ISBN = @ISBN";
                sc = new SqlCommand(query, conn);
                sc.Parameters.AddWithValue("@ISBN", ISBNValue);
                sc.ExecuteNonQuery();


                query = "DELETE FROM Book WHERE  ISBN = @ISBN";
                sc = new SqlCommand(query, conn);
                sc.Parameters.AddWithValue("@ISBN", ISBNValue);
                sc.ExecuteNonQuery();
                addAuthorBox.Text = "";
                addCatBox.Text = "";
                addPriceBox.Text = "";
                addPubBox.Text = "";
                addTitleBox.Text = "";


            }
            catch
            {

            }
            finally
            {
                conn.Close();
                DisplayBooks();
                deleteBookBtn.Visible = false;
            }
        }

        private void booksDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (booksDGV.SelectedRows.Count > 0)
            {

                DataGridViewRow row = booksDGV.SelectedRows[0];


                String titleValue = row.Cells[0].Value.ToString();
                String categoryValue = row.Cells[1].Value.ToString();
                String priceValue = row.Cells[2].Value.ToString();
                String authorValue = row.Cells[3].Value.ToString();
                String publisherValue = row.Cells[4].Value.ToString();
                ISBNValue = (int)Convert.ToInt64(row.Cells[5].Value.ToString());
                aBX.Text = authorValue;
                cBX.Text = categoryValue;
                prBX.Text = priceValue;
                pBX.Text = publisherValue;
                mainLB.Text = titleValue;
                try
                {
                    conn.Open();
                    String query = "SELECT * FROM Borrowed_Book WHERE ISBN = @ISBN AND UserID = @ID";
                    SqlCommand sc = new SqlCommand(query, conn);
                    sc.Parameters.AddWithValue("@ISBN", ISBNValue);
                    sc.Parameters.AddWithValue("@ID", GlobalVariables.UserID);
                    SqlDataAdapter sda = new SqlDataAdapter(sc);
                    DataTable dTable = new DataTable();
                    sda.Fill(dTable);
                    if (dTable.Rows.Count > 0)
                    {
                        borrowBtn.Text = "Borrowed";
                        borrowBtn.Enabled = false;
                        borrowBtn.BackColor = Color.Gray;
                    }
                }
                catch
                {
                    MessageBox.Show("An error occurred while checking if the book is borrowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }

                bookDetails.BringToFront();
            }
        }

        private void borrowBtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                String query = "INSERT INTO Borrowed_Book (ISBN,title, UserID,borrowing_date) values(@ISBN, @title, @ID, CONVERT(DATE, GETDATE()) )";
                SqlCommand sc = new SqlCommand(query, conn);
                sc.Parameters.AddWithValue("@ISBN", ISBNValue);
                sc.Parameters.AddWithValue("@title", aBX.Text);
                sc.Parameters.AddWithValue("@ID", GlobalVariables.UserID);
                sc.ExecuteNonQuery();
                MessageBox.Show("Book borrowed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occurred while borrowing the book"+ex.Message);
            }
            finally
            {
                conn.Close();
                homePanel.BringToFront();
            }
        }

        private void viewBooksBtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                String query = "select title, categorName, price, A.secondName, P.secondName, from Book B , Category C, Author A, Publisher P, Book_Contained BC, Borrowed_Book BB Where B.AuthorID = A.AuthorID AND B.PublisherID = P.PublisherID AND BC.bISBN = B.ISBN AND BC.cID = C.categoryID AND B.ISBN = BB.ISBN AND BB.UserID = @ID AND BB.borrowing_date >= DATEADD(month, -3, GETDATE())";
                SqlCommand sc = new SqlCommand(query, conn);
                sc.Parameters.AddWithValue("@ID", GlobalVariables.UserID);

                SqlDataAdapter sda = new SqlDataAdapter(sc);
                SqlCommandBuilder scb = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                borrowedBooksDGV.DataSource = ds.Tables[0];
                borrowedBooksDGV.Columns[0].HeaderText = "Title";
                borrowedBooksDGV.Columns[1].HeaderText = "Category";
                borrowedBooksDGV.Columns[2].HeaderText = "Price";
                borrowedBooksDGV.Columns[3].HeaderText = "Author";
                borrowedBooksDGV.Columns[4].HeaderText = "Publisher";
                borrowedBooksDGV.Columns[5].HeaderText = "ISBN";
                for (int i = 0; i < 6; i++)
                {
                    borrowedBooksDGV.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 15, FontStyle.Bold);
                }
            }
            catch
            {
                MessageBox.Show("An error occurred while retrieving the borrowed books", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                borrowedBookspanel.BringToFront();
            }
        }

        private void showPassBtn1_Click(object sender, EventArgs e)
        {
            if (passBox.PasswordChar == '*')
            {
                passBox.PasswordChar = '\0';
            }
            else
            {
                passBox.PasswordChar = '*';
            }
        }
    }
}
