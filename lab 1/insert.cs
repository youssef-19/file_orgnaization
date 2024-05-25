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
    public partial class insert : Form
    {
        public insert()
        {
            InitializeComponent();
        }
        public struct client
        {
            public int id;
            public string name;
            public int phone;
            public string adress;
        }
        public List<client> clientlist = new List<client>();
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BinaryWriter bw = new BinaryWriter(File.Open(Create.filename, FileMode.Open, FileAccess.Write));
            int length = (int)bw.BaseStream.Length;
            if (length != 0) //not empty
            {
                bw.BaseStream.Seek(length, SeekOrigin.Begin);// move the poiner to the end file
            }
            bw.Write(int.Parse(idtextBox.Text)); //ID
            nametextBox.Text = nametextBox.Text.PadRight(15); //Name
            bw.Write(nametextBox.Text.Substring(0, 15));

            phonetextBox.Text = phonetextBox.Text.PadRight(11); //Phone
            bw.Write(phonetextBox.Text.Substring(0, 11));

            SubscriptiontextBox.Text = SubscriptiontextBox.Text.PadRight(8); //Subscription time
            bw.Write(SubscriptiontextBox.Text.Substring(0, 8));
                        
            length += Create.rec_size;

            idtextBox.Clear(); nametextBox.Clear(); phonetextBox.Clear(); SubscriptiontextBox.Clear();
            NumOfRecLabel.Text = (length / Create.rec_size).ToString(); // update new length file
            FileSizeLabel.Text = length.ToString();
            MessageBox.Show("Data is saved Successfully ......");
            bw.Close();


        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new main().Show();

        }

        private void NumOfRecLabel_Click(object sender, EventArgs e)
        {

        }

        private void NumOfRecLabel_Click_1(object sender, EventArgs e)
        {

        }
    }
}
