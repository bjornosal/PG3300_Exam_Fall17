﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazaar_Of_The_Bizarre.StoreFacade.ShopFactory {
	interface IShop
	{
		void SetName(string name);
		void SetProductPrice(int price);
		int GetPrice();
		string GetName();
	}
}
