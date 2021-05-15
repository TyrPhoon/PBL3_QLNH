using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNH.Entity;

namespace QLNH.BLL
{
	class BLL_TaiKhoan
	{
		private static BLL_TaiKhoan _Instance;
		public static BLL_TaiKhoan Instance
		{
			get
			{
				if (_Instance == null)
				{
					_Instance = new BLL_TaiKhoan();
				}
				return _Instance;
			}
			private set { }
		}
	}
}
//{
//	class BLL_TaiKhoan
//{
//	private static BLL_TaiKhoan _Instance;
//	public static BLL_TaiKhoan Instance
//	{
//		get
//		{
//			if (_Instance == null)
//			{
//				_Instance = new BLL_TaiKhoan();
//			}
//			return _Instance;
//		}
//		private set { }
//	}
//}
//}
