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
    public partial class BestOil : Form
    {
        public Edit Main1 { get; set; }
        public Form1 Main { get; set; }
        public BestOil()
        {
            InitializeComponent();
            comboBox1.Items.Add("A-95");
            comboBox1.Items.Add("A-92");
            comboBox1.SelectedItem = comboBox1.Items[0];

            comboBox2.Items.Add("10 литров");
            comboBox2.Items.Add("20 литров");
            comboBox2.Items.Add("30 литров");
            comboBox2.SelectedItem = comboBox2.Items[0];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            object obj = comboBox1.SelectedItem;
            string op = obj.ToString();
            switch (op)
            {
                case "A-95":
                    textBox1.Text = "40 uah";

                    break;
                case "A-92":
                    textBox1.Text = "45 uah";
                    break;
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex==0)
            {
                object o = comboBox2.SelectedItem;
                string op2 = o.ToString();
                switch (op2)
                {
                    case "10 литров":
                        textBox3.Text = "400 гривен";
                        textBox4.Text = "400 гривен";
                        break;
                    case "20 литров":
                        textBox3.Text = "800 гривен";
                        textBox4.Text = "800 гривен";
                        break;
                    case "30 литров":
                        textBox3.Text = "1200 гривен";
                        textBox4.Text = "1200 гривен";
                        break;
                }
            }
            else if(comboBox1.SelectedIndex==1)
            {
                object o1 = comboBox2.SelectedItem;
                string op3 = o1.ToString();
                switch(op3)
                {
                    case "10 литров":
                        textBox3.Text = "450 гривен";
                        textBox4.Text = "450 гривен";
                        break;
                    case "20 литров":
                        textBox3.Text = "900 гривен";
                        textBox4.Text = "900 гривен";
                        break;
                    case "30 литров":
                        textBox3.Text = "1350 гривен";
                        textBox4.Text = "1350 гривен";
                        break;
                }
            }
            
        }

    }
}
