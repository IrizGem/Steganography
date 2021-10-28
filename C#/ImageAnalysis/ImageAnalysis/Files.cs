using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace ImageAnalysis
{
    public static class Files
    {
        public static string dir = Environment.CurrentDirectory + "\\images\\";
        public static string[] ims = { "0001.jpg", "0002.jpg", "0003.jpg", "0004.jpg", "0005.bmp", "0006.bmp", "0007.bmp", "0008.bmp", "0009.bmp", "0010.bmp" };

        public static void Read_Pair_Images(int indPair, out Bitmap b1, out Bitmap b2)
        {
            b1 = Read_Image(dir + ims[indPair * 2]);
            b2 = Read_Image(dir + ims[indPair * 2 + 1]);
        }

        private static Bitmap Read_Image(string name)
        {
            Bitmap bit = (Bitmap)Image.FromFile(name);
            return bit;
        }

        //public static string Read_String(string input_file)
        //{
        //    FileStream f_st = new FileStream(input_file, FileMode.Open);
        //    StreamReader reader = new StreamReader(f_st);
        //    string file_str = reader.ReadToEnd();
        //    f_st.Close();
        //    return file_str;
        //}

        //public static void WriteString(string input_file, string text)
        //{
        //    FileStream f_st = new FileStream(input_file, FileMode.Open);
        //    StreamWriter writer = new StreamWriter(f_st);
        //    writer.Write(text);
        //    f_st.Close();
        //}
        
    }
}

