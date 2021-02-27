using Core.DataAccess;
using Entities.Concreate;
using Entities.Concreate.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();

    }
}

//Code Refactoring