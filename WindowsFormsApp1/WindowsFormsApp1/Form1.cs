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

namespace WindowsFormsApp1
{
    //public class FileMissing : Exception
    //{
    //    public FileMissing(string message) : base("File is missing Converse.txt")//base(message)
    //    {
    //    }
    //}

    public partial class Text : Form
    {
       
        public class users
        {
            public string username = string.Empty;
            public string Password = string.Empty;
            public string bmplobbylist;
            public string[] friends;
            public string[] pending;
            public string[] blocked;

            public users()
            { }        
            public void GetUserDetails(string IDuser, string IDpassword)
            {
                username = IDuser;
                Password = IDpassword;
                Console.WriteLine("username: {Admin}, Password: {123}", username, Password );
                
            }
        }

        string nametemp = "Jack";

        public Text()
            {
                InitializeComponent();
         
            richTextBox1.SelectionStart = richTextBox1.TextLength;
                richTextBox1.ScrollToCaret();
            }

            private void Text_Load(object sender, EventArgs e)
            {

            }

            private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
            {

            }
            
            private void button2_Click(object sender, EventArgs e)
            {

           
                string timestamp = DateTime.Now.ToString("MM dd yyyy H:mm:ss tt");
            string user = "[" + nametemp + "]";
                string line = user + " " + timestamp;
                string input = textBox1.Text;
                bool ifblocked = false;

                // Here is the Test Case for 
                
                StreamReader nwfile = new StreamReader("block.txt");
                string see = nwfile.ReadLine();
                while (see != null)
                {
                    if (nametemp == see)
                    {
                        ifblocked = true;
                    }
                    see = nwfile.ReadLine();
                }
                nwfile.Close();
                if (ifblocked)
                {
                    MessageBox.Show("You have been Blocked");
                }
                else
                {

                    File.AppendAllText("Converse.txt", line);
                    File.AppendAllText("Converse.txt", "\n" + input + "\n\n");
                    textBox1.Text = "";
                    string theline = "\n" + line + "\n" + input + "\n";
                    // string filetext = File.ReadAllText("Converse.txt"); // this refreashes from the start of the text file
                    // string filetext = File.R
                    string texty = theline;
                    richTextBox1.Text = richTextBox1.Text + theline;
                }
                //}
                
            }

            private void richTextBox1_TextChanged(object sender, EventArgs e)
            {
                // its feild wll be populated by function button2_Click(object sender , EventArgs e)
            }
            /*
            private void button1_Click(object sender, EventArgs e)      // this is refreash
            {
                //string filetext = File.ReadAllText("Converse.txt");
                //richTextBox1.Text = filetext;

            }
            */
            private void textBox1_TextChanged(object sender, EventArgs e)
            {

            }

            /*private void button1_Click(object sender, EventArgs e)
            {
                richTextBox2.Text = File.ReadAllText("MyFriends.txt");

            }*/

            private void button3_Click(object sender, EventArgs e)
            {/*
                string finder = textBox3.Text;
                StreamReader blocker = new StreamReader("Users.txt");
                string troll = blocker.ReadLine();
                while (troll != null)
                {
                    if (troll == finder)
                    {
                        File.AppendAllText("block.txt", troll);
                        File.AppendAllText("block.txt", "\n");
                    }
                    troll = blocker.ReadLine();
                }
                blocker.Close();
                textBox3.Text = "";*/
            }

            private void richTextBox2_TextChanged(object sender, EventArgs e)
            {

            }

            private void textBox2_TextChanged(object sender, EventArgs e)
            {

            }

            private void button4_Click(object sender, EventArgs e)
            {/*
                string looker = textBox2.Text;
                StreamReader file = new StreamReader("Users.txt");
                string friendly = file.ReadLine();
                while (friendly != null)
                {
                    if (looker == friendly)
                    {
                        File.AppendAllText("MyFriends.txt", looker);
                        File.AppendAllText("MyFriends.txt", "\n");
                    }
                    friendly = file.ReadLine();
                }
                file.Close();
                textBox2.Text = "";*/
            }

            private void button5_Click(object sender, EventArgs e)
            {/*
                FileStream jacob = File.Open("deletefriend.txt", FileMode.Open);
                jacob.SetLength(0);
                jacob.Close();
                string finder = textBox2.Text;
                StreamReader file = new StreamReader("MyFriends.txt");
                string deleter = file.ReadLine();
                while (deleter != null)
                {
                    if (deleter != finder)
                    {
                        File.AppendAllText("deletefriend.txt", deleter);
                        File.AppendAllText("deletefriend.txt", "\n");

                    }
                    deleter = file.ReadLine();
                }
                file.Close();

                FileStream fileStream = File.Open("MyFriends.txt", FileMode.Open);
                fileStream.SetLength(0);
                fileStream.Close();

                StreamReader newfile = new StreamReader("deletefriend.txt");
                string restore = newfile.ReadLine();
                while (restore != null)
                {

                    File.AppendAllText("MyFriends.txt", restore);
                    File.AppendAllText("MyFriends.txt", "\n");
                    restore = newfile.ReadLine();
                }
                newfile.Close();
                textBox2.Text = "";*/

            }

            private void button6_Click(object sender, EventArgs e)
            {
            /*
                FileStream spinny = File.Open("unblock.txt", FileMode.Open);
                spinny.SetLength(0);
                spinny.Close();

                string finder = textBox3.Text;
                StreamReader file = new StreamReader("block.txt");
                string undo = file.ReadLine();
                while (undo != null)
                {
                    if (undo != finder)
                    {
                        File.AppendAllText("unblock.txt", undo);
                        File.AppendAllText("unblock.txt", "\n");
                    }
                    undo = file.ReadLine();
                }
                file.Close();

                FileStream fileStream = File.Open("block.txt", FileMode.Open);
                fileStream.SetLength(0);
                fileStream.Close();

                StreamReader newfile = new StreamReader("unblock.txt");
                string restore = newfile.ReadLine();
                while (restore != null)
                {

                    File.AppendAllText("block.txt", restore);
                    File.AppendAllText("block.txt", "\n");
                    restore = newfile.ReadLine();
                }
                newfile.Close();
                textBox3.Text = "";*/


            }

