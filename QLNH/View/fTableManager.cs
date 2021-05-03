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
using QLNH.BLL;

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
                bt.Text = i.ten + Environment.NewLine + i.songuoi + Environment.NewLine + i.trangthai;
                bt.Click += bt_click;
                bt.Tag = i;
                switch (i.trangthai)
                {
                    case "Trống":
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

        void ShowHD(int id)
        {
            int total = 0;
            List<HoaDonchitiet> ListHDCT = BLL_HDon.Instance.GetHDCTByListIDHD(BLL_HDon.Instance.GetListHDByIDBan(id));
            listView1.Items.Clear();
			foreach (HoaDonchitiet i in ListHDCT)
			{
                Thucan t = BLL_ThucAn.Instance.GetThucAnByID(i.idthucan);
                ListViewItem lsvitem = new ListViewItem(t.ten.ToString());
                lsvitem.SubItems.Add(i.soluong.ToString());
                lsvitem.SubItems.Add(t.gia.ToString());
                int k = i.soluong * t.gia;
                total += k;
                lsvitem.SubItems.Add(k.ToString());
                listView1.Items.Add(lsvitem);
			}
            tbtotal.Text = total.ToString();
        }
		private void bt_click(object sender, EventArgs e)
		{
            int TableID = ((sender as Button).Tag as BanAn).id;
            ShowHD(TableID);
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
