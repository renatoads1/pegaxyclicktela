using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pegaxymouse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

 
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            lbl_coordenadas.Text = "x = " + e.X + " y = " + e.Y;
        }

        private void Form1_MouseClick_1(object sender, MouseEventArgs e)
        {
            lbl_coordenadas.Text = "x = " + e.X + " y = " + e.Y;
        }
    }
}
