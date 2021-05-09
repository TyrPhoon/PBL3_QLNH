using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNH.Entity;

namespace QLNH.BLL
{
	class BLL_BanAn
	{
		private static BLL_BanAn _Instance;
		public static BLL_BanAn Instance
		{
			get
			{
				if (_Instance == null)
				{
					_Instance = new BLL_BanAn();
				}
				return _Instance;
			}
			private set { }
		}

		public List<BanAn> GetBanAns()
		{
			PBL3_QLNHEntities db = new PBL3_QLNHEntities();
			List<BanAn> data = new List<BanAn>();
			foreach (BanAn i in db.BanAns)
			{
				data.Add(i);
			}
			return data;
		}
		public List<CBBItems> GetCBBBanChuyen(int ID)
		{
			List<CBBItems> data = new List<CBBItems>();
			PBL3_QLNHEntities db = new PBL3_QLNHEntities();
			foreach (BanAn item in db.BanAns)
			{
				if (item.id != ID && item.trangthai == "Trống")
				{
					data.Add(new CBBItems { Value = item.id, Text = item.ten });
				}
			}
			return data;
		}
		public void UpdateTableWhenAddFood(int IDTable)
		{
			PBL3_QLNHEntities db = new PBL3_QLNHEntities();
			var s = db.BanAns.Find(IDTable);
			s.trangthai = "Đang SD";
			db.SaveChanges();
		}
		public void UpdateTableWhenThanhToan(int ID)
		{
			PBL3_QLNHEntities db = new PBL3_QLNHEntities();
			var s = db.BanAns.Find(ID);
			s.trangthai = "Trống";
			db.SaveChanges();
		}

		public void ChuyenBan(int IDcu, int IDmoi)
		{
			PBL3_QLNHEntities db = new PBL3_QLNHEntities();
			var s1 = db.BanAns.Where(p => p.id == IDcu).FirstOrDefault();
			s1.trangthai = "Trống";
			var s2 = db.BanAns.Where(p => p.id == IDmoi).FirstOrDefault();
			s2.trangthai = "Đang SD";
			db.SaveChanges();
		}
	}
}



//public void UpdateTableWhenAddFood(int IDTable)
//{
//	PBL3_QLNHEntities db = new PBL3_QLNHEntities();
//	var s = db.BanAns.Find(IDTable);
//	s.trangthai = "Đang SD";
//	db.SaveChanges();
//}
//public void UpdateTableWhenThanhToan(int ID)
//{
//	PBL3_QLNHEntities db = new PBL3_QLNHEntities();
//	var s = db.BanAns.Find(ID);
//	s.trangthai = "Trống";
//	db.SaveChanges();
//}

//public void ChuyenBan(int IDcu, int IDmoi)
//{
//	PBL3_QLNHEntities db = new PBL3_QLNHEntities();
//	var s1 = db.BanAns.Where(p => p.id == IDcu).FirstOrDefault();
//	s1.trangthai = "Trống";
//	var s2 = db.BanAns.Where(p => p.id == IDmoi).FirstOrDefault();
//	s2.trangthai = "Đang SD";
//	db.SaveChanges();
//}
//	}
//}

