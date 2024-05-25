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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }
        

        private void Form3_Load(object sender, EventArgs e)
        {
            displayFNtextBox.Text = Create.filename;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BinaryReader br = new BinaryReader(File.Open(Create.filename, FileMode.Open, FileAccess.Read));

            int num_of_records = (int)br.BaseStream.Length / Create.rec_size;
            if (SearchIDtextBox.Text == "")
            {
                MessageBox.Show("Please Enter ID to search");
            }
            else{

                if (num_of_records > 0) // If The file Not Empty
                {
                    NumOfRecLabel.Text = num_of_records.ToString();
                    FileSizeLabel.Text = br.BaseStream.Length.ToString();

                    while (true)
                    {
                        
                            br.BaseStream.Seek(Create.count, SeekOrigin.Begin); // Move to Specific Position in a File

                            string readedid = br.ReadInt32().ToString();

                            if (SearchIDtextBox.Text == readedid)
                            {
                                string readname = br.ReadString();
                                string readphone = br.ReadString();
                                string readSubscriptiontime = br.ReadString();
                                MessageBox.Show("Client Info\nID : "+ readedid +"   Name : "+ readname + " Phone : "+ readphone + " Subscription time : "+ readSubscriptiontime, "Client is found", MessageBoxButtons.OK);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new main().Show();
        }
    }
}
