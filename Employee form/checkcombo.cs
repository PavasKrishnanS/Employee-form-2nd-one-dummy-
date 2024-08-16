using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_form
{
    public partial class checkcombo : Form
    {
        public checkcombo()
        {
            InitializeComponent();
            
        }

        private void checkcombo_Load(object sender, EventArgs e)
        {
            
            comboBox1.Items.Add("India");
            comboBox1.Items.Add("Canada");
            comboBox1.Items.Add("United Kingdom");
            comboBox1.Items.Add("United States");
            comboBox1.Items.Add("China");
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCountry = comboBox1.SelectedItem.ToString();

            if (statesByCountry.ContainsKey(selectedCountry))
            {
                comboBox2.Items.Clear(); // Clear existing items
                comboBox2.Items.AddRange(statesByCountry[selectedCountry]); // Add states for the selected country
            }
            else
            {
                // Handle the case where the selected country doesn't have states defined
                comboBox2.Items.Clear();
                comboBox2.Items.Add("No states/provinces available");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
