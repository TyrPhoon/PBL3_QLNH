using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNH.Entity;

namespace QLNH.BLL
{
	class BLL_DMTAn
	{
		private static BLL_DMTAn _Instance;

		public static BLL_DMTAn Instance
		{
			get
			{
				if (_Instance == null)
				{
					_Instance = new BLL_DMTAn();
				}
				return _Instance;
			}
			private set { }
		}
		public List<CBBItems> GetCBBDMThucAn()
		{
			List<CBBItems> data = new List<CBBItems>();
			PBL3_QLNHEntities db = new PBL3_QLNHEntities();
			foreach(Danhmucthucan item in db.Danhmucthucans)
			{
				data.Add(new CBBItems { Value = item.id, Text = item.ten });
			}
			return data;
		}
		public List<CBBItems> GetCBBDMThucAn2()
		{
			List<CBBItems> data = new List<CBBItems>();
			PBL3_QLNHEntities db = new PBL3_QLNHEntities();
			foreach (Danhmucthucan item in db.Danhmucthucans)
			{
				data.Add(new CBBItems { Value = item.id, Text = item.ten });
			}
			return data;
		}

	}
}
