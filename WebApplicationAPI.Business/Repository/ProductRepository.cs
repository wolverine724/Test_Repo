using System;
using System.Collections.Generic;
using System.Text;
using WebApplicationAPI.Data.Data;
using WebApplicationAPI.Model.Domain;

namespace WebApplicationAPI.Business.Repository
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(FairyDustContext fairyDustContext) : base(fairyDustContext)
        {

        }

        public IEnumerable<Product> GetListProduct()
        {
            return base.GetAll();
        }
    }
}
