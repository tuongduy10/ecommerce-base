﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerce.Entities
{
    public partial class Product
    {
        public Product()
        {
            ProductAttributes = new HashSet<ProductAttribute>();
            ProductImages = new HashSet<ProductImage>();
            ProductOptionValues = new HashSet<ProductOptionValue>();
            ProductPrices = new HashSet<ProductPrice>();
            ProductUserImages = new HashSet<ProductUserImage>();
            Rates = new HashSet<Rate>();
        }

        public int ProductId { get; set; }
        public string Ppc { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public byte? DiscountPercent { get; set; }
        public DateTime? ProductAddedDate { get; set; }
        public string ProductDescription { get; set; }
        public string ProductDescriptionMobile { get; set; }
        public int? ProductStock { get; set; }
        public byte? Status { get; set; }
        public bool? New { get; set; }
        public bool? Highlights { get; set; }
        public string? Delivery { get; set; }
        public string? Repay { get; set; }
        public bool? Legit { get; set; }
        public string Insurance { get; set; }
        public int SubCategoryId { get; set; }
        public int ShopId { get; set; }
        public int BrandId { get; set; }
        public DateTime? ProductImportDate { get; set; }
        public byte? ProductRate { get; set; }
        public string Note { get; set; }
        public string SizeGuide { get; set; }
        public string Link { get; set; }

        // Price
        public decimal? PriceAvailable { get; set; }
        public decimal? DiscountAvailable { get; set; }
        public decimal? PricePreOrder { get; set; }
        public decimal? DiscountPreOrder { get; set; }
        public decimal? PriceImport { get; set; }
        public decimal? PriceForSeller { get; set; }
        public decimal? ProfitAvailable { get; set; }
        public decimal? ProfitPreOrder { get; set; }
        public decimal? ProfitForSeller { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual Shop Shop { get; set; }
        public virtual SubCategory SubCategory { get; set; }
        public virtual ICollection<ProductAttribute> ProductAttributes { get; set; }
        public virtual ICollection<ProductImage> ProductImages { get; set; }
        public virtual ICollection<ProductOptionValue> ProductOptionValues { get; set; }
        public virtual ICollection<ProductPrice> ProductPrices { get; set; }
        public virtual ICollection<ProductUserImage> ProductUserImages { get; set; }
        public virtual ICollection<Rate> Rates { get; set; }
    }
}
