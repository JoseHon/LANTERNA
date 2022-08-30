using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LANTERNA
{
    public partial class Form1 : Form
    {
        Bateria b = new Bateria();
        Lanterna l = new Lanterna();
        public Form1()
        {
            InitializeComponent();
            Ligada.Hide();
            Pb2.Visible = false;
            Pb3.Visible = false;
            b.bstatus = 100;
        }
        private void LigaDesliga_Click(object sender, EventArgs e)
        {
            if (l.lstatus == Lstatus.Ligado)
            {
                l.lstatus = Lstatus.Desligado;
                Ligada.Hide();
                Ldesligada.Show();
                timer1.Stop();
            }
            else
            {
                if (b.bstatus != 0)
                {
                    l.lstatus = Lstatus.Ligado;
                    Ligada.Show();
                    Ldesligada.Hide();
                    timer1.Start();
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (l.lstatus == Lstatus.Ligado)
            {
                b.bstatus -= 1;
                lbstatus.Text = b.bstatus.ToString();
            }
            else
                timer1.Stop();

            if (b.bstatus == 0)
            {
                Pb3.Visible = true;
                Pb2.Visible = false;
                Ligada.Hide();
                Ldesligada.Show();
                timer1.Stop();
                l.lstatus = Lstatus.Desligado;
            }
            else
            if (b.bstatus < 80)
            {
                Pb2.Visible = true;
                Pb1.Visible = false;
                Ligada.Show();
                Ldesligada.Hide();
            }
            else
            {
                Pb1.Visible = true;
                Pb3.Visible = false;
                Ligada.Show();
                Ldesligada.Hide();
            }

        }
        private void Trocar_Click(object sender, EventArgs e)
        {
            b.bstatus = 100; 
            lbstatus.Text = b.bstatus.ToString();
            Pb1.Visible = true;
            Pb2.Visible = false;
            Pb3.Visible = false;
        }
    }
}

