using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDemo
{
    public class ProductDetailModel
    {
        string Data;
    }

    public class ProductDetailQueryHandler : IQueryHandler<ProductDetailQuery, ProductDetailModel>
    {
        public ProductDetailModel Handle(ProductDetailQuery query)
        {
            return new ProductDetailModel();
        }

    }
}
