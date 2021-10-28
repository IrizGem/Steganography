using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ImageCipher
{
    class Cipher
    {
        private List<byte> bits;

        private Bitmap bitmap;
        private string text;

        public Bitmap Result { get { if (bitmap == null) return new Bitmap(100,100); else return bitmap; } }
        public string Text { get { return text; } }

        public Cipher(Bitmap bit)
        {
            bitmap = bit;
            text = "";
        }

        public Cipher(Bitmap bit, string text)
        {
            bitmap = bit;
            this.text = text;
        }

        public void SetText(string text)
        {
            this.text = text;
        }

        public bool Ciph()
        {
            string text_ = "";

            bits = new List<byte>(); 
            for (int i = 0; i < text.Length; i++)
            {
                bits.Add((byte)text[i]);
                text_ += bits[i].ToString() + " ";
            }

            //text = text_;
            text = "";

            //string text_ = "";

            //List<byte> bits = new List<byte>(); 
            //for (int i = 0; i < text.Length; i++)
            //{
            //    bits.Add((byte)text[i]);
            //    //text_ += bits[i].ToString();
            //}

            int m = 0, n = 0;

            for (int i = 0; i < bits.Count; i++) // по символам
            {
                for (int j = 7; j >= 0; j--) // по битам в коде символа
                {
                    Color col = bitmap.GetPixel(m, n);

                    if (col.B % 2 != (bits[i] >> j) % 2)
                    {
                        col = Color.FromArgb(col.R, col.G, (col.B / 2 * 2) + (bits[i] >> j) % 2);
                        //col = Color.Pink; // Color.FromArgb(col.B, col.B, col.B);
                        bitmap.SetPixel(m, n, col);
                    }

                    //text += bitmap.GetPixel(m, n).B.ToString(); // col.B.ToString() + " "; 

                    m++;
                    if (m >= bitmap.Width)
                    {
                        m = 0;
                        n++;
                        if (n >= bitmap.Height && i >= bits.Count)
                            return false;
                    }
                }
            }

            return true;
        }

        public void DeCiph()
        {
            //text = "";
            
            //for (int i = 0; i < bits.Count; i++)
            //{
            //    text += (char)bits[i];
            //}

            List<byte> bits = new List<byte>();
            text = "";

            int lenb = 7;
            byte b = 0;

            for (int i = 0; i < bitmap.Height; i++)
            {
                for (int j = 0; j < bitmap.Width; j++)
                {
                    Color col = bitmap.GetPixel(j, i);

                    //text += col.B.ToString() + " ";

                    b += (byte)((col.B % 2) << lenb);
                    lenb--;

                    if (lenb < 0)
                    {
                        bits.Add(b);
                        text += (char)b;
                        //text += b.ToString();

                        lenb = 7;
                        b = 0;
                    }
                }
            }


        }
    }
}
