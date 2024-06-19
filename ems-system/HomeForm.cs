using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ems_system
{
    public partial class HomeForm : Form
    {
        private MySqlConnection con = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        public HomeForm()
        {
            InitializeComponent();
            con.ConnectionString = @"server=localhost;database=ems_system;userid=root;password=;";
            slide_panel.Height = button1.Height;
            admin_panel.BringToFront();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            slide_panel.Height = button1.Height;
            slide_panel.Top = button1.Top;
            admin_panel.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            slide_panel.Height = button2.Height;
            slide_panel.Top = button2.Top;
            Employee_panel.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            slide_panel.Height = button3.Height;
            slide_panel.Top = button3.Top;
            this.Hide();
            AttendanceForm atf = new AttendanceForm();
            atf.ShowDialog();
            atf = null;
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {                       
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.ShowDialog();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            updateTotalNumbers();

            /*The function show data on employee_tb datagridview from database*/
            try
            {
                con.Open();
                cmd.Connection = con;
                string query = "SELECT * FROM employee_tb";
                cmd.CommandText = query;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();

                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            timer1.Start();

        }

        private void updateTotalNumbers()
        {
            //Total employee
            label1.Text = LoginForm.username;
            string query_total = "SELECT COUNT(*) FROM employee_tb";
            con.Open();
            cmd = new MySqlCommand(query_total, con);
            Int32 fuc = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();
            con.Close();
            label8.Text = "Total Number=" + fuc.ToString();

            //CE department
            string query_hr = "SELECT COUNT(*) FROM employee_tb WHERE Department='" + label3.Text + "' ";
            con.Open();
            cmd = new MySqlCommand(query_hr, con);
            Int32 fuc1 = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();
            con.Close();
            label3.Text = "CE=" + fuc1.ToString();

            //IT department
            string query_IT = "SELECT COUNT(*) FROM employee_tb WHERE Department='" + label4.Text + "' ";
            con.Open();
            cmd = new MySqlCommand(query_IT, con);
            Int32 fuc2 = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();
            con.Close();
            label4.Text = "IT=" + fuc2.ToString();

            //ME department
            string query_AC = "SELECT COUNT(*) FROM employee_tb WHERE Department='" + label5.Text + "' ";
            con.Open();
            cmd = new MySqlCommand(query_AC, con);
            Int32 fuc3 = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();
            con.Close();
            label5.Text = "ME=" + fuc3.ToString();

            //EE department
            string query_SC = "SELECT COUNT(*) FROM employee_tb WHERE Department='" + label6.Text + "' ";
            con.Open();
            cmd = new MySqlCommand(query_SC, con);
            Int32 fuc4 = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();
            con.Close();
            label6.Text = "EE=" + fuc4.ToString();

            //CoE department
            string query_CN = "SELECT COUNT(*) FROM employee_tb WHERE Department='" + label7.Text + "' ";
            con.Open();
            cmd = new MySqlCommand(query_CN, con);
            Int32 fuc5 = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();
            con.Close();
            label7.Text = "CoE=" + fuc5.ToString();

            //BS Math department
            string query_M = "SELECT COUNT(*) FROM employee_tb WHERE Department='" + label22.Text + "' ";
            con.Open();
            cmd = new MySqlCommand(query_M, con);
            Int32 fuc6 = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();
            con.Close();
            label22.Text = "BS Math=" + fuc6.ToString();

            //Architecture department
            string query_A = "SELECT COUNT(*) FROM employee_tb WHERE Department='" + label21.Text + "' ";
            con.Open();
            cmd = new MySqlCommand(query_A, con);
            Int32 fuc7 = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();
            con.Close();
            label21.Text = "Architecture=" + fuc7.ToString();

            //ABEL Language department
            string query_EL = "SELECT COUNT(*) FROM employee_tb WHERE Department='" + label20.Text + "' ";
            con.Open();
            cmd = new MySqlCommand(query_EL, con);
            Int32 fuc8 = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();
            con.Close();
            label20.Text = "ABEL=" + fuc8.ToString();

            //SE major in BSEd-Fil department
            string query_SEF = "SELECT COUNT(*) FROM employee_tb WHERE Department='" + label19.Text + "' ";
            con.Open();
            cmd = new MySqlCommand(query_SEF, con);
            Int32 fuc9 = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();
            con.Close();
            label19.Text = "BSEd-Fil=" + fuc9.ToString();

            //SE major in BSEd-Science department
            string query_SEC = "SELECT COUNT(*) FROM employee_tb WHERE Department='" + label23.Text + "' ";
            con.Open();
            cmd = new MySqlCommand(query_SEC, con);
            Int32 fuc10 = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();
            con.Close();
            label23.Text = "BSEd-Science=" + fuc10.ToString();

            //BECEd department
            string query_EC = "SELECT COUNT(*) FROM employee_tb WHERE Department='" + label28.Text + "' ";
            con.Open();
            cmd = new MySqlCommand(query_EC, con);
            Int32 fuc11 = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();
            con.Close();
            label28.Text = "BECEd=" + fuc11.ToString();

            //Non-teaching department
            string query_NT = "SELECT COUNT(*) FROM employee_tb WHERE Department='" + label30.Text + "' ";
            con.Open();
            cmd = new MySqlCommand(query_NT, con);
            Int32 fuc12 = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();
            con.Close();
            label30.Text = "Non-teaching=" + fuc12.ToString();

            //Personnel department
            string query_P = "SELECT COUNT(*) FROM employee_tb WHERE Department='" + label31.Text + "' ";
            con.Open();
            cmd = new MySqlCommand(query_P, con);
            Int32 fuc13 = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();
            con.Close();
            label31.Text = "Personnel=" + fuc13.ToString();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            // Check if all input textboxes are not empty
            if (string.IsNullOrWhiteSpace(idtext.Text) ||
                string.IsNullOrWhiteSpace(nametext.Text) ||
                string.IsNullOrWhiteSpace(addresstext.Text) ||
                string.IsNullOrWhiteSpace(dptext.Text) ||
                string.IsNullOrWhiteSpace(ptext.Text) ||
                string.IsNullOrWhiteSpace(edutext.Text) ||
                string.IsNullOrWhiteSpace(dateTimePicker1.Text) ||
                string.IsNullOrWhiteSpace(gtext.Text))
            {
                MessageBox.Show("Please fill in all the required fields.");
                return; // Exit the method if any textbox is empty
            }

            // Check if ID already exists in the database
            if (IsIdExists(idtext.Text))
            {
                MessageBox.Show("Someone already owns the ID. Please use a different ID.");
                return; // Exit the method if ID already exists
            }

            // For qrcode generator
            QRCoder.QRCodeGenerator QG = new QRCoder.QRCodeGenerator();
            var MyData = QG.CreateQrCode(idtext.Text, QRCoder.QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(MyData);
            pictureBox7.Image = code.GetGraphic(50);

            // Data insert into the database
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO employee_tb(ID,Name,Address,Department,Phone,Edu,DateOfBirth,Gender) Values ('" + idtext.Text + "','" + nametext.Text + "','" + addresstext.Text + "','" + dptext.Text + "','" + ptext.Text + "','" + edutext.Text + "','" + dateTimePicker1.Text + "','" + gtext.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Save Data");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            // For Save generate qrcode image in folder
            string initialDIR = @"C:\Users\acer\Desktop\QRfiles";
            var dialog = new SaveFileDialog();
            dialog.InitialDirectory = initialDIR;
            dialog.Filter = "PNG|*.png|JPEG|*jpeg|BMP|*.bmp|GIF|*.gif";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox7.Image.Save(dialog.FileName);
            }

            // Clear textboxes and image after successful insertion
            idtext.Text = "";
            nametext.Text = "";
            addresstext.Text = "";
            dptext.Text = "";
            edutext.Text = "";
            ptext.Text = "";
            gtext.Text = "";
            dateTimePicker1.Text = "";
            dptext.SelectedIndex = 0;
            pictureBox7.Image = null;

            // Update total numbers
            updateTotalNumbers();
        }

        // Function to check if ID already exists in the database
        private bool IsIdExists(string id)
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT COUNT(*) FROM employee_tb WHERE ID = @id";
            cmd.Parameters.AddWithValue("@id", id);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            return count > 0;
        }


        private void edit_btn_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(idtext.Text) ||
                string.IsNullOrWhiteSpace(nametext.Text) ||
                string.IsNullOrWhiteSpace(addresstext.Text) ||
                string.IsNullOrWhiteSpace(dptext.Text) ||
                string.IsNullOrWhiteSpace(ptext.Text) ||
                string.IsNullOrWhiteSpace(edutext.Text) ||
                string.IsNullOrWhiteSpace(dateTimePicker1.Text) ||
                string.IsNullOrWhiteSpace(gtext.Text)))
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "UPDATE employee_tb SET ID ='" + idtext.Text + "',Name='" + nametext.Text + "',Address='" + addresstext.Text + "',Department='" + dptext.Text + "',Phone='" + ptext.Text + "',Edu='" + edutext.Text + "',DateOfBirth='" + dateTimePicker1.Text + "',Gender='" + gtext.Text + "'  WHERE ID = '" + idtext.Text + "' ";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Update Data");
                    idtext.Text = "";
                    nametext.Text = "";
                    addresstext.Text = "";
                    dptext.Text = "";
                    edutext.Text = "";
                    ptext.Text = "";
                    gtext.Text = "";
                    dateTimePicker1.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
                
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(idtext.Text) ||
                string.IsNullOrWhiteSpace(nametext.Text) ||
                string.IsNullOrWhiteSpace(addresstext.Text) ||
                string.IsNullOrWhiteSpace(dptext.Text) ||
                string.IsNullOrWhiteSpace(ptext.Text) ||
                string.IsNullOrWhiteSpace(edutext.Text) ||
                string.IsNullOrWhiteSpace(dateTimePicker1.Text) ||
                string.IsNullOrWhiteSpace(gtext.Text)))
            {
                // Display a confirmation dialog
                DialogResult result = MessageBox.Show("Are you sure you want to delete this data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        con.Open();
                        MySqlCommand cmd = new MySqlCommand();
                        cmd.Connection = con;
                        cmd.CommandText = "DELETE FROM employee_tb  WHERE ID = '" + idtext.Text + "'  ";
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Delete Data");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error " + ex);
                        MessageBox.Show("Error " + ex);
                    }

                    // Clear textboxes after successful deletion
                    idtext.Text = "";
                    nametext.Text = "";
                    addresstext.Text = "";
                    dptext.Text = "";
                    edutext.Text = "";
                    ptext.Text = "";
                    gtext.Text = "";
                    dateTimePicker1.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            refresh();
            timer1.Start();
        }

        private void refresh()
        {
            con.Open();
            cmd.Connection = con;
            string query = "SELECT * FROM employee_tb ORDER BY ID DESC";
            cmd.CommandText = query;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count && e.ColumnIndex >= 0 && e.ColumnIndex < dataGridView1.Columns.Count)
            {
                // Check if the cell value is not null
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1.CurrentRow.Selected = true;
                    idtext.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    nametext.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    addresstext.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    dptext.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    edutext.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                    ptext.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                    string dateValue = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                    DateTime date;
                    if (DateTime.TryParse(dateValue, out date))
                    {
                        dateTimePicker1.Value = date;
                    }
                    else
                    {
                        // Handle the case where the string is not a valid DateTime
                        MessageBox.Show("Invalid Date Format");
                    }

                    gtext.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                }
                 
            }
            else
            {
                // Show a message dialog indicating that the selected cell is not valid
                MessageBox.Show("Selected cell is not valid.");
            }
        }

        
    }
}
