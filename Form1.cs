using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestDapper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        domain.CountrySP countrysp = new domain.CountrySP();
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns[0].Name = "Country ID";
            dataGridView1.Columns[1].Name = "Country Name";
            dataGridView1.Columns[2].Name = "State Name";

            dataGridView1.Columns[0].HeaderText = "Country ID";
            dataGridView1.Columns[1].HeaderText = "Country Name";
            dataGridView1.Columns[2].HeaderText = "State Name";

            var data = countrysp.GetAllCountry();
            foreach (var item in data)
            {
                foreach (var state in item.States)
                {
                    string[] row = new string[] { item.countryId.ToString(), item.countryName, state.stateName };
                    dataGridView1.Rows.Add(row);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns[0].Name = "Country ID";
            dataGridView1.Columns[1].Name = "Country Name";
            dataGridView1.Columns[2].Name = "State Name";

            dataGridView1.Columns[0].HeaderText = "Country ID";
            dataGridView1.Columns[1].HeaderText = "Country Name";
            dataGridView1.Columns[2].HeaderText = "State Name";
            var data = countrysp.GetCountryById();
            string[] row = new string[] { data.countryId.ToString(), data.countryName, data.State.stateName };
            dataGridView1.Rows.Add(row);
        }
    }
}
