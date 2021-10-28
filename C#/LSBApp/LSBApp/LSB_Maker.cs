using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace LSBApp
{
    class LSB_Maker
    {
        private int r_tail, g_tail, b_tail;
        private List<byte> bytes;
        private List<bool> bits;
        private Bitmap bitmap;
        private string text;

        public Bitmap Result { get { return bitmap; } }
        public string Text { get { return text; } }

        public LSB_Maker(Bitmap bit)
        {
            bitmap = bit;
            text = "";
            r_tail = 0;
            g_tail = 0;
            b_tail = 0;
        }

        public LSB_Maker(Bitmap bit, string text)
        {
            bitmap = bit;
            SetText(text);
            r_tail = 0;
            g_tail = 0;
            b_tail = 0;
        }

        public void SetText(string text)
        {
            this.text = text;
        }

        public void SetTails(int r, int g, int b)
        {
            r_tail = r;
            g_tail = g;
            b_tail = b;
        }

        public bool Ciph()
        {
            string text_ = "";
            bytes = new List<byte>();

            for (int i = 0; i < text.Length; i++)
            {
                bytes.Add((byte)text[i]);
                text_ += bytes[i].ToString() + " ";
            }
            
            bits = new List<bool>();
            for (int i = 0; i < bytes.Count; i++) // по символам в тексте
            {
                for (int j = 7; j >= 0; j--) // по битам в коде символа
                {
                    bool n = ((bytes[i] >> j) % 2) != 0;
                    bits.Add(n);
                }
            }


            int m = 0;
            char col = 'r';

            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color curPix = bitmap.GetPixel(i, j);
                    int R = curPix.R;
                    int G = curPix.G;
                    int B = curPix.B;

                    for (int a = 0; a <= 2; a++)
                    {
                        switch (col)
                        {
                            case 'r':
                                for (int k = r_tail - 1; k >= 0; k--)
                                {
                                    if (m >= bits.Count)
                                        break;
                                    R = (R >> k) / 2 * 2;
                                    R += bits[m] ? 1 : 0;
                                    R = R << k;
                                    m++;
                                }

                                col = 'g';
                                break;

                            case 'g':
                                for (int k = g_tail - 1; k >= 0; k--)
                                {
                                    if (m >= bits.Count)
                                        break;
                                    G = (G >> k) / 2 * 2;
                                    G += bits[m] ? 1 : 0;
                                    G = G << k;
                                    m++;
                                }
                                col = 'b';
                                break;

                            case 'b':
                                for (int k = b_tail - 1; k >= 0; k--)
                                {
                                    if (m >= bits.Count)
                                        break;
                                    B = (B >> k) / 2 * 2;
                                    B += bits[m] ? 1 : 0;
                                    B = B << k;
                                    m++;
                                }
                                col = 'r';
                                break;
                        }
                    }
                    bitmap.SetPixel(i, j, Color.FromArgb(R, G, B));
                    //bitmap.SetPixel(i, j, Color.White);
                    if (m >= bits.Count)
                        break;
                }
            }

            text = text_;

            return true;
        }

        public void DeCiph()
        {
            bits = new List<bool>();
            bytes = new List<byte>();
            text = "";

            // расшифровка информации из пикселей в биты
            char col = 'r';
            
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color curPix = bitmap.GetPixel(i, j);
                    int R = curPix.R;
                    int G = curPix.G;
                    int B = curPix.B;

                    for (int a = 0; a <= 2; a++)
                    {
                        switch (col)
                        {
                            case 'r':
                                for (int k = r_tail - 1; k >= 0; k--)
                                {
                                    bool m = ((R >> (k)) % 2) > 0;
                                    bits.Add(m);
                                }

                                col = 'g';
                                break;

                            case 'g':
                                for (int k = g_tail - 1; k >= 0; k--)
                                {

                                    bool m = ((G >> (k)) % 2) > 0;
                                    bits.Add(m);
                                }
                                col = 'b';
                                break;

                            case 'b':
                                for (int k = b_tail - 1; k >= 0; k--)
                                {

                                    bool m = ((B >> (k)) % 2) > 0;
                                    bits.Add(m);
                                }
                                col = 'r';
                                break;
                        }
                    }
                }
            }

            //перепись битов в байты и в символы
            byte l = 0;
            int n = 0;
            for (int i = 0; i < bits.Count; i++)
            {
                l = (byte)(l << 1);
                l += bits[i] ? (byte)1 : (byte)0;
                n++;
                if (n >= 8)
                {
                    bytes.Add(l);
                    text += (char)l;
                    l = 0;
                    n = 0;
                }
            }



        }
    }
}
