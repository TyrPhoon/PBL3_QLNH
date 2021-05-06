using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNH.Entity;

namespace QLNH.BLL
{
	class BLL_NhanVien
	{
		private static BLL_NhanVien _Instance;
		public static BLL_NhanVien Instance
		{
			get
			{
				if (_Instance == null)
				{
					_Instance = new BLL_NhanVien();
				}
				return _Instance;
			}
			private set { }
		}
	}
}
