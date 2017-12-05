using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChiTieu
{
    public static class Helper
    {
        public static List<ChiTieu> ChiTieus = new List<ChiTieu>();

        public static void LoadDanhSach(string FileName)
        {
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(FileName))
                {
                    sr.ReadLine();
                }
            }
            catch
            {
            }
        }

        public static void SaveDanhSach(string FileName)
        {
            try
            {
                using (StreamWriter sr = new StreamWriter(FileName))
                {
                    int n = 0;

                    sr.WriteLine(n.ToString());
                }
            }
            catch 
            {
            }
        }

    }
}
