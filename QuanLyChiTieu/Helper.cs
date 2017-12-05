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
            ChiTieus = new List<ChiTieu>();
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(FileName))
                {
                    int n;
                    n = Int32.Parse(sr.ReadLine());

                    for(int i=0; i<n; i++)
                    {
                        ChiTieu item = new ChiTieu();
                        item.LoaiChiTieu = Int32.Parse(sr.ReadLine());
                        item.SoTien = Int32.Parse(sr.ReadLine());
                        item.NoiDung = sr.ReadLine();
                        ChiTieus.Add(item);
                    }
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
                    int n = ChiTieus.Count;
                    sr.WriteLine(n);

                    for(int i=0; i<ChiTieus.Count; i++)
                    {
                        sr.WriteLine(ChiTieus[i].LoaiChiTieu);
                        sr.WriteLine(ChiTieus[i].SoTien);
                        sr.WriteLine(ChiTieus[i].NoiDung);
                    }
                }
            }
            catch 
            {
            }
        }

    }
}
