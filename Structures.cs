using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WholesaleWarehouse
{
    public struct Users
    {
        public string Surname;
        public string Name;
        public string Patronymic;
        public string Login;
        public string Password;
        public int Role;
        public void show()
        {
            Console.WriteLine("{0, -15} {1, -15} {2, -15} {3, -15} {4, -15} {5}", Surname, Name, Patronymic, Login, Password, Role);
        }
    }
    public struct Items
    {
        public string Name;
        public string Price;
        public string Type;
        public void show()
        {
            Console.WriteLine("{0, -15} {1, -15} {2}", Name, Price, Type);
        }
    }
    public struct Supplies
    {
        public string Item;
        public string Supplier;
        public string Date;
        public int Amount;
        public int Price;
        public int Sum;
        public void show()
        {
            Console.WriteLine("{0, -15} {1, -15} {2, -15} {3, -15} {4, -15} {5}", Item, Supplier, Date, Amount, Price, Sum);
        }
    }
    public struct Sales
    {
        public string Item;
        public string Buyer;
        public string Date;
        public int Amount;
        public int Price;
        public int Sum;
        public void show()
        {
            Console.WriteLine("{0, -15} {1, -15} {2, -15} {3, -15} {4, -15} {5}", Item, Buyer, Date, Amount, Price, Sum);
        }
    }
    public struct Suppliers
    {
        public string Name;
        public string Description;
        public void show()
        {
            Console.WriteLine("{0,-15} {1}", Name, Description);
        }
    }
    public struct Buyers
    {
        public string Name;
        public string Description;
        public void show()
        {
            Console.WriteLine("{0,-15} {1}", Name, Description);
        }
    }
}
