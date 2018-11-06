﻿using DB.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.DAO
{
    public class ProductCategoryDao
    {
        ShopOnlineContext db = null;
        public ProductCategoryDao()
        {
            db = new ShopOnlineContext();
        }

        public List<ProductCategory> GetAllActiveProductCategories()
        {
            var result = db.ProductCategories.Where(x => x.Status).ToList();
            return result;
        }
        // tra ve productCategory.
        // truy van db cua ProductCategories lay dong dau tien thoa man dieu kien trong sql ProductCategories
        public ProductCategory GetProductCategoryById(long id)
        {
            var result = db.ProductCategories.FirstOrDefault(x => x.ID == id);
            return result;
        }
    }
}
