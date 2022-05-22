using Core.DataAccess.EntityFreamwork;
using DataAccess.Abstract;
using Entities.Concrete;
using DataAccess.Concrete.EntityFreamwork.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFreamwork
{
    public class EfProductDal:EfEntityRepositoryBase<Product,NortwindContext>,IProductDal
    {
    }
}
