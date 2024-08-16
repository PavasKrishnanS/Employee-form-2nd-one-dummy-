using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Employee_form
{
    public partial class Form2 : Form
    {
        string connectionString = "Server=.\\SQLEXPRESS;Database=dummy;Integrated Security=True;";

        private object dataGridViewEmployeeForm;

        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.ShowDialog();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void Form2_Load(object sender, EventArgs e)
        {

            string query = "SELECT EmployeeID, FirstName, LastName, Gender, DateOfBirth, Country, State, City, Address, Email, SSN, PhoneNumber, Age, Salary FROM EmployeeForm";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataTable EmployeeFormTable = new DataTable();
                try
                {


                    connection.Open();
                    adapter.Fill(EmployeeFormTable);

                    // Ensure auto generation of columns if needed
                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.DataSource = EmployeeFormTable;

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading employee data: {ex.Message}");
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
                // Assuming this button is placed on your form and configured in the designer
                // Assuming this button is placed on your form and configured in the designer
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Get the selected EmployeeID from the DataGridView
                    string employeeID = dataGridView1.SelectedRows[0].Cells["EmployeeID"].Value.ToString();

                    // Confirm deletion with user
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this employee?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        // Delete from DataGridView
                        dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);

                        // Delete from Database
                        DeleteEmployeeFormFromDatabase(employeeID); // Call separate method to delete from database
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to delete.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
        }

            // Method to delete employee from database
            private void DeleteEmployeeFormFromDatabase(string employeeID)
            {
                string query = "DELETE FROM EmployeeForm WHERE EmployeeID = @EmployeeID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EmployeeID", employeeID);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Employee deleted successfully from database.");
                        }
                        else
                        {
                            MessageBox.Show("No rows deleted from database.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting employee from database: {ex.Message}");
                    }

                }
            }

        private void button2_Click(object sender, EventArgs e)
        {

             if (dataGridView1.SelectedRows.Count > 0)
    {
        // Get the selected EmployeeID from the DataGridView
        string employeeID = dataGridView1.SelectedRows[0].Cells["EmployeeID"].Value.ToString();
        
        // Create an instance of Form1 (assuming Form1 is Form2 in your code)
        Form1 f = new Form1();

                // Pass the employeeID to Form1 (optional, if needed for further processing)
                f.SetFormData(
           dataGridView1.SelectedRows[0].Cells["FirstName"].Value.ToString(),
            dataGridView1.SelectedRows[0].Cells["LastName"].Value.ToString(),
           dataGridView1.SelectedRows[0].Cells["Salary"].Value.ToString(),
            dataGridView1.SelectedRows[0].Cells["City"].Value.ToString(),
            dataGridView1.SelectedRows[0].Cells["Address"].Value.ToString(),
            dataGridView1.SelectedRows[0].Cells["Age"].Value.ToString(),
            dataGridView1.SelectedRows[0].Cells["Country"].Value.ToString(),
            dataGridView1.SelectedRows[0].Cells["Email"].Value.ToString(),
            dataGridView1.SelectedRows[0].Cells["State"].Value.ToString(),
            dataGridView1.SelectedRows[0].Cells["PhoneNumber"].Value.ToString(),
            dataGridView1.SelectedRows[0].Cells["SSN"].Value.ToString() );


                f.SetFormData(Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["DateOfBirth"].Value)
                    );
                f.SetFormData(
                dataGridView1.SelectedRows[0].Cells["Gender"].Value.ToString()
                );
                // Show Form1 for editing
                f.ShowDialog();

        // Optionally, hide or close Form2 (this form)
        // this.Hide();
        // this.Close();
    }
    else
    {
        MessageBox.Show("Please select a row to edit.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
}
        }
    }
    







