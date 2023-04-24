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
    public partial class Edit : Form
    {
        public Form1 Main { get; set; }
        BestOil bestoil;
        Minikafe kafe;
        public Edit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bestoil = new BestOil();
            bestoil.Main1 = this;
            bestoil.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kafe = new Minikafe();
            kafe.Main1 = this;
            kafe.ShowDialog();
        }
    }
}
