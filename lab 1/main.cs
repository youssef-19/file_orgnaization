using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace lab_1
{
    public partial class main : Form 
    {
        public main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }


        private void button_WOC1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Create().Show();
        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new insert().Show();
        }

        private void button_WOC3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Display().Show();
        }

        private void button_WOC4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SearchForm().Show();
        }

        private void button_WOC5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Modify().Show();
        }

        private void button_WOC6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
