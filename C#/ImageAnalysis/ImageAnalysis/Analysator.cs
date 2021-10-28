using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ImageAnalysis
{
    public class Analysator
    {
        private const int countFiles = 5;
        private int numPair = 0;

        private Bitmap bitLeft;
        private Bitmap bitRight;
        private Bitmap bitDifs;
        private Bitmap bitFirstTails;
        private Bitmap bitSecondTails;

        public Bitmap FirstBit { get { return bitLeft; } }
        public Bitmap SecondBit { get { return bitRight; } }
        public Bitmap DifBit { get { return bitDifs; } }
        public Bitmap FirstTailsBit { get { return bitFirstTails; } }
        public Bitmap SecondTailsBit { get { return bitSecondTails; } }

        public Analysator()
        {
            numPair = 2;
            Reload();
        }

        public void ChangePic(int sw)
        {
            numPair = (numPair + sw + countFiles) % countFiles;
            Reload();
        }

        private void Reload()
        {
            Files.Read_Pair_Images(numPair, out bitLeft, out bitRight);
            CompareBits();
            DoTails('B', 1);
        }

        private void CompareBits()
        {
            bitDifs = bitLeft.Clone() as Bitmap;

            if (bitLeft.Width != bitRight.Width || bitLeft.Height != bitRight.Height)
                return;

            for (int i = 0; i < bitLeft.Width; i++)
            {
                for (int j = 0; j < bitLeft.Height; j++)
                {
                    Color cL = bitLeft.GetPixel(i, j);
                    Color cR = bitRight.GetPixel(i, j);

                    if (cL!=cR)
                        bitDifs.SetPixel(i, j, Color.FromArgb(0,0,255));
                }
            }
            
        }

        public void DoTails(char rgb, int pow)
        {
            bitFirstTails = new Bitmap(bitLeft.Width, bitLeft.Height);
            bitSecondTails = new Bitmap(bitRight.Width, bitRight.Height);

            if (bitLeft.Width != bitRight.Width || bitLeft.Height != bitRight.Height || !"RGBrgb".Contains(rgb))
                return;

            for (int i = 0; i < bitLeft.Width; i++)
            {
                for (int j = 0; j < bitLeft.Height; j++)
                {
                    Color cL = bitLeft.GetPixel(i, j);
                    Color cR = bitRight.GetPixel(i, j);

                    byte coL = 0;
                    byte coR = 0;

                    switch (rgb) {
                        case 'R':
                            coL = cL.R;
                            coR = cR.R;
                            break;
                        case 'G':
                            coL = cL.G;
                            coR = cR.G;
                            break;
                        case 'B':
                            coL = cL.B;
                            coR = cR.B;
                            break;
                    }

                    int L = (coL / (int) Math.Pow(2, pow-1)) - (coL / (int)Math.Pow(2, pow)) * 2;
                    int R = (coR / (int)Math.Pow(2, pow - 1)) - (coR / (int)Math.Pow(2, pow)) * 2;

                    Color ncL = Color.FromArgb(255 * L, 255 * L, 255 * L);
                    Color ncR = Color.FromArgb(255 * R, 255 * R, 255 * R);

                    bitFirstTails.SetPixel(i, j, ncL);
                    bitSecondTails.SetPixel(i, j, ncR);
                    //bitDifs.SetPixel(i, j, Color.FromArgb(0, 0, 255));
                }
            }
        }
    }
}
