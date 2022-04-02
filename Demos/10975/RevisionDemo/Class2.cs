using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionDemo
{
    abstract class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderStatus { get; set; }
        //normal methods allow sharing of logic in inherited classes
        public void DisplayOrders()
        {
            Console.WriteLine($"Order id: {this.OrderId}, order date: {this.OrderDate.ToShortDateString()}");
        }
        //virtual method : may or may not override in derived class
        public virtual void CalculateShipping()
        {
            //logic
        }
        public abstract void ProcessOrder(int orderid);
    }

    class OverseasOrder : Order
    {
        //properties specific to overseas 
        public override void CalculateShipping() //virtual
        {
            base.CalculateShipping();
        }
        public override void ProcessOrder(int orderid) //abstract 
        {
            //throw new NotImplementedException();
        }
    }
}
