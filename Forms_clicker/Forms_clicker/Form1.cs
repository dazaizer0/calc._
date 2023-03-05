using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_clicker
{
    public partial class Form1 : Form
    {
        public int score = 0;

        private void startBox(Label label, string text, Color color)
        {
            label.BackColor = color;
            label.Visible = true;
            label.Enabled = true;
            label1.Text = score.ToString();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            score += 1;
            // MessageBox.Show("clicked");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            score += 1;
        }
    }
}
