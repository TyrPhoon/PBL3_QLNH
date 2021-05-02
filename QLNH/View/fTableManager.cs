using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNH.Entity;

namespace QLNH
{
    public partial class fTableManager : Form
    {
        public fTableManager()
        {
            InitializeComponent();
            LoadTable();
        }

        void LoadTable()
        {
            PBL3_QLNHEntities db = new PBL3_QLNHEntities();
			foreach (BanAn i in db.BanAns)
			{
                Button bt = new Button() { Width = BanAn.width, Height = BanAn.height };
                bt.Text =   i.ten + Environment.NewLine + i.songuoi + Environment.NewLine + i.trangthai ;
				switch (i.trangthai)
				{
                    case "Trống" :
                        bt.BackColor = Color.Aqua;
                        break;
                    case "Đang SD":
                        bt.BackColor = Color.Red;
                        break;
                    default:
                        bt.BackColor = Color.Green;
						break;
				}
				flpanelTable.Controls.Add(bt);
			}
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile();
            f.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.ShowDialog();
        }
	}
}
