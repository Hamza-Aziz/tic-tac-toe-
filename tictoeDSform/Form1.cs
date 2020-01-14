using CalculatriceDSRemotingTrue;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictoeDSform
{
    public partial class Form1 : Form
    {
        Jeu proxy;
        String[,] ta;
        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RemotingConfiguration.RegisterActivatedClientType(typeof(Jeu), "tcp://localhost:255/nomService");
           
            proxy = new Jeu();
            ta = new String[,] { { button11.Text, button12.Text, button13.Text }, { button21.Text, button22.Text, button23.Text }, { button31.Text, button32.Text, button33.Text } };
            proxy.initialiser(ta);

            textBox1.Text = proxy.j;
        }

        private void button11_Click(object sender, EventArgs e)
        {
           
           
            proxy.jouer();
            button11.Text = proxy.v;
            textBox1.Text = proxy.j;
            button11.Enabled = false;
            ta = new String[,] { { button11.Text, button12.Text, button13.Text }, { button21.Text, button22.Text, button23.Text }, { button31.Text, button32.Text, button33.Text } };
            proxy.initialiser(ta);
            if (proxy.gagner())
            {
                if(proxy.j == proxy.J1)
                    MessageBox.Show(proxy.J2 + "est gagne");
                else
                    MessageBox.Show(proxy.J1 + "est gagne");
                actualiser();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
            proxy.jouer();
            button12.Text = proxy.v;
            textBox1.Text = proxy.j;
            button12.Enabled = false;
            ta = new String[,] { { button11.Text, button12.Text, button13.Text }, { button21.Text, button22.Text, button23.Text }, { button31.Text, button32.Text, button33.Text } };
            proxy.initialiser(ta);
            if (proxy.gagner())
            {
                if (proxy.j == proxy.J1)
                    MessageBox.Show(proxy.J2 + "est gagne");
                else
                    MessageBox.Show(proxy.J1 + "est gagne");
                actualiser();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            proxy.jouer();
            button13.Text = proxy.v;
            textBox1.Text = proxy.j;
            button13.Enabled = false;
            ta = new String[,] { { button11.Text, button12.Text, button13.Text }, { button21.Text, button22.Text, button23.Text }, { button31.Text, button32.Text, button33.Text } };
            proxy.initialiser(ta);
            if (proxy.gagner())
            {
                if (proxy.j == proxy.J1)
                    MessageBox.Show(proxy.J2 + "est gagne");
                else
                    MessageBox.Show(proxy.J1 + "est gagne");
                actualiser();
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            proxy.jouer();
            button21.Text = proxy.v;
            textBox1.Text = proxy.j;
            button21.Enabled = false;
            ta = new String[,] { { button11.Text, button12.Text, button13.Text }, { button21.Text, button22.Text, button23.Text }, { button31.Text, button32.Text, button33.Text } };
            if (proxy.gagner())
            {
                if (proxy.j == proxy.J1)
                    MessageBox.Show(proxy.J2 + "est gagne");
                else
                    MessageBox.Show(proxy.J1 + "est gagne");
                actualiser();
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            proxy.jouer();
            button22.Text = proxy.v;
            textBox1.Text = proxy.j;
            button22.Enabled = false;
            ta = new String[,] { { button11.Text, button12.Text, button13.Text }, { button21.Text, button22.Text, button23.Text }, { button31.Text, button32.Text, button33.Text } };
            proxy.initialiser(ta);
            if (proxy.gagner())
            {
                if (proxy.j == proxy.J1)
                    MessageBox.Show(proxy.J2 + "est gagne");
                else
                    MessageBox.Show(proxy.J1 + "est gagne");
                actualiser();
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            proxy.jouer();
            button23.Text = proxy.v;
            textBox1.Text = proxy.j;
            button23.Enabled = false;
            ta = new String[,] { { button11.Text, button12.Text, button13.Text }, { button21.Text, button22.Text, button23.Text }, { button31.Text, button32.Text, button33.Text } };
            proxy.initialiser(ta);
            if (proxy.gagner())
            {
                if (proxy.j == proxy.J1)
                    MessageBox.Show(proxy.J2 + "est gagne");
                else
                    MessageBox.Show(proxy.J1 + "est gagne");
                actualiser();
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            proxy.jouer();
            button31.Text = proxy.v;
            textBox1.Text = proxy.j;
            button31.Enabled = false;
            ta = new String[,] { { button11.Text, button12.Text, button13.Text }, { button21.Text, button22.Text, button23.Text }, { button31.Text, button32.Text, button33.Text } };
            proxy.initialiser(ta);
            if (proxy.gagner())
            {
                if (proxy.j == proxy.J1)
                    MessageBox.Show(proxy.J2 + "est gagne");
                else
                    MessageBox.Show(proxy.J1 + "est gagne");
                actualiser();
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            proxy.jouer();
            button32.Text = proxy.v;
            textBox1.Text = proxy.j;
            button32.Enabled = false;
            ta = new String[,] { { button11.Text, button12.Text, button13.Text }, { button21.Text, button22.Text, button23.Text }, { button31.Text, button32.Text, button33.Text } };
            proxy.initialiser(ta);
            if (proxy.gagner())
            {
                if (proxy.j == proxy.J1)
                    MessageBox.Show(proxy.J2 + "est gagne");
                else
                    MessageBox.Show(proxy.J1 + "est gagne");
                actualiser();
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            proxy.jouer();
            button33.Text = proxy.v;
            textBox1.Text = proxy.j;
            button33.Enabled = false;
            ta = new String[,] { { button11.Text, button12.Text, button13.Text }, { button21.Text, button22.Text, button23.Text }, { button31.Text, button32.Text, button33.Text } };
            proxy.initialiser(ta);
            if (proxy.gagner())
            {
                if (proxy.j == proxy.J1)
                    MessageBox.Show(proxy.J2 + "est gagne");
                else
                    MessageBox.Show(proxy.J1 + "est gagne");
                actualiser();
            }
        }
        public void actualiser()
        {
            button11.Text = "";
            button11.Enabled = true;
            button12.Text = "";
            button12.Enabled = true;
            button13.Text = "";
            button13.Enabled = true;
            button21.Text = "";
            button21.Enabled = true;
            button22.Text = "";
            button22.Enabled = true;
            button23.Text = "";
            button23.Enabled = true;
            button31.Text = "";
            button31.Enabled = true;
            button32.Text = "";
            button32.Enabled = true;
            button33.Text = "";
            button33.Enabled = true;
        }
    }
}
