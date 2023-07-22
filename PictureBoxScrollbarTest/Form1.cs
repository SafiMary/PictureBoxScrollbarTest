using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PictureBoxScrollbarTest
{
    public partial class Form1 : Form
    {
        Size StartSize;
        Size StartSize2;
        public Form1()
        {
            InitializeComponent();
          
            hScrollBar1.Scroll += new ScrollEventHandler(hScrollBar1_Scroll);
            vScrollBar1.Scroll += new ScrollEventHandler(vScrollBar1_Scroll);
            trackBar1.Scroll += trackBar1_Scroll;
            StartSize = pictureBox1.Size;
            StartSize2 = pictureBox2.Size;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Tag = pictureBox1.Bounds;
            pictureBox2.Tag = pictureBox2.Bounds;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            vScrollBar1.Minimum = 0;
            vScrollBar1.Maximum = 120;
            textBox1.Location = new Point(textBox1.Location.X,
                vScrollBar1.Value + 10);

            textBox1.Text = $"{textBox1.Location.X} : {textBox1.Location.Y}";
        }
       
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            
            hScrollBar1.Minimum = 0;
            hScrollBar1.Maximum = 100;
            textBox1.Location = new Point(textBox1.Location.Y,
                hScrollBar1.Value+10);
            textBox1.Text = $"{textBox1.Location.X} : {textBox1.Location.Y}";
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pictureBox1.Width = StartSize.Width * trackBar1.Value;
            pictureBox1.Height = StartSize.Height * trackBar1.Value;
       
        }
        private void trackBar2_Scroll(object sender, EventArgs e)
        {   
            pictureBox2.Width = StartSize.Width * trackBar2.Value;
            pictureBox2.Height = StartSize.Height * trackBar2.Value;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

       
    }
}
