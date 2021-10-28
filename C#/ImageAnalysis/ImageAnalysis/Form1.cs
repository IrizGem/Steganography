using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageAnalysis
{
    public partial class Form : System.Windows.Forms.Form
    {
        private Graphics g1, g2;
        private Analysator a;

        public Form()
        {
            InitializeComponent();

            RGB_Box.Text = "B";
            Lay_Box.Text = "1";

            g1 = panel_1st_pic.CreateGraphics();
            g2 = panel_2nd_pic.CreateGraphics();
            a = new Analysator();
            Drawing();
        }

        private void Drawing()
        {
            if (radButPic.Checked)
            {
                g1.DrawImage(a.FirstBit, 0, 0, panel_1st_pic.Width, panel_1st_pic.Height);

                if (checkBox.Checked)
                    g2.DrawImage(a.DifBit, 0, 0, panel_2nd_pic.Width, panel_2nd_pic.Height);
                else
                    g2.DrawImage(a.SecondBit, 0, 0, panel_2nd_pic.Width, panel_2nd_pic.Height);
            }
            else if (radButTail.Checked)
            {
                g1.DrawImage(a.FirstTailsBit, 0, 0, panel_1st_pic.Width, panel_1st_pic.Height);
                g2.DrawImage(a.SecondTailsBit, 0, 0, panel_2nd_pic.Width, panel_2nd_pic.Height);
            }
        }

        private void but_Next_Click(object sender, EventArgs e)
        {
            radButPic.Checked = true;
            checkBox.Checked = false;


            RGB_Box.Text = "B";
            Lay_Box.Text = "1";

            a.ChangePic(1);
            Drawing();
        }

        private void butPre_Click(object sender, EventArgs e)
        {
            radButPic.Checked = true;
            checkBox.Checked = false;

            RGB_Box.Text = "B";
            Lay_Box.Text = "1";

            a.ChangePic(-1);
            Drawing();
        }

        private void radButPic_CheckedChanged(object sender, EventArgs e)
        {
            checkBox.Checked = false;
            
        }

        private void radButTail_CheckedChanged(object sender, EventArgs e)
        {
            checkBox.Checked = false;
            Drawing();
        }

        private void Form_Paint(object sender, PaintEventArgs e)
        {
            Drawing();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            g2.Clear(Color.Aqua);
            Drawing();
        }

        private void butRenew_Click(object sender, EventArgs e)
        {
            int pow = 1;
            int.TryParse(Lay_Box.Text, out pow);
            a.DoTails(RGB_Box.Text[0], pow);
            Drawing();
        }

        
    }
}
