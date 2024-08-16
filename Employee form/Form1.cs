using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data.SqlClient;
using System.Diagnostics;
using static System.Windows.Forms.AxHost;
using System.Diagnostics.Metrics;
using System.Net;

namespace Employee_form
{
    public partial class Form1 : Form
    {


        public void SetFormData(string firstName, string lastName, string salary, string city, string address, string age, string country, string email, string state, string phoneNumber, string ssn)
        {
        
            textBox3.Text = firstName;
            textBox2.Text = lastName;
            textBox6.Text = salary.ToString();
            textBox1.Text = city;
            textBox5.Text = address;
            textBox7.Text = age;
            comboBox2.Text = country;
            textBox4.Text = email;
            comboBox1.Text = state;
            maskedTextBox1.Text = phoneNumber;
            maskedTextBox2.Text = ssn;

        }

        public void SetFormData( DateTime dateofbirth)
        {
            dateTimePicker1.Value= dateofbirth;
        }

        public void SetFormData(string gender)
        {
            if (gender == "Male")
            {
                radioButton1.Checked = true;
            }
            else if (gender == "Female")
            {
                radioButton2.Checked = true;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {


            // Process or save the valid SSN
            // Example
        }

        private void textBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            comboBox2.Items.Add("Afghanistan");
            comboBox2.Items.Add("Albania");
            comboBox2.Items.Add("Algeria");
            comboBox2.Items.Add("Andorra");
            comboBox2.Items.Add("Angola");
            comboBox2.Items.Add("Antigua and Barbuda");
            comboBox2.Items.Add("Argentina");
            comboBox2.Items.Add("Armenia");
            comboBox2.Items.Add("Australia");
            comboBox2.Items.Add("Austria");
            comboBox2.Items.Add("Azerbaijan");
            comboBox2.Items.Add("Bahamas");
            comboBox2.Items.Add("Bahrain");
            comboBox2.Items.Add("Bangladesh");
            comboBox2.Items.Add("Barbados");
            comboBox2.Items.Add("Belarus");
            comboBox2.Items.Add("Belgium");
            comboBox2.Items.Add("Belize");
            comboBox2.Items.Add("Benin");
            comboBox2.Items.Add("Bhutan");
            comboBox2.Items.Add("Bolivia");
            comboBox2.Items.Add("Bosnia and Herzegovina");
            comboBox2.Items.Add("Botswana");
            comboBox2.Items.Add("Brazil");
            comboBox2.Items.Add("Brunei");
            comboBox2.Items.Add("Bulgaria");
            comboBox2.Items.Add("Burkina Faso");
            comboBox2.Items.Add("Burundi");
            comboBox2.Items.Add("Cabo Verde");
            comboBox2.Items.Add("Cambodia");
            comboBox2.Items.Add("Cameroon");
            comboBox2.Items.Add("Canada");
            comboBox2.Items.Add("Central African Republic");
            comboBox2.Items.Add("Chad");
            comboBox2.Items.Add("Chile");
            comboBox2.Items.Add("China");
            comboBox2.Items.Add("Colombia");
            comboBox2.Items.Add("Comoros");
            comboBox2.Items.Add("Congo");
            comboBox2.Items.Add("Costa Rica");
            comboBox2.Items.Add("Croatia");
            comboBox2.Items.Add("Cuba");
            comboBox2.Items.Add("Cyprus");
            comboBox2.Items.Add("Czech Republic");
            comboBox2.Items.Add("Democratic Republic of the Congo");
            comboBox2.Items.Add("Denmark");
            comboBox2.Items.Add("Djibouti");
            comboBox2.Items.Add("Dominica");
            comboBox2.Items.Add("Dominican Republic");
            comboBox2.Items.Add("East Timor (Timor-Leste)");
            comboBox2.Items.Add("Ecuador");
            comboBox2.Items.Add("Egypt");
            comboBox2.Items.Add("El Salvador");
            comboBox2.Items.Add("Equatorial Guinea");
            comboBox2.Items.Add("Eritrea");
            comboBox2.Items.Add("Estonia");
            comboBox2.Items.Add("Eswatini");
            comboBox2.Items.Add("Ethiopia");
            comboBox2.Items.Add("Fiji");
            comboBox2.Items.Add("Finland");
            comboBox2.Items.Add("France");
            comboBox2.Items.Add("Gabon");
            comboBox2.Items.Add("Gambia");
            comboBox2.Items.Add("Georgia");
            comboBox2.Items.Add("Germany");
            comboBox2.Items.Add("Ghana");
            comboBox2.Items.Add("Greece");
            comboBox2.Items.Add("Grenada");
            comboBox2.Items.Add("Guatemala");
            comboBox2.Items.Add("Guinea");
            comboBox2.Items.Add("Guinea-Bissau");
            comboBox2.Items.Add("Guyana");
            comboBox2.Items.Add("Haiti");
            comboBox2.Items.Add("Honduras");
            comboBox2.Items.Add("Hungary");
            comboBox2.Items.Add("Iceland");
            comboBox2.Items.Add("India");
            comboBox2.Items.Add("Indonesia");
            comboBox2.Items.Add("Iran");
            comboBox2.Items.Add("Iraq");
            comboBox2.Items.Add("Ireland");
            comboBox2.Items.Add("Israel");
            comboBox2.Items.Add("Italy");
            comboBox2.Items.Add("Ivory Coast");
            comboBox2.Items.Add("Jamaica");
            comboBox2.Items.Add("Japan");
            comboBox2.Items.Add("Jordan");
            comboBox2.Items.Add("Kazakhstan");
            comboBox2.Items.Add("Kenya");
            comboBox2.Items.Add("Kiribati");
            comboBox2.Items.Add("Kosovo");
            comboBox2.Items.Add("Kuwait");
            comboBox2.Items.Add("Kyrgyzstan");
            comboBox2.Items.Add("Laos");
            comboBox2.Items.Add("Latvia");
            comboBox2.Items.Add("Lebanon");
            comboBox2.Items.Add("Lesotho");
            comboBox2.Items.Add("Liberia");
            comboBox2.Items.Add("Libya");
            comboBox2.Items.Add("Liechtenstein");
            comboBox2.Items.Add("Lithuania");
            comboBox2.Items.Add("Luxembourg");
            comboBox2.Items.Add("Madagascar");
            comboBox2.Items.Add("Malawi");
            comboBox2.Items.Add("Malaysia");
            comboBox2.Items.Add("Maldives");
            comboBox2.Items.Add("Mali");
            comboBox2.Items.Add("Malta");
            comboBox2.Items.Add("Marshall Islands");
            comboBox2.Items.Add("Mauritania");
            comboBox2.Items.Add("Mauritius");
            comboBox2.Items.Add("Mexico");
            comboBox2.Items.Add("Micronesia");
            comboBox2.Items.Add("Moldova");
            comboBox2.Items.Add("Monaco");
            comboBox2.Items.Add("Mongolia");
            comboBox2.Items.Add("Montenegro");
            comboBox2.Items.Add("Morocco");
            comboBox2.Items.Add("Mozambique");
            comboBox2.Items.Add("Myanmar (Burma)");
            comboBox2.Items.Add("Namibia");
            comboBox2.Items.Add("Nauru");
            comboBox2.Items.Add("Nepal");
            comboBox2.Items.Add("Netherlands");
            comboBox2.Items.Add("New Zealand");
            comboBox2.Items.Add("Nicaragua");
            comboBox2.Items.Add("Niger");
            comboBox2.Items.Add("Nigeria");
            comboBox2.Items.Add("North Korea");
            comboBox2.Items.Add("North Macedonia");
            comboBox2.Items.Add("Norway");
            comboBox2.Items.Add("Oman");
            comboBox2.Items.Add("Pakistan");
            comboBox2.Items.Add("Palau");
            comboBox2.Items.Add("Palestine");
            comboBox2.Items.Add("Panama");
            comboBox2.Items.Add("Papua New Guinea");
            comboBox2.Items.Add("Paraguay");
            comboBox2.Items.Add("Peru");
            comboBox2.Items.Add("Philippines");
            comboBox2.Items.Add("Poland");
            comboBox2.Items.Add("Portugal");
            comboBox2.Items.Add("Qatar");
            comboBox2.Items.Add("Romania");
            comboBox2.Items.Add("Russia");
            comboBox2.Items.Add("Rwanda");
            comboBox2.Items.Add("Saint Kitts and Nevis");
            comboBox2.Items.Add("Saint Lucia");
            comboBox2.Items.Add("Saint Vincent and the Grenadines");
            comboBox2.Items.Add("Samoa");
            comboBox2.Items.Add("San Marino");
            comboBox2.Items.Add("Sao Tome and Principe");
            comboBox2.Items.Add("Saudi Arabia");
            comboBox2.Items.Add("Senegal");
            comboBox2.Items.Add("Serbia");
            comboBox2.Items.Add("Seychelles");
            comboBox2.Items.Add("Sierra Leone");
            comboBox2.Items.Add("Singapore");
            comboBox2.Items.Add("Slovakia");
            comboBox2.Items.Add("Slovenia");
            comboBox2.Items.Add("Solomon Islands");
            comboBox2.Items.Add("Somalia");
            comboBox2.Items.Add("South Africa");
            comboBox2.Items.Add("South Korea");
            comboBox2.Items.Add("South Sudan");
            comboBox2.Items.Add("Spain");
            comboBox2.Items.Add("Sri Lanka");
            comboBox2.Items.Add("Sudan");
            comboBox2.Items.Add("Suriname");
            comboBox2.Items.Add("Sweden");
            comboBox2.Items.Add("Switzerland");
            comboBox2.Items.Add("Syria");
            comboBox2.Items.Add("Taiwan");
            comboBox2.Items.Add("Tajikistan");
            comboBox2.Items.Add("Tanzania");
            comboBox2.Items.Add("Thailand");
            comboBox2.Items.Add("Togo");
            comboBox2.Items.Add("Tonga");
            comboBox2.Items.Add("Trinidad and Tobago");
            comboBox2.Items.Add("Tunisia");
            comboBox2.Items.Add("Turkey");
            comboBox2.Items.Add("Turkmenistan");
            comboBox2.Items.Add("Tuvalu");
            comboBox2.Items.Add("Uganda");
            comboBox2.Items.Add("Ukraine");
            comboBox2.Items.Add("United Arab Emirates");
            comboBox2.Items.Add("United Kingdom");
            comboBox2.Items.Add("United States");
            comboBox2.Items.Add("Uruguay");
            comboBox2.Items.Add("Uzbekistan");
            comboBox2.Items.Add("Vanuatu");
            comboBox2.Items.Add("Vatican City (Holy See)");
            comboBox2.Items.Add("Venezuela");
            comboBox2.Items.Add("Vietnam");
            comboBox2.Items.Add("Yemen");
            comboBox2.Items.Add("Zambia");
            comboBox2.Items.Add("Zimbabwe");

        }
        Dictionary<string, string[]> statesByCountry = new Dictionary<string, string[]>()
{

    { "Canada", new string[] { "Alberta", "British Columbia", "Manitoba", "New Brunswick", "Newfoundland and Labrador", "Northwest Territories", "Nova Scotia", "Nunavut", "Ontario", "Prince Edward Island", "Quebec", "Saskatchewan", "Yukon" } },
    { "India", new string[] {"Andhra Pradesh","Arunachal Pradesh", "Assam","Bihar", "Chhattisgarh", "Goa", "Gujarat", "Haryana", "Himachal Pradesh", "Jharkhand", "Karnataka", "Kerala", "Madhya Pradesh", "Maharashtra", "Manipur", "Meghalaya", "Mizoram", "Nagaland", "Odisha", "Punjab", "Rajasthan", "Sikkim", "Tamil Nadu", "Telangana", "Tripura", "Uttar Pradesh", "Uttarakhand", "West Bengal", "Andaman and Nicobar Islands","Chandigarh", "Dadra and Nagar Haveli and Daman and Diu","Delhi", "Lakshadweep", "Puducherry"} },
    // Add more countries and their states
    { "United States", new string[] { "Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorado", "Connecticut", "Delaware", "Florida",
                                      "Georgia", "Hawaii", "Idaho", "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky", "Louisiana", "Maine",
                                      "Maryland", "Massachusetts", "Michigan", "Minnesota", "Mississippi", "Missouri", "Montana", "Nebraska",
                                      "Nevada", "New Hampshire", "New Jersey", "New Mexico", "New York", "North Carolina", "North Dakota",
                                      "Ohio", "Oklahoma", "Oregon", "Pennsylvania", "Rhode Island", "South Carolina", "South Dakota",
                                      "Tennessee", "Texas", "Utah", "Vermont", "Virginia", "Washington", "West Virginia", "Wisconsin", "Wyoming" } },
    { "China", new string[] { "Anhui", "Beijing", "Chongqing", "Fujian", "Gansu", "Guangdong", "Guangxi Zhuang Autonomous Region", "Guizhou",
                             "Hainan", "Hebei", "Heilongjiang", "Henan", "Hubei", "Hunan", "Inner Mongolia Autonomous Region", "Jiangsu",
                             "Jiangxi", "Jilin", "Liaoning", "Ningxia Hui Autonomous Region", "Qinghai", "Shaanxi", "Shandong", "Shanghai",
                             "Shanxi", "Sichuan", "Tianjin", "Tibet Autonomous Region", "Xinjiang Uygur Autonomous Region", "Yunnan", "Zhejiang" } },
     { "United Kingdom", new string[] { "England", "Scotland", "Wales", "Northern Ireland" } }
};
        private object gender;

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCountry = comboBox2.SelectedItem.ToString();

            if (statesByCountry.ContainsKey(selectedCountry))
            {
                comboBox1.Items.Clear(); // Clear existing items
                comboBox1.Items.AddRange(statesByCountry[selectedCountry]); // Add states for the selected country
            }
            else
            {
                // Handle the case where the selected country doesn't have states defined
                comboBox1.Items.Clear();
                comboBox1.Items.Add("No states/provinces available");
            }
        }

