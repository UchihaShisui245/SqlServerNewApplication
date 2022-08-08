using SqlServerNewApplication.Model;
using System.Collections.Generic;

namespace SqlServerNewApplication.Services
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}