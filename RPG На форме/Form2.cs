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
    public partial class Form2 : Form
    {
        Game Igra1;
        public Form2(Game Igra)
        {
            InitializeComponent();
            Igra1 = Igra;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = new BindingSource(Igra1.YourTeam, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Igra1.AddPersonage(new Warrior("Гаррош"));
            listBox1.DataSource = new BindingSource(Igra1.YourTeam, null);
            if (numericUpDown1.Value == 3)
            {
                MessageBox.Show("Это твоя команда", "ВНИМАНИЕ", MessageBoxButtons.YesNo);
            }
            if (Igra1.YourTeam.Count == 3)
            {

                DialogResult dialog = MessageBox.Show("Это твоя команда", "ВНИМАНИЕ", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    this.Close();
                }
                if (dialog == DialogResult.No)
                {

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Igra1.AddPersonage(new Mage("Медив"));
            listBox1.DataSource = new BindingSource(Igra1.YourTeam, null);
            if (Igra1.YourTeam.Count == 3)
            {
                
                DialogResult dialog = MessageBox.Show("Это твоя команда", "ВНИМАНИЕ", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    this.Close();
                }
                if (dialog == DialogResult.No)
                {

                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Igra1.AddPersonage(new Healer("Андуин"));
            listBox1.DataSource = new BindingSource(Igra1.YourTeam, null);
            if (numericUpDown1.Value == 3)
            {
                MessageBox.Show("Это твоя команда", "ВНИМАНИЕ", MessageBoxButtons.YesNo);
            }
            if (Igra1.YourTeam.Count == 3)
            {

                DialogResult dialog = MessageBox.Show("Это твоя команда", "ВНИМАНИЕ", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    this.Close();
                }
                if (dialog == DialogResult.No)
                {

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SizeChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
