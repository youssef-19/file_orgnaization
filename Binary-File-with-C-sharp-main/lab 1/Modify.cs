using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace lab_1
{
    public partial class Modify : Form
    {
        public Modify()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(Create.filename, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            BinaryWriter bw = new BinaryWriter(fs);

            int num_of_records = (int)br.BaseStream.Length / Create.rec_size;
            if (OldIDtextBox.Text == "")
            {
                MessageBox.Show("Please Enter ID to modify");
            }
            if (NewIDtextBox.Text == "")
            {
                MessageBox.Show("Please Enter ID to Add");
            }
            else
            {
                if (num_of_records > 0) // If The file Not Empty
                {
                    NumOfRecLabel.Text = num_of_records.ToString();
                    FileSizeLabel.Text = br.BaseStream.Length.ToString();

                    while (true)
                    {

                        br.BaseStream.Seek(Create.count, SeekOrigin.Begin); // Move to Specific Position in a File

                        string readedid = br.ReadInt32().ToString();

                        if (OldIDtextBox.Text == readedid)
                        {
                            br.BaseStream.Seek(Create.count, SeekOrigin.Begin);
                            bw.Write(int.Parse(NewIDtextBox.Text)); //ID
                            MessageBox.Show("The New ID is Added");
                            bw.Close();
                            break;
                        }
                        if ((Create.count / Create.rec_size) >= (num_of_records - 1)) // If I reach the End of file 
                        {
                            MessageBox.Show("ID is not found");
                            break;
                        }
                        else
                            Create.count += Create.rec_size;
                    }
                }
                else MessageBox.Show("Empty File");
                br.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new main().Show();
        }
    }
}
