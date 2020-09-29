using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class Pizza
    {
        private int _pizzaNo;
        private double _price;
        private string _size;

        //public Pizza(int n, double price, int size)
        //{
        //    _pizzaNo = n;
        //    _price = price;
        //    _size = size;
        //}

        public int PizzaNo
        {
            get { return _pizzaNo; }
            set { _pizzaNo = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public string size
        {
            get { return _size; }
            set { _size = value; }
        }
    }
}
