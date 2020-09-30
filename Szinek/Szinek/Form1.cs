using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szinek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Hatterszin_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog()!=System.Windows.Forms.DialogResult.Cancel)
            {
                textBox_Hatter.BackColor = colorDialog1.Color;
                textBox_Szoveg.BackColor = colorDialog1.Color;
                
            }
        }

        private void Szovegszin_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog()!=System.Windows.Forms.DialogResult.Cancel)
            {
                textBox_Szoveg.ForeColor = colorDialog1.Color;
                textBox_Hatter.ForeColor = colorDialog1.Color;
            }
        }
    }
}
