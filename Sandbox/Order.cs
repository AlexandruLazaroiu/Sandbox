using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class Order
    {
        private int _orderID;
        private DateTime _date;

        private Customer _customer;
        private Pizza _pizza;

        public Order(int id, DateTime Date)
        {
            
            _customer = new Customer();
            _pizza = new Pizza();
        }

        public int OrderID
        {
            get
            { _orderID++; return _orderID;  }
            set { _orderID = value; }
            
        }

        public DateTime DateTime
        {
            get { return _date; }
            set { _date = value; }
        }

        public Customer Customer
        {
            get {return _customer; }
            set { _customer = value; }
        }

        public Pizza Pizza
        {
            get { return _pizza; }
            set { _pizza = value; }
        }
        public override string ToString()
        {
            return $"{OrderID}";
        }
    }

}
