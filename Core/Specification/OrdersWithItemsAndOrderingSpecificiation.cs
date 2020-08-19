using System;
using System.Linq.Expressions;
using Core.Entities.OrderAggregate;

namespace Core.Specification
{
    public class OrdersWithItemsAndOrderingSpecificiation : BaseSpecification<Order>
    {
        public OrdersWithItemsAndOrderingSpecificiation(string email) : base(o => o.BuyerEmail == email)
        {
            AddInclude(o => o.OrderItems);
            AddInclude(o => o.DeliveryMethod);
            AddOrderByDecending(o => o.OrderDate);
        }

        public OrdersWithItemsAndOrderingSpecificiation(int id, string email) : base(o => o.Id == id && o.BuyerEmail == email)
        {
            AddInclude(o => o.OrderItems);
            AddInclude(o => o.DeliveryMethod);
        }
    }
}