using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void render_Click(object sender, EventArgs e)
        {
            System.Drawing.Graphics g = e.Graphics;
           
            g.DrawEllipse(System.Drawing.Pens.Red, 125, 150, 2, 2);
            
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
