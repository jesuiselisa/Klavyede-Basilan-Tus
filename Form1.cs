using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasilanTus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                lblBasilanTus.Text = "Esc";
            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
                lblBasilanTus.Text = "Enter";
            }
            else if (e.KeyChar == (char)Keys.Space)
            {
                lblBasilanTus.Text = "Space";
            }
            else if (e.KeyChar == (char)Keys.Tab)
            {
                lblBasilanTus.Text = "Tab";
            }
            else
            {
                lblBasilanTus.Text = e.KeyChar.ToString();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                lblBasilanTus.Text = e.KeyCode.ToString();
            }
        }
    }
}
