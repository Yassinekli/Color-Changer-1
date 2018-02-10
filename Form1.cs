using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        int A=255, R=0, G=0, B=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Red_Scroll(object sender, EventArgs e)
        {
            R = Red.Value;
            Color color = Color.FromArgb(A, R, G, B);
            Color_Change.BackColor = color;
        }

        private void Green_Scroll(object sender, EventArgs e)
        {
            G = Green.Value;
            Color color = Color.FromArgb(A, R, G, B);
            Color_Change.BackColor = color;
        }

        private void Blue_Scroll(object sender, EventArgs e)
        {
            B = Blue.Value;
            Color color = Color.FromArgb(A, R, G, B);
            Color_Change.BackColor = color;
        }

       
    }
}
