using System.Collections.Generic;
using WebApplicationAPI.Model.Domain;

namespace WebApplicationAPI.Business.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetListProduct();
    }
}