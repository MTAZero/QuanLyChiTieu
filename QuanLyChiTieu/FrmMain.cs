using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChiTieu
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Helper.ChiTieus = new List<ChiTieu>()
            {
                new ChiTieu() {ID = 0,NoiDung = "Đi chơi", SoTien = 1000000 },
                new ChiTieu() {ID=1,NoiDung="Học bài",SoTien = 4967689 }
            };

        }
    }
}
