using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Game g;
        public Form1()
        { 
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = new Game();
            Form2 forma2 = new Form2(g);
            forma2.ShowDialog();
            listBox1.DataSource = new BindingSource(g.YourTeam, null);
            g.AddEnemy(new Monster("Смертокрыл"));
            g.AddEnemy(new Monster("Таурисан"));
            g.AddEnemy(new Monster("Иллидан"));
            listBox2.DataSource = new BindingSource(g.EnemyTeam, null);
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hero hero = (Hero)listBox1.SelectedItem;
            richTextBox3.Text = String.Format(" HP: {0}\n Урон: {1}\n Класс: {2}", hero.HP, hero.strong, hero.name);
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //richTextBox1.Text = 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hero hero1 = (Hero)listBox1.SelectedItem;
            Hero hero2 = (Hero)listBox2.SelectedItem;
            g.Attack(hero1,hero2);
            listBox2.DataSource = new BindingSource(g.EnemyTeam, null);
            listBox1.DataSource = new BindingSource(g.YourTeam, null);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hero hero = (Hero)listBox2.SelectedItem;
            richTextBox2.Text = String.Format(" HP: {0}\n Урон: {1}\n Класс: {2}", hero.HP, hero.strong, hero.name);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            using(Stream streanm = File.Open("team.bin", FileMode.Create))
            {
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(streanm, g.YourTeam);
            }
            using(Stream streanm = File.Open("team2.bin", FileMode.Create))
            {
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(streanm, g.EnemyTeam);
            }
        }
    }
}
