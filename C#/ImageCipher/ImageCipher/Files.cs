using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace ImageCipher
{
    public static class Files
    {

        public static Bitmap Read_Image(string name)
        {
            Bitmap bit = (Bitmap)Image.FromFile(name);
            return bit;
        }

        public static void Write_Image(string name, Bitmap bit)
        {
            bit.Save(name, System.Drawing.Imaging.ImageFormat.Png);
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