            private void textBox3_TextChanged(object sender, EventArgs e)
            {

            }

            private void button7_Click(object sender, EventArgs e)
            {
                richTextBox1.Text = File.ReadAllText("lobbies.txt");
                textBox1.Text = "Write LobbyID here, then press create to make a lobby or Join to join lobby";

            }

            private void button8_Click(object sender, EventArgs e)
            {
                richTextBox1.Text = "";
                string finder = textBox1.Text;

                StreamReader newfile = new StreamReader("lobbies.txt");
                string restore = newfile.ReadLine();
                string com;
                int count = 0;
                string lobb;
                while (restore != null)
                {
                
                    for (int i = 0; i < restore.Length; i++)
                    {
                        com = restore.Substring(0, i);
                        if (finder == com)
                        {
                       
                            break;
                        }
                        count++;
                    }
                    lobb = restore.Substring(0, count);
                    if (finder == lobb)
                    { 
                        break;
                    }
                    restore = newfile.ReadLine();
                }
          

                File.AppendAllText("Converse.txt",restore);
                File.AppendAllText("Converse.txt", "\n");
            }

            private void button9_Click(object sender, EventArgs e)
            {
                string finder = textBox1.Text;
           


                File.AppendAllText("lobbies.txt", finder + ": " + "Jack" + ", " + DateTime.Now.ToString("MM dd yyyy HH:mm:ss tt"));
                File.AppendAllText("lobbies.txt", "\n");
            
            }

            private void button10_Click(object sender, EventArgs e)
            {
                richTextBox1.Text = "";
                FileStream fileStream = File.Open("Converse.txt", FileMode.Open);

                fileStream.SetLength(0);
                fileStream.Close();


            }

            private void button11_Click(object sender, EventArgs e)
            {

            }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            StreamReader newfile = new StreamReader("MyFriends.txt");
            string restore = newfile.ReadLine();

            while(restore != null)
            {
                comboBox1.Items.Add(restore);
                restore = newfile.ReadLine();
            }
            comboBox2.Items.Add("Video Chat");
            comboBox2.Items.Add("Voice Chat");
            comboBox2.Items.Add("Text chat");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            StreamReader newfile = new StreamReader("block.txt");
            string restore = newfile.ReadLine();

            while (restore != null)
            {
                comboBox1.Items.Add(restore);
                restore = newfile.ReadLine();
            }
            comboBox2.Items.Add("unblock");

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            StreamReader newfile = new StreamReader("pending.txt");
            string restore = newfile.ReadLine();

            while (restore != null)
            {
                comboBox1.Items.Add(restore);
                restore = newfile.ReadLine();
            }
            comboBox2.Items.Add("accept as friend");
            comboBox2.Items.Add("Reject");
            comboBox2.Items.Add("Ignore");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
             if(radioButton1.Checked)
            {
                if (comboBox2.Text == "Video Chat")
                {
                    comboBox1.Text = "";
                    comboBox2.Text = "";
                }
                if (comboBox2.Text == "Voice Chat")
                {
                    comboBox1.Text = "";
                    comboBox2.Text = "";

                }
                if (comboBox2.Text == "Text Chat")
                {
                    comboBox1.Text = "";
                    comboBox2.Text = "";

                }
            }
            if (radioButton2.Checked)
            {
                

                if (comboBox2.Text == "unblock")
                {
                    
                    FileStream spinny = File.Open("unblock.txt", FileMode.Open);
                    spinny.SetLength(0);
                    spinny.Close();

                    string finder = comboBox1.Text;
                    StreamReader file = new StreamReader("block.txt");
                    string undo = file.ReadLine();
                    while (undo != null)
                    {
                        if (undo != finder)
                        {
                            File.AppendAllText("unblock.txt", undo);
                            File.AppendAllText("unblock.txt", "\n");
                        }
                        else
                        {
                            
                        }
                        undo = file.ReadLine();
                    }
                    file.Close();

                    File.WriteAllText("block.txt","");
                   
                    StreamReader newfile = new StreamReader("unblock.txt");
                    string restore = newfile.ReadLine();
                    while (restore != null)
                    {

                        File.AppendAllText("block.txt", restore);
                        File.AppendAllText("block.txt", "\n");
                        restore = newfile.ReadLine();
                    }
                    newfile.Close();
                    comboBox1.Text = "";
                    comboBox2.Text = "";
                }
            }
            if (radioButton3.Checked)
            {
                if (comboBox2.Text == "accept as friend")
                {

                    string looker = comboBox1.Text;
                    StreamReader file = new StreamReader("Users.txt");
                    string friendly = file.ReadLine();
                    while (friendly != null)
                    {
                        if (looker == friendly)
                        {
                            File.AppendAllText("MyFriends.txt", looker);
                            File.AppendAllText("MyFriends.txt", "\n");
                        }
                        friendly = file.ReadLine();
                    }
                    comboBox1.Text = "";
                    comboBox2.Text = "";
                }
                if (comboBox2.Text == "Reject")
                {
                    string remove = comboBox1.Text;
                    comboBox1.Items.Remove(remove);
                    comboBox1.Text = "";
                    comboBox2.Text = "";

                }
                if (comboBox2.Text == "Ignore")
                {
                    comboBox1.Text = "";
                    comboBox2.Text = "";
                }

            }
        }
    }
    
}
