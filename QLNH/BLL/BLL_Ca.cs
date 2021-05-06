using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNH.Entity;

namespace QLNH.BLL
{
	class BLL_Ca
	{
		private static BLL_Ca _Instance;
		public static BLL_Ca Instance
		{
			get
			{
				if (_Instance == null)
				{
					_Instance = new BLL_Ca();
				}
				return _Instance;
			}
			private set { }
		}
	}
}
