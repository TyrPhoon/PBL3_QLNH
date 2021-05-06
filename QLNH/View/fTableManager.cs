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
            SetCBBDMTAn();
        }
        void SetCBBCBan(int ID)
        {
            Cbbbanchuyen.Items.Clear();
            Cbbbanchuyen.Items.AddRange(BLL_BanAn.Instance.GetCBBBanChuyen(ID).ToArray());
            Cbbbanchuyen.SelectedIndex = 0;
        }
        void SetCBBDMTAn()
        {
            CbbDMTAn.Items.AddRange(BLL_DMTAn.Instance.GetCBBDMThucAn().ToArray());
            CbbDMTAn.SelectedIndex = 0;
        }
        void SetCBBTAn(int id)
        {
            CbbThucAn.Items.AddRange(BLL_ThucAn.Instance.GetCBBThucAnByIDDM(id).ToArray());
            CbbThucAn.SelectedIndex = 0;
        }
        void LoadTable()
        {
            PBL3_QLNHEntities db = new PBL3_QLNHEntities();
            flpanelTable.Controls.Clear();
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
            List<HoaDonchitiet> ListHDCT = BLL_HDCTiet.Instance.GetHDCTByListIDHD(BLL_HDon.Instance.GetListHDByIDBan(id));
            LVHoaDon.Items.Clear();
			foreach (HoaDonchitiet i in ListHDCT)
			{
                Thucan t = BLL_ThucAn.Instance.GetThucAnByID(i.idthucan);
                ListViewItem lsvitem = new ListViewItem(t.ten.ToString());
                lsvitem.SubItems.Add(i.soluong.ToString());
                lsvitem.SubItems.Add(t.gia.ToString());
                int k = i.soluong * t.gia;
                total += k;
                lsvitem.SubItems.Add(k.ToString());
                LVHoaDon.Items.Add(lsvitem);
			}
            tbtotal.Text = total.ToString();
        }
		private void bt_click(object sender, EventArgs e)
		{
            int TableID = ((sender as Button).Tag as BanAn).id;
            LVHoaDon.Tag = TableID;
            SetCBBCBan(TableID);
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

		private void CbbDMTAn_SelectedIndexChanged(object sender, EventArgs e)
		{
            CbbThucAn.Items.Clear();
            int iddm = ((CBBItems)CbbDMTAn.SelectedItem).Value;
            SetCBBTAn(iddm);
		}

		private void BTAddfood_Click(object sender, EventArgs e)
		{
            int IDTable = Convert.ToInt32(LVHoaDon.Tag.ToString());
            int IDFood = ((CBBItems)CbbThucAn.SelectedItem).Value;
            int Soluong = Convert.ToInt32(NbrudSoluong.Value.ToString());
            bool hd = BLL_HDon.Instance.AddHDon(IDTable);
            if (hd == false)
            {
                //DialogResult KQ = MessageBox.Show("Bàn này hiện còn hóa đơn chưa thanh toán, bạn có muốn thêm món vào hóa đơn này không?", "Thông Báo", MessageBoxButtons.OKCancel);
				//if (KQ == DialogResult.OK)
				{
                    BLL_HDCTiet.Instance.AddHDCT(IDTable, IDFood, Soluong);
                }
            }
            else
            {
                BLL_BanAn.Instance.UpdateTableWhenAddFood(IDTable);
                BLL_BanSD.Instance.InsertBanSDWhenAddFood(IDTable);
                BLL_HDCTiet.Instance.AddHDCT(IDTable, IDFood, Soluong);
            }
            LoadTable();
            ShowHD(IDTable);
		}

		private void BTThanhToan_Click(object sender, EventArgs e)
		{
            int IDTable = Convert.ToInt32(LVHoaDon.Tag.ToString());
            int Total = Convert.ToInt32(tbtotal.Text);
			if (BLL_HDon.Instance.check(IDTable))
			{
                DialogResult KQ = MessageBox.Show("Bạn có chắc chắn muốn thanh toán cho bàn " + IDTable, "Thông báo", MessageBoxButtons.YesNo);
                if (KQ == DialogResult.Yes)
                {
                    BLL_HDon.Instance.ThanhToanHDon(IDTable, Total);
                    BLL_BanAn.Instance.UpdateTableWhenThanhToan(IDTable);
                    BLL_BanSD.Instance.DeleteBanSDWhenThanhToan(IDTable);
                    LoadTable();
                    ShowHD(IDTable);
                }
            }
			else
			{
                MessageBox.Show("Bàn số " + IDTable + " chưa dùng món, không thể thanh toán");
			}
            

        }

		private void BTgiamgia_Click(object sender, EventArgs e)
		{
            int Total = Convert.ToInt32(tbtotal.Text);
            Total = Total * (100 - Convert.ToInt32(NbrudGiamgia.Value))/100;
            tbtotal.Text = Total.ToString();
        }

		private void BTChuyenban_Click(object sender, EventArgs e)
		{
            int IDNewTable = ((CBBItems)Cbbbanchuyen.SelectedItem).Value;
            int IDTable = Convert.ToInt32(LVHoaDon.Tag.ToString());
            BLL_BanAn.Instance.ChuyenBan(IDTable, IDNewTable);
            BLL_HDon.Instance.ChuyenBan(IDTable, IDNewTable);
            BLL_BanSD.Instance.ChuyenBan(IDTable, IDNewTable);
            LoadTable();
            ShowHD(IDTable);
        }
	}
}
