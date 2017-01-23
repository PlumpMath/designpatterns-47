using System;
using computerscience;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //factory pattern
           var report = ReportFactory.CreateReport("PDF");
           report.DisplayReport();

           report = ReportFactory.CreateReport("HTML");
           report.DisplayReport();


            //strategy pattern

            var order1 = new Order{OrderTotal=100};
            var processor1 = new OrderProcessor(new NewCustomerDiscountStrategy() );
            processor1.ProcessOrder(order1);

            var order2 = new Order{OrderTotal=100};
            var processor2 = new OrderProcessor(new ExistingCustomerDiscountStrategy() );
            processor2.ProcessOrder(order2);
        }
    }
}
