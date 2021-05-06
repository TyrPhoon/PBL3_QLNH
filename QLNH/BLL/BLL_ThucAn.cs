using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNH.Entity;

namespace QLNH.BLL
{
	class BLL_ThucAn
	{
		private static BLL_ThucAn _Instance;

		public static BLL_ThucAn Instance
		{
			get
			{
				if (_Instance == null)
				{
					_Instance = new BLL_ThucAn();
				}
				return _Instance;
			}
			private set { }
		}
		public List<Thucan> GetThucAn()
		{
			PBL3_QLNHEntities db = new PBL3_QLNHEntities();
			List<Thucan> data = new List<Thucan>();
			foreach (Thucan i in db.Thucans)
			{
				data.Add(i);
			}
			return data;
		}
		public Thucan GetThucAnByID(int id)
		{
			Thucan t = new Thucan();
			PBL3_QLNHEntities db = new PBL3_QLNHEntities();
			foreach (Thucan item in db.Thucans)
			{
				if (item.id == id)
				{
					t = item;
				}
			}
			return t;
		}
		public List<CBBItems> GetCBBThucAnByIDDM(int id)
		{
			List<CBBItems> data = new List<CBBItems>();
			PBL3_QLNHEntities db = new PBL3_QLNHEntities();
			foreach (Thucan item in db.Thucans)
			{
				if (item.iddanhmuc == id)
				{
					data.Add(new CBBItems { Value = item.id, Text = item.ten });
				}
			}
			return data;
		}
	}
}
