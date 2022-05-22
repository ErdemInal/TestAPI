using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IOrderService
    {
        
        IDataResult<List<Order>> GetListByOrder(int orderId);
        IDataResult<List<Order>> GetById(int orderId);
        IDataResult<List<Order>> GetList();
        IResult Add(Order order);
        IResult Delete(Order order);
        IResult Update(Order order);
    }
}
