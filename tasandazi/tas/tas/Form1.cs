using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tas
{
    public partial class frmtas : Form
    {
        public frmtas()
        {
            InitializeComponent();
        }

        private void btntas_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int p = r.Next(1, 7);

            if(p==1)
            {
                pcdtas.Image=Image.FromFile(Application.StartupPath+"/tas/1.png");
            }
            else if (p == 2)
            {
                pcdtas.Image = Image.FromFile(Application.StartupPath + "/tas/2.png");
            }
            else if (p == 3)
            {
                pcdtas.Image = Image.FromFile(Application.StartupPath + "/tas/3.png");
            }
            else if (p == 4)
            {
                pcdtas.Image = Image.FromFile(Application.StartupPath + "/tas/4.png");
            }
            else if (p == 5)
            {
                pcdtas.Image = Image.FromFile(Application.StartupPath + "/tas/5.png");
            }
            else if (p == 6)
            {
                pcdtas.Image = Image.FromFile(Application.StartupPath + "/tas/6.png");
            }


        }

        private void btntas_MouseEnter(object sender, EventArgs e)
        {
            lblhelp.Text = "با کلیک روی این باتن تاس بنداز";
        }

        private void btntas_MouseLeave(object sender, EventArgs e)
        {
            lblhelp.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frm2 f = new frm2();
            f.ShowDialog();
        }

        private void frmtas_Load(object sender, EventArgs e)
        {
            MessageBox.Show("خوش آمدید","برنامه تاس اندازی");
        }
    }
}
