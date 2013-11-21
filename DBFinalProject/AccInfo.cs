using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Oracle();

namespace DBFinalProject
{
    public partial class AccInfo : Form
    {
        public AccInfo()
        {
            InitializeComponent();
            ListBox listbox1 = new ListBox();
            OracleDataReader myReader = myCommand.ExecuteReader();
            listbox1.Items.Add(myReader.GetString(1));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SelectCar newForm = new SelectCar();
            newForm.Show();
            this.Hide();
        }
    }
}
