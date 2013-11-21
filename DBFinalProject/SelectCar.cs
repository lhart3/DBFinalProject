using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace DBFinalProject
{
    public partial class SelectCar : Form
    {
        public SelectCar()
        {
            InitializeComponent();
        }

        private void SelectCar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AccInfo userInfo = new AccInfo();
            userInfo.Show();
            this.Hide();
        }
    }
}
