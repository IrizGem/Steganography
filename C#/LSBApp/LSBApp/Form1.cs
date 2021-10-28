using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSBApp
{
    public partial class FormLSBProj : Form
    {
        Bitmap clearImg;
        Graphics g;
        LSB_Maker l;

        public FormLSBProj()
        {
            InitializeComponent();
            CreateGr();
            SetDefaultCombos();
        }

        private void stripItemOpen_Click(object sender, EventArgs e)
        {
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
               Bitmap startIm = Files.Read_Image(openDialog.FileName);
               l = new LSB_Maker(startIm, boxForText.Text);
                clearImg = Files.Read_Image(openDialog.FileName);//startIm.Clone(new Rectangle(0,0,startIm.Width, startIm.Height),System.Drawing.Imaging.PixelFormat.Canonical);
            }
            
            Draw();
            SetDefaultPhrase();
        }

        private void stripItemSave_Click(object sender, EventArgs e)
        {
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                Files.Write_Image(saveDialog.FileName, l.Result);

            }
        }

        private void butForWrite_Click(object sender, EventArgs e)
        {
            if (l == null || l.Result == null)
            {
                MessageBox.Show("Изображение не открыто");
                return;
            }

            int r = int.Parse(comboBoxR.SelectedItem.ToString());
            int g = int.Parse(comboBoxG.SelectedItem.ToString());
            int b = int.Parse(comboBoxB.SelectedItem.ToString());

            string text = boxForText.Text;
            l.SetText(text);
            l.SetTails(r, g, b);
            l.Ciph();
            MessageBox.Show("Да");
            Draw();
            boxForText.Text =  "";
        }

        private void butForRead_Click(object sender, EventArgs e)
        {
            if (l == null || l.Result == null)
            {
                MessageBox.Show("Изображение не открыто");
                return;
            }
            
            int r = int.Parse(comboBoxR.SelectedItem.ToString());
            int g = int.Parse(comboBoxG.SelectedItem.ToString());
            int b = int.Parse(comboBoxB.SelectedItem.ToString());
            
            l.SetText("");
            l.SetTails(r, g, b);
            l.DeCiph();

            boxForText.Text = l.Text;
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            Draw();
        }

        private void FormLSBProj_SizeChanged(object sender, EventArgs e)
        {
            CreateGr();
        }




        private void Draw()
        {
            //some magic
            //Refresh();
            g.Clear(Color.WhiteSmoke);
            if (l!=null && l.Result!=null)
                g.DrawImage(l.Result, 0, 0, panel.Width, panel.Height);
        }

        private void CreateGr()
        {
            g = panel.CreateGraphics();
            Draw();
        }

        private void SetDefaultCombos()
        {
            comboBoxR.SelectedIndex = 2;
            comboBoxG.SelectedIndex = 2;
            comboBoxB.SelectedIndex = 2;

            SetDefaultPhrase();
        }

        private void SetDefaultPhrase()
        {
            boxForText.Text = "Mr. Darcy smiled; but Elizabeth thought she could perceive that he was rather offended, and therefore checked her laugh. Miss Bingley warmly resented the indignity he had received, in an expostulation with her brother for talking such nonsense.\n 'I see your design, Bingley,' said his friend. 'You dislike an argument, and want to silence this.'\n 'Perhaps I do. Arguments are too much like disputes. If you and Miss Bennet will defer yours till I am out of the room, I shall be very thankful; and then you may say whatever you like of me.'\n 'What you ask,' said Elizabeth, 'is no sacrifice on my side; and Mr. Darcy had much better finish his letter.'\n Mr. Darcy took her advice, and did finish his letter.\n When that business was over, he applied to Miss Bingley and Elizabeth for an indulgence of some music. Miss Bingley moved with some alacrity to the pianoforte; and, after a polite request that Elizabeth would lead the way which the other as politely and more earnestly negatived, she seated herself.\n Mrs. Hurst sang with her sister, and while they were thus employed, Elizabeth could not help observing, as she turned over some music-books that lay on the instrument, how frequently Mr. Darcy’s eyes were fixed on her. She hardly knew how to suppose that she could be an object of admiration to so great a man; and yet that he should look at her because he disliked her, was still more strange. She could only imagine, however, at last that she drew his notice because there was something more wrong and reprehensible, according to his ideas of right, than in any other person present. The supposition did not pain her. She liked him too little to care for his approbation.\n After playing some Italian songs, Miss Bingley varied the charm by a lively Scotch air; and soon afterwards Mr. Darcy, drawing near Elizabeth, said to her: 'Do not you feel a great inclination, Miss Bennet, to seize such an opportunity of dancing a reel?'\n She smiled, but made no answer. He repeated the question, with some surprise at her silence.\n 'Oh!' said she, 'I heard you before, but I could not immediately determine what to say in reply. You wanted me, I know, to say ‘Yes,’ that you might have the pleasure of despising my taste; but I always delight in overthrowing those kind of schemes, and cheating a person of their premeditated contempt. I have, therefore, made up my mind to tell you, that I do not want to dance a reel at all—and now despise me if you dare.'\n 'Indeed I do not dare.'\n Elizabeth, having rather expected to affront him, was amazed at his gallantry; but there was a mixture of sweetness and archness in her manner which made it difficult for her to affront anybody; and Darcy had never been so bewitched by any woman as he was by her. He really believed, that were it not for the inferiority of her connections, he should be in some danger.\n Miss Bingley saw, or suspected enough to be jealous; and her great anxiety for the recovery of her dear friend Jane received some assistance from her desire of getting rid of Elizabeth.\n She often tried to provoke Darcy into disliking her guest, by talking of their supposed marriage, and planning his happiness in such an alliance.\n 'I hope,' said she, as they were walking together in the shrubbery the next day, 'you will give your mother-in-law a few hints, when this desirable event takes place, as to the advantage of holding her tongue; and if you can compass it, do cure the younger girls of running after officers. And, if I may mention so delicate a subject, endeavour to check that little something, bordering on conceit and impertinence, which your lady possesses.'\n 'Have you anything else to propose for my domestic felicity?'\n 'Oh! yes. Do let the portraits of your uncle and aunt Phillips be placed in the gallery at Pemberley. Put them next to your great-uncle the judge. They are in the same profession, you know, only in different lines. As for your Elizabeth’s picture, you must not have it taken, for what painter could do justice to those beautiful eyes?'\n 'It would not be easy, indeed, to catch their expression, but their colour and shape, and the eyelashes, so remarkably fine, might be copied.'\n At that moment they were met from another walk by Mrs. Hurst and Elizabeth herself.\n 'I did not know that you intended to walk,' said Miss Bingley, in some confusion, lest they had been overheard.\n 'You used us abominably ill,' answered Mrs. Hurst, 'running away without telling us that you were coming out.'\n Then taking the disengaged arm of Mr. Darcy, she left Elizabeth to walk by herself. The path just admitted three. Mr. Darcy felt their rudeness, and immediately said:\n 'This walk is not wide enough for our party. We had better go into the avenue.'\n But Elizabeth, who had not the least inclination to remain with them, laughingly answered:\n 'No, no; stay where you are. You are charmingly grouped, and appear to uncommon advantage. The picturesque would be spoilt by admitting a fourth. Good-bye.'\n She then ran gaily off, rejoicing as she rambled about, in the hope of being at home again in a day or two. Jane was already so much recovered as to intend leaving her room for a couple of hours that evening.";
        }

        private void butForDefPhr_Click(object sender, EventArgs e)
        {
            SetDefaultPhrase();
        }

        private void GiveMetrics()
        {
            double mD = 0, MSE = 0, Lp1 = 0, Lp2 = 0, Lp3 = 0, Lp4 = 0;

            Bitmap result = l.Result;
            for (int i = 0; i < result.Width; i++)
            {
                for (int j = 0; j < result.Height; j++)
                {
                    Color c1 = clearImg.GetPixel(i, j);
                    Color c2 = result.GetPixel(i, j);

                    // определение maxD
                    double e_mD = Math.Abs((c1.R + c1.G + c1.B) / 3 - (c2.R + c2.G + c2.B) / 3);
                    mD = e_mD > mD ? e_mD : mD;

                    // определение MSE
                    MSE += Math.Pow((c1.R + c1.G + c1.B) / 3 - (c2.R + c2.G + c2.B) / 3, 2);

                    // определение Lp
                    Lp1 += Math.Pow(Math.Abs((c1.R + c1.G + c1.B) / 3 - (c2.R + c2.G + c2.B) / 3), 1);
                    Lp2 += Math.Pow(Math.Abs((c1.R + c1.G + c1.B) / 3 - (c2.R + c2.G + c2.B) / 3), 2);
                    Lp3 += Math.Pow(Math.Abs((c1.R + c1.G + c1.B) / 3 - (c2.R + c2.G + c2.B) / 3), 3);
                    Lp4 += Math.Pow(Math.Abs((c1.R + c1.G + c1.B) / 3 - (c2.R + c2.G + c2.B) / 3), 4);

                }
            }

            MSE = MSE / (result.Width * result.Height);
            Lp1 = Math.Pow(Lp2 / (result.Width * result.Height), 1 / 1);
            Lp2 = Math.Pow(Lp2 / (result.Width * result.Height), 1 / 2);
            Lp3 = Math.Pow(Lp2 / (result.Width * result.Height), 1 / 3);
            Lp4 = Math.Pow(Lp2 / (result.Width * result.Height), 1 / 4);

            box_mD.Text = mD.ToString();
            box_MSE.Text = MSE.ToString();
            box_Lp.Text = Lp1.ToString() + " " + Lp2.ToString() + " " + Lp3.ToString() + " " + Lp4.ToString();
        }

        private void butForMetrics_Click(object sender, EventArgs e)
        {

            GiveMetrics();
        }
    }
}
