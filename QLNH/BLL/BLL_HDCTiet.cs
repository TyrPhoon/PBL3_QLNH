using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNH.Entity;

namespace QLNH.BLL
{
	class BLL_HDCTiet
	{
		private static BLL_HDCTiet _Instance;
		public static BLL_HDCTiet Instance
		{
			get
			{
				if (_Instance == null)
				{
					_Instance = new BLL_HDCTiet();
				}
				return _Instance;
			}
			private set { }
		}
		public List<HoaDonchitiet> GetHDCTByListIDHD(List<int> id)
		{
			List<HoaDonchitiet> data = new List<HoaDonchitiet>();
			PBL3_QLNHEntities db = new PBL3_QLNHEntities();
			foreach (int i in id)
			{
				foreach (HoaDonchitiet j in db.HoaDonchitiets)
				{
					if (i == j.idhoadon)
					{
						data.Add(j);
					}
				}
			}
			return data;
		}
		public void AddHDCT(int idban, int idthucan, int soluong)
		{
			PBL3_QLNHEntities db = new PBL3_QLNHEntities();
			int idhd = 0,gia = 0,idhdct = db.HoaDonchitiets.Count() + 1;
			foreach (BanSuDung i in db.BanSuDungs)
			{
				if (i.idban == idban)
				{
					idhd = (int)i.idhoadon;
				}
			}
			foreach (Thucan i in db.Thucans)
			{
				if (i.id == idthucan)
				{
					gia = i.gia;
				}
			}
			HoaDonchitiet hdct = new HoaDonchitiet()
			{
				idhdct = idhdct,
				idthucan = idthucan,
				idhoadon = idhd,
				soluong = soluong,
				dongia  = gia
			};
			db.HoaDonchitiets.Add(hdct);
			db.SaveChanges();
			
		}
	}
}


//public void AddHDCT(int idban, int idthucan, int soluong)
//{
//	PBL3_QLNHEntities db = new PBL3_QLNHEntities();
//	int idhd = 0, gia = 0, idhdct = db.HoaDonchitiets.Count() + 1;
//	foreach (BanSuDung i in db.BanSuDungs)
//	{
//		if (i.idban == idban)
//		{
//			idhd = (int)i.idhoadon;
//		}
//	}
//	foreach (Thucan i in db.Thucans)
//	{
//		if (i.id == idthucan)
//		{
//			gia = i.gia;
//		}
//	}
//	HoaDonchitiet hdct = new HoaDonchitiet()
//	{
//		idhdct = idhdct,
//		idthucan = idthucan,
//		idhoadon = idhd,
//		soluong = soluong,
//		dongia = gia
//	};
//	db.HoaDonchitiets.Add(hdct);
//	db.SaveChanges();

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

//}
//	}
//}

