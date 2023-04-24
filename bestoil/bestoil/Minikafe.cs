using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bestoil
{
    public partial class Minikafe : Form
    {
        public Edit Main1 { get; set; }
        public Form1 Main { get; set; }
        public Minikafe()
        {
            InitializeComponent();
            comboBox1.Items.Add("1");
            comboBox1.Items.Add("2");
            comboBox1.Items.Add("3");
            comboBox1.SelectedItem = comboBox1.Items[0];

            comboBox2.Items.Add("1");
            comboBox2.Items.Add("2");
            comboBox2.Items.Add("3");
            comboBox2.SelectedItem = comboBox2.Items[0];

            comboBox3.Items.Add("1");
            comboBox3.Items.Add("2");
            comboBox3.Items.Add("3");
            comboBox3.SelectedItem = comboBox2.Items[0];

            comboBox4.Items.Add("1");
            comboBox4.Items.Add("2");
            comboBox4.Items.Add("3");
            comboBox4.SelectedItem = comboBox2.Items[0];


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                object obj = comboBox1.SelectedItem;
                string op = obj.ToString();
                switch (op)
                {
                    case "1":
                        textBox1.Text = "10";

                        break;
                    case "2":
                        textBox1.Text = "20";
                        break;
                    case "3":
                        textBox1.Text = "30";
                        break;

                }
            }
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked)
            {
                object obj = comboBox2.SelectedItem;
                string op = obj.ToString();
                switch (op)
                {
                    case "1":
                        textBox3.Text = "15";

                        break;
                    case "2":
                        textBox3.Text = "30";
                        break;
                    case "3":
                        textBox3.Text = "45";
                        break;

                }
            }
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(checkBox3.Checked)
            {
                object obj = comboBox3.SelectedItem;
                string op = obj.ToString();
                switch (op)
                {
                    case "1":
                        textBox5.Text = "12";

                        break;
                    case "2":
                        textBox5.Text = "24";
                        break;
                    case "3":
                        textBox5.Text = "36";
                        break;

                }
            }
            
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(checkBox4.Checked)
            {
                object obj = comboBox4.SelectedItem;
                string op = obj.ToString();
                switch (op)
                {
                    case "1":
                        textBox7.Text = "5";
                        break;
                    case "2":
                        textBox7.Text = "10";
                        break;
                    case "3":
                        textBox7.Text = "15";
                        break;

                }
            }
            
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int price = Convert.ToInt32(textBox1.Text + textBox3.Text + textBox5.Text + textBox7.Text);
            textBox9.Text = Convert.ToString(price);
        }
    }
}
