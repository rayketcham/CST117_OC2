using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Author: Ray Ketcham
//Date: 7/8/2018
//Course: CST-117
//Notes:  Originally was going to call a ping or traceroute function, but grew incredibly difficult with the limited programming knowledge was not poissible at this time.
namespace CST117_OC2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Clears all forms
            if (radioButton1.Checked)
            {
                radioButton1.Checked = false;
            }
            if (radioButton2.Checked)
            { radioButton2.Checked = false;
            }
            if (checkBox1.Checked)
            {
                checkBox1.Checked = false;
            }
            if (checkBox2.Checked)
            {
                checkBox2.Checked = false;
            }
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //closes application
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Contains("google.com");
            //listBox1.Items.Contains("192.168.1.1");

            //Defining the control methods
            var text = this.Controls.OfType<CheckBox>();

            //label4.Text = text.ToString(); .original method of testing string outputs
            //I had difficulty making the color in my check boxes actually change the color of the text.  Probably went a little too difficult on this in my original planning.
            var maybe = String.Join("", text);
            string radio = (radioButton1.Checked) ? " Ping " : (radioButton2.Checked) ? "Trace Route":"";
            //If none is selected it will Display both
            string check= (checkBox1.Checked) ? " Green " : (checkBox2.Checked) ? " Red":"";
            string list = (listBox1.Items.Contains("google.com")) ? " google.com" : listBox1.Items.Contains("192.168.1.1") ? " 192.168.1.1 ":"";
            label4.Text = "You Selected" + radio + " to" + list + " the text color is" + check;
        }
            }
    }

