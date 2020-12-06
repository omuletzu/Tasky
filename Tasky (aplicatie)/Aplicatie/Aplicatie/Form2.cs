using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicatie
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            panel4.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            label1.Text = Properties.Settings.Default.username;
            timer1.Start();
            pictureBox1.BorderStyle = BorderStyle.None;
            pictureBox2.BorderStyle = BorderStyle.None;
            label4.Text = Properties.Settings.Default.username;
            label5.Text = Properties.Settings.Default.streak.ToString();

            Random rnd = new Random();                  //randomizer for choosing the activity
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to quit?", "Aplicatie", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.label2.Text = datetime.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        bool ok = false;
        private void button6_Click(object sender, EventArgs e)
        {
            ok = true;
            panel5.Hide();
            panel4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ok == false)
            {
                panel4.Hide();
                panel5.Hide();
                panel2.Show();
            }
            else
            {
                panel5.Hide();
                panel4.Show();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            ok = false;
            panel4.Hide();
            panel2.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ok = false;
            panel4.Hide();
            panel2.Show();
        }
        
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            label5.Show();
            label6.Show();
            panel7.Hide();
            panel2.Show();
            panel4.Show();
            panel5.Show();
            panel6.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel6.Hide();
            panel7.Hide();
            panel2.Show();
            panel4.Show();
            panel5.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
           
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label5.Hide();
            label6.Hide();
            panel2.Show();
            panel4.Show();
            panel5.Show();
            panel6.Show();
            panel7.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
