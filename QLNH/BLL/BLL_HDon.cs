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
				if (i.idban == id)
				{
					data.Add(i.idhoadon);
				}
			}
			return data;
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
	}
}
