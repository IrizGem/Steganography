using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageCipher
{
    public partial class Form : System.Windows.Forms.Form
    {
        Graphics g;
        Cipher c;

        public Form()
        {
            InitializeComponent();

            g = panel.CreateGraphics();
            c = new Cipher(null, BoxMess.Text);
        }

        private void butLoad_Click(object sender, EventArgs e)
        {
            BoxMess.Text = "";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                c = new Cipher(Files.Read_Image(openDialog.FileName), BoxMess.Text);
                
            }

            Drawing();
            
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                Files.Write_Image(saveDialog.FileName, c.Result);
            }
        }

        private void butCiph_Click(object sender, EventArgs e)
        {
            c.SetText(BoxMess.Text);

            if (c.Ciph())
                MessageBox.Show("<< Success >>");
            else
                MessageBox.Show("<< To small >>");

            BoxMess.Text = c.Text;

            Drawing();
        }

        private void butDeCiph_Click(object sender, EventArgs e)
        {
            BoxMess.Text = " = = = >";
            Drawing();

            c.DeCiph();
            BoxMess.Text = c.Text;
            Drawing();
        }

        private void Drawing()
        {
            //Refresh();

            g.Clear(Color.WhiteSmoke);
            g.DrawImage(c.Result, 0, 0, panel.Width, panel.Height);
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            Drawing();
        }

        private void Form_SizeChanged(object sender, EventArgs e)
        {
            Drawing();
        }
    }
}
