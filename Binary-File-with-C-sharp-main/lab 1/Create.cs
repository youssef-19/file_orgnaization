using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_1
{
    public partial class Create : Form
    {
        public static string filename = "";
        public static int rec_size = 41; //Record Size
        public static int count = 0; // Count Number of Records
        public Create()
        {
            InitializeComponent();
        }

        private void Create_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            filename = Directory.GetCurrentDirectory() + textBox1.Text + ".txt";
            if (!File.Exists(filename))
            {
                File.Create(filename).Close();
                MessageBox.Show("File is created Successfully in the path:\n"+ filename , "Note", MessageBoxButtons.OK);
            }
            else
            {
                label2.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            filename = Directory.GetCurrentDirectory() + textBox1.Text + ".txt";
            File.Delete(filename);
            MessageBox.Show("File is deleted", "Note", MessageBoxButtons.OK);
            textBox1.Clear();
            label2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new main().Show();
        }
    }
}