        private void button1_Click(object sender, EventArgs e)

        {

            string firstName = textBox3.Text.Trim();
            string lastName = textBox2.Text.Trim();
            string email = textBox4.Text.Trim();
            string ssn = maskedTextBox2.Text.Trim();
            string phone = maskedTextBox1.Text.Trim();
            string city = textBox1.Text.Trim();
            string address = textBox5.Text.Trim();
            string age = textBox7.Text.Trim();
            string salary = textBox6.Text.Trim();
            string gender = string.Empty;
            if (radioButton1.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }


            // Validate inputs
            bool isFirstNameValid = IsFirstNameValid(firstName);
            bool isEmailValid = ValidateEmail(email);
            bool isSSNValid = ValidateSSN(ssn);
            bool isPhoneValid = Validatephone(phone);


            if (isFirstNameValid && isEmailValid && isSSNValid && isPhoneValid)
            {
                // Connection string for your SQL Server database
                string connectionString = "Server=.\\SQLEXPRESS;Database=dummy;Integrated Security=True;";

                // SQL query to insert data into the database
                bool employeeExists = CheckIfEmployeeExists(ssn, connectionString);

                string query = "";

                if (employeeExists)
                {
                    // Update existing record
                    query = @"
                UPDATE EmployeeForm 
                SET FirstName = @FirstName, 
                    LastName = @LastName, 
                    Gender = @Gender, 
                    DateOfBirth = @DateOfBirth, 
                    Country = @Country, 
                    State = @State, 
                    City = @City, 
                    Address = @Address, 
                    Email = @Email, 
                    PhoneNumber = @PhoneNumber, 
                    Age = @Age, 
                    Salary = @Salary
                WHERE SSN = @SSN";
                }
                else


               query = "INSERT INTO EmployeeForm (FirstName, LastName, Gender, DateOfBirth, Country, State, City, Address, Email, SSN, PhoneNumber, Age, Salary) " +
                               "VALUES (@FirstName, @LastName, @Gender, @DateOfBirth, @Country, @State, @City, @Address, @Email, @SSN, @PhoneNumber, @Age, @Salary)";

                


                try
                {
                    // Establish connection to SQL Server
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        // Open the connection
                        connection.Open();

                        // Create a SqlCommand object with your query and connection
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Add parameters to the SqlCommand
                            command.Parameters.AddWithValue("@FirstName", firstName);
                            command.Parameters.AddWithValue("@LastName", lastName);
                            command.Parameters.AddWithValue("@Gender", gender);
                            command.Parameters.AddWithValue("@DateOfBirth", dateTimePicker1.Value);
                            command.Parameters.AddWithValue("@Country", comboBox2.Text);
                            command.Parameters.AddWithValue("@State", comboBox1.Text);
                            command.Parameters.AddWithValue("@City", city);
                            command.Parameters.AddWithValue("@Address", address);
                            command.Parameters.AddWithValue("@Email", email);
                            command.Parameters.AddWithValue("@SSN", ssn);
                            command.Parameters.AddWithValue("@PhoneNumber", phone);
                            command.Parameters.AddWithValue("@Age", age);
                            command.Parameters.AddWithValue("@Salary", salary);

                            // Execute the SQL command (insert operation)
                            int rowsAffected = command.ExecuteNonQuery();

                            // Check if data saved successfully
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearForm(); // Clear input fields after successful submission
                            }
                            else
                            {
                                MessageBox.Show("Data could not be saved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Validation failed. Data was not saved.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Form2 fun = new Form2();
            this.Hide();
            fun.ShowDialog();

        }
        private bool CheckIfEmployeeExists(string ssn, string connectionString)
        {
            string query = "SELECT COUNT(*) FROM EmployeeForm WHERE SSN = @SSN";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SSN", ssn);

                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
        }

        private void ClearForm()
        {
            textBox3.Clear();
            textBox2.Clear();
            textBox4.Clear();
            maskedTextBox2.Clear();
            maskedTextBox1.Clear();
            textBox1.Clear();
            textBox5.Clear();
            textBox7.Clear();
            textBox6.Clear();
            comboBox2.SelectedIndex = -1;
            comboBox1.Items.Clear();
            comboBox1.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Today;
            radioButton1.Checked = true; // Assuming default is Male
        }

        private bool IsFirstNameValid(string firstName)
        {
            if (string.IsNullOrWhiteSpace(firstName))
            {
                MessageBox.Show("First name should not be blank.", "Validation Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool ValidateEmail(string email)
        {
            if (IsValidEmail(email))
            {
                MessageBox.Show("Email address is valid.", "Validation Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Email address field should not be blank.", "Validation Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                MessageBox.Show("Invalid email address format.", "Validation Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool ValidateSSN(string ssn)
        {
            if (IsValidSSN(ssn))
            {
                MessageBox.Show("SSN is valid.", "Validation Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else if (string.IsNullOrWhiteSpace(ssn))
            {
                MessageBox.Show("SSN field should not be blank.", "Validation Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                MessageBox.Show("Invalid SSN format.", "Validation Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool IsValidSSN(string ssn)
        {
            // Implement your SSN validation logic here (example code)
            return Regex.IsMatch(ssn, @"^\d{3}-\d{2}-\d{4}$");
        }

        private bool Validatephone(string phone)
        {
            if (IsValidphone(phone))
            {
                MessageBox.Show("Phone number is valid.", "Validation Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else if (string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Phone number field should not be blank.", "Validation Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                MessageBox.Show("Invalid phone number format.", "Validation Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool IsValidphone(string phone)
        {
            // Implement your phone number validation logic here (example code)

            string pattern = @"^\(\d{3}\) \d{3}-\d{4}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(phone);

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}





    



