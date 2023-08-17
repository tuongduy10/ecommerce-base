﻿using System;
using System.Collections.Generic;

namespace ECommerce.Entities
{
    public partial class ShopBank
    {
        public int ShopBankId { get; set; }
        public string ShopBankName { get; set; }
        public string ShopAccountName { get; set; }
        public string ShopAccountNumber { get; set; }
        public int ShopId { get; set; }

        public virtual Shop Shop { get; set; }
    }
}
