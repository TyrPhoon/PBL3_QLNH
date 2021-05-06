using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNH.Entity;

namespace QLNH.BLL
{
	class BLL_HDon
	{
		private static BLL_HDon _Instance;

		public static BLL_HDon Instance
		{
			get
			{
				if (_Instance == null)
				{
					_Instance = new BLL_HDon();
				}
				return _Instance;
			}
			private set { }
		}

		public List<int> GetListHDByIDBan(int id)
		{
			List<int> data = new List<int>();
			PBL3_QLNHEntities db = new PBL3_QLNHEntities();
			foreach (HoaDon i in db.HoaDons)
			{
				if (i.idban == id && i.trangthai == 1)
				{
					data.Add(i.idhoadon);
				}
			}
			return data;
		}

		public bool AddHDon(int IDTable)
		{
			PBL3_QLNHEntities db = new PBL3_QLNHEntities();
			int k = db.HoaDons.Count();
			bool check = true;
			HoaDon HD = new HoaDon()
			{
				idhoadon = k + 1,
				idban = IDTable,
				ngaycheckin = DateTime.Now,
				ngaycheckout = null,
				trangthai = 0,
				Tongtien = null,
				idnv = null
			};
			foreach (HoaDon item in db.HoaDons)
			{
				if (item.idban == IDTable)
				{
					check = false;
				}
			}
			if (check)
			{
				try
				{
					db.HoaDons.Add(HD);
					db.SaveChanges();
				}
				catch (Exception)
				{
					check = false;
				}
			}
			return check;
		}
		public bool check(int ID)
		{
			bool kq = true;
			PBL3_QLNHEntities db = new PBL3_QLNHEntities();
			var s = db.HoaDons.Where(p => p.idban == ID).FirstOrDefault();
			if (s == null || s.trangthai != 1) kq = false;
			return kq;
		}
		public void ThanhToanHDon(int ID,int Total)
		{
			PBL3_QLNHEntities db = new PBL3_QLNHEntities();
			var s = db.HoaDons.Where(p => p.idban == ID).FirstOrDefault();
			s.trangthai = 0;
			s.ngaycheckout = DateTime.Now;
			s.Tongtien = Total;
			db.SaveChanges();
		}
		public void ChuyenBan(int IDcu, int IDmoi)
		{
			PBL3_QLNHEntities db = new PBL3_QLNHEntities();
			var s = db.HoaDons.Where(p => p.idban == IDcu).FirstOrDefault();
			s.idban = IDmoi;
			db.SaveChanges();
		}
	}
}
