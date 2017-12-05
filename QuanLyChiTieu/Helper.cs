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
        public static List<LoaiCongViec> LoaiCongViecs = new List<LoaiCongViec>()
        {
            new LoaiCongViec() {ID = 0, Name = "Ăn uống"},
            new LoaiCongViec() {ID = 1, Name = "Di chuyển"},
            new LoaiCongViec() {ID = 2, Name = "Nhà cửa"},
            new LoaiCongViec() {ID = 3, Name = "Xe cộ"},
            new LoaiCongViec() {ID = 4, Name = "Nhu yếu phẩm"},
            new LoaiCongViec() {ID = 5, Name = "Dịch vụ"}
        };

        public static void LoadDanhSach(string FileName)
        {
            ChiTieus = new List<ChiTieu>();
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(FileName))
                {
                    int n;
                    n = Int32.Parse(sr.ReadLine());

                    for (int i = 0; i < n; i++)
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

                    for (int i = 0; i < ChiTieus.Count; i++)
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
