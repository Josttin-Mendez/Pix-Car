using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Racing_Game_MOO_ICT
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            SoundPlayer play = new SoundPlayer();
            play.SoundLocation = @"C:\Users\LENOVO\Downloads\Car pixel\Car pixel\Car pixel\Car Racing Game MOO ICT\Sound\Start.wav";
            play.PlayLooping();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
