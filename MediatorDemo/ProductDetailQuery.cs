using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDemo
{
    public class ProductDetailQuery : IQuery<ProductDetailModel>
    {
        public int ProductID { get; private set; }

        public ProductDetailQuery(int productId)
        {
            ProductID = productId;
    
        }
    }
}
