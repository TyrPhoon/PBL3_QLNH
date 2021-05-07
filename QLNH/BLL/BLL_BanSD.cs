using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNH.Entity;

namespace QLNH.BLL
{//hhhhcababjschshdhadqrqesadad
	class BLL_BanSD
	{
		private static BLL_BanSD _Instance;
		public static BLL_BanSD Instance
		{
			get
			{
				if (_Instance == null)
				{
					_Instance = new BLL_BanSD();
				}
				return _Instance;
			}
			private set { }
		}
		public void InsertBanSDWhenAddFood(int id)
		{
			PBL3_QLNHEntities db = new PBL3_QLNHEntities();
			int k = 0;
			foreach (HoaDon i in db.HoaDons)
			{
				if (i.idban == id)
				{
					k = i.idhoadon;
				}
			}
			BanSuDung bsd = new BanSuDung()
			{
				idban = id,
				idhoadon = k
			};
			db.BanSuDungs.Add(bsd);
			db.SaveChanges();
		}
		public void DeleteBanSDWhenThanhToan(int ID)
		{
			PBL3_QLNHEntities db = new PBL3_QLNHEntities();
			foreach (BanSuDung i in db.BanSuDungs)
			{
				if (i.idban == ID)
				{
					db.BanSuDungs.Remove(i);
					break;
				}
			}
			db.SaveChanges();
		}
		public void ChuyenBan(int IDcu, int IDmoi)
		{
			PBL3_QLNHEntities db = new PBL3_QLNHEntities();
			foreach (BanSuDung i in db.BanSuDungs)
			{
				if (i.idban == IDcu)
				{
					db.BanSuDungs.Remove(i);
					break;
				}
			}
			InsertBanSDWhenAddFood(IDmoi);
			db.SaveChanges();
		}
	}
}
