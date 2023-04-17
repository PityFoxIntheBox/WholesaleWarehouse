namespace WholesaleWarehouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Users> users = new List<Users>();
            string Path = "Users.csv";
            getData(Path, users);
            printData(users);
            //List<Users> fem = users.Where(x => x.Gender == 'ж').ToList();
            //List<Users> fem = users.Where(x => x.Age >= 40).ToList();
            /*Console.WriteLine();
            foreach(Users f in fem)
            {
                f.show();
            }*/
        }

        static void getData(string path, List<Users> L)
        {

            using (StreamReader sr = new StreamReader(path))
            {
                while (sr.EndOfStream != true)
                {
                    string[] array = sr.ReadLine().Split(';');
                    L.Add(new Users()
                    {
                        Surname = array[0],
                        Name = array[1],
                        Patronymic = array[2],
                        Login = Convert.ToString(array[3]),
                        Password = Convert.ToString(array[4]),
                        Role = Convert.ToInt32(array[5])
                    });
                }
            }
        }
        static void printData(List<Users> L)
        {
            foreach (Users u in L)
            {
                u.show();
            }
        }

    }
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
        /*public string concat()
        {
            return Surname + ";" + Name + ";" + Patronymic + ';' + Phone + ';' + Login + ';' + Password + ';' + Gender + ';' + Age;
        }*/
    }
    public struct Items
    {
        public string Name;
        public string Price;
        public string Type;
    }
    public struct Types
    {
        public string Name;
    }
    public struct Supplies
    {
        public string Item;
        public string Supplier;
        public string Date;
        public int Amount;
        public int Price;
        public int Sum;
    }
    public struct Sales
    {
        public string Item;
        public string Buyer;
        public string Date;
        public int Amount;
        public int Price;
        public int Sum;
    }
    public struct Suppliers
    {
        public string Name;
        public string Description;
    }
    public struct Buyers
    {
        public string Name;
        public string Description;
    }
}
