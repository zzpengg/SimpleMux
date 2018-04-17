using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleMux
{
    public partial class Form : System.Windows.Forms.Form
    {
        public int price = 0;

        public int ticket = 1;

        public Form()
        {
            InitializeComponent();
            totalFare.Text = "";
        }

        public void changeTotalFare ()
        {
            totalFare.Text = (this.price * this.ticket).ToString();
        }

        private void price20_Click(object sender, EventArgs e)
        {
            this.price = 20;
            this.changeTotalFare();
        }

        private void price25_Click(object sender, EventArgs e)
        {
            this.price = 25;
            this.changeTotalFare();
        }

        private void price30_Click(object sender, EventArgs e)
        {
            this.price = 30;
            this.changeTotalFare();
        }

        private void price35_Click(object sender, EventArgs e)
        {
            this.price = 35;
            this.changeTotalFare();
        }

        private void price40_Click(object sender, EventArgs e)
        {
            this.price = 40;
            this.changeTotalFare();
        }

        private void price45_Click(object sender, EventArgs e)
        {
            this.price = 45;
            this.changeTotalFare();
        }

        private void price50_Click(object sender, EventArgs e)
        {
            this.price = 50;
            this.changeTotalFare();
        }

        private void price55_Click(object sender, EventArgs e)
        {
            this.price = 55;
            this.changeTotalFare();
        }

        private void price60_Click(object sender, EventArgs e)
        {
            this.price = 60;
            this.changeTotalFare();
        }

        private void ticket2_Click(object sender, EventArgs e)
        {
            this.ticket = 2;
            this.changeTotalFare();
        }

        private void ticket3_Click(object sender, EventArgs e)
        {
            this.ticket = 3;
            this.changeTotalFare();
        }

        private void ticket4_Click(object sender, EventArgs e)
        {
            this.ticket = 4;
            this.changeTotalFare();
        }

        private void ticket5_Click(object sender, EventArgs e)
        {
            this.ticket = 5;
            this.changeTotalFare();
        }

        private void ticket6_Click(object sender, EventArgs e)
        {
            this.ticket = 6;
            this.changeTotalFare();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.price = 0;
            this.ticket = 1;
            totalFare.Text = "";
        }
    }
}
