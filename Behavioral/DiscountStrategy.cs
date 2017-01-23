using System;

namespace computerscience
{

    public class OrderProcessor
    {
        IDiscountStrategy _discountStrategy ;
        public OrderProcessor(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        public void ProcessOrder(Order order)
        {
                var discountAmount = _discountStrategy.GetDiscount(order.OrderTotal);
                Console.WriteLine("Discount for this order is {0}", discountAmount);
        }
    }
    public interface IDiscountStrategy
    {
         float GetDiscount(float totalAmount);
        
    }

    public class NewCustomerDiscountStrategy : IDiscountStrategy
    {
        float IDiscountStrategy.GetDiscount(float totalAmount)
        {
            return totalAmount * 0.30f;
        }
    }

    public class ExistingCustomerDiscountStrategy : IDiscountStrategy
    {
        float IDiscountStrategy.GetDiscount(float totalAmount)
        {
             return totalAmount * 0.10f;
        }
    }
}