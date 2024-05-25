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
    public partial class Display : Form
    {
        public Display()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BinaryReader br = new BinaryReader(File.Open(Create.filename, FileMode.Open, FileAccess.Read));

            int num_of_records = (int)br.BaseStream.Length / Create.rec_size;

            if (num_of_records > 0) // If The file Not Empty
            {
                Previousbutton.Visible = true;
                DisplayBtn.Text = "Next";// Change the Button Text
                NumOfRecLabel.Text = num_of_records.ToString();
                FileSizeLabel.Text = br.BaseStream.Length.ToString();

                br.BaseStream.Seek(Create.count, SeekOrigin.Begin); // Move to Specific Position in a File

                idtextBox.Text = br.ReadInt32().ToString(); // Read ID and display it in the ID text Box

                nametextBox.Text = br.ReadString(); // Read Name 
                phonetextBox.Text = br.ReadString(); // Read Tel
                SubscriptiontextBox.Text = br.ReadString(); // Read Year


                if ((Create.count / Create.rec_size) >= (num_of_records - 1)) //Find record to end
                    Create.count = 0;
                else
                    Create.count += Create.rec_size;

            }
            else MessageBox.Show("Empty File");
            br.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new main().Show();
        }
    }
}
