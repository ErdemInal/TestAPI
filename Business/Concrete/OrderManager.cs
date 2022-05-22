using Business.Abstract;
using Business.Contants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
        private IOrderDal _orderDal;
        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }
        public IResult Add(Order order)
        {
            _orderDal.Add(order);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult Delete(Order order)
        {
            _orderDal.Delete(order);
            return new SuccessResult(Messages.ProductDeleted);
        }

        public IDataResult<List<Order>> GetById(int orderId)
        {
            return new SuccessDataResult<List<Order>>(_orderDal.GetList(p => p.OrderId == orderId).ToList(), true);
        }

        public IDataResult<List<Order>> GetList()
        {
            return new SuccessDataResult<List<Order>>(_orderDal.GetList().ToList(), true);
        }

       

        public IResult Update(Order order)
        {
            _orderDal.Update(order);
            return new SuccessResult(Messages.ProductUpdated);
        }

        IDataResult<List<Order>> IOrderService.GetListByOrder(int orderId)
        {
            return new SuccessDataResult<List<Order>>(_orderDal.GetList(p => p.OrderId == orderId).ToList(), true);
        }
    }
}
