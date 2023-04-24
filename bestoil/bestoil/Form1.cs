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
    public partial class Form1 : Form
    {
        BestOil bestoil;
        Minikafe kafe;
        Edit edit;
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            bestoil = new BestOil(); 
            bestoil.Main = this;
            bestoil.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kafe = new Minikafe();
            kafe.Main = this;
            kafe.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            edit = new Edit();
            edit.Main = this;
            edit.ShowDialog();
        }
    }
}
