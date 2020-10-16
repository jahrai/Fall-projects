using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatinTranslator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "Right";
            lblOutput.Left = 240;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblOutput.Text = "Left";
            lblOutput.Left = 50;    
        }

        private void btnLatinMedium_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "Center";
            lblOutput.Left = (this.ClientSize.Width -lblOutput.Width) / 2;
        }
    }
}
