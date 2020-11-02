using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CmdTest.Location = new Point(
            CmdTest.Location.X + 20, CmdTest.Location.Y);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CmdTest.Location = new Point(100, 200);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CmdTest.Size = new Size(
            CmdTest.Size.Width + 20, CmdTest.Size.Height);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CmdTest.Size = new Size(50, 100);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LblAnzeige.Text = "Position: X: " + CmdTest.Location.X +
", Y: " + CmdTest.Location.Y + "\n" + "Größe: Breite: " +
          CmdTest.Size.Width + ", Höhe: " + CmdTest.Size.Height;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BackColor = Color.Yellow;
            LblAnzeige.BackColor = Color.FromArgb(192, 255, 0);
        }
    }
}
