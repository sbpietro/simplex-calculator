using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplexCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnProx_Click(object sender, EventArgs e)
        {
            Global.QtdeRestricoes = Convert.ToInt32(this.NumRest.Text);
            Global.QtdeVariaveisDecisao = Convert.ToInt32(this.NumVarDec.Text);
            var f2 = new Form2();
            f2.ShowDialog();
            //this.Hide();
        }
    }
}
