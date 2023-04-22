using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WholesaleWarehouse
{
    public abstract class ReadData
    {
        public string Path;
    }
    public class TableUsers: ReadData
    {
        public TableUsers()
        {
            Path = "Users.csv";
        }
        public void Show(List<Users> U)
        {
            U = new List<Users>();
            Console.Clear();
            using (StreamReader sr = new StreamReader(Path))
            {
                while (sr.EndOfStream != true)
                {
                    string[] array = sr.ReadLine().Split(';');
                    U.Add(new Users()
                    {
                        Surname = array[0],
                        Name = array[1],
                        Patronymic = array[2],
                        Login = Convert.ToString(array[3]),
                        Password = Convert.ToString(array[4]),
                        Role = Convert.ToInt32(array[5])
                    });
                }
                sr.Close();
            }
            int i = 1;
            foreach (Users u in U)
            {
                Console.Write($"{i} ");
                u.show();
                i++;
            }
        }
        public void Add()
        {
            
            Console.WriteLine("Введите фамилию пользователя");
            string surn = Console.ReadLine();
            Console.WriteLine("Введите имя пользователя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите отчество пользователя");
            string patr = Console.ReadLine();
            Console.WriteLine("Введите логин пользователя");
            string log = Console.ReadLine();
            Console.WriteLine("Введите пароль пользователя");
            string pass = Console.ReadLine();
            Console.WriteLine("Введите роль пользователя:\n1)Работник склада\n2)Работник бухгалтерии");
            int role = Convert.ToInt32(Console.ReadLine());
            using (StreamWriter sw = new StreamWriter(File.Open(Path, FileMode.Append)))
            {
                sw.Write($"{surn};");
                sw.Write($"{name};");
                sw.Write($"{patr};");
                sw.Write($"{log};");
                sw.Write($"{pass};");
                sw.Write($"{role}\n");
                sw.Close();
            }
        }
        public void Del(List<Users> U)
        {
            U = new List<Users>();
            using (StreamReader sr = new StreamReader(Path))
            {
                while (sr.EndOfStream != true)
                {
                    string[] array = sr.ReadLine().Split(';');
                    U.Add(new Users()
                    {
                        Surname = array[0],
                        Name = array[1],
                        Patronymic = array[2],
                        Login = Convert.ToString(array[3]),
                        Password = Convert.ToString(array[4]),
                        Role = Convert.ToInt32(array[5])
                    });
                }
                sr.Close();
            }
            Console.WriteLine("Введите номер строки, которую нужно удалить");
            int d = Convert.ToInt32(Console.ReadLine());
            U.RemoveAt(d-1);
            using (StreamWriter sw = new StreamWriter(Path))
            {
                for (int i = 0; i < U.Count; i++)
                {
                    sw.Write($"{U[i].Surname};");
                    sw.Write($"{U[i].Name};");
                    sw.Write($"{U[i].Patronymic};");
                    sw.Write($"{U[i].Login};");
                    sw.Write($"{U[i].Password};");
                    sw.Write($"{U[i].Role}\n");
                }
                sw.Close();
            }
        }
    }
    public class TableSales : ReadData
    {
        public TableSales() 
        {
            Path = "Sales.csv";
        }
        public void Show(List<Sales> S)
        {
            S = new List<Sales>();
            Console.Clear();
            using (StreamReader sr = new StreamReader(Path))
            {
                while (sr.EndOfStream != true)
                {
                    string[] array = sr.ReadLine().Split(';');
                    S.Add(new Sales()
                    {
                        Item = array[0],
                        Buyer = array[1],
                        Date = array[2],
                        Amount = Convert.ToInt32(array[3]),
                        Price = Convert.ToInt32(array[4]),
                        Sum = Convert.ToInt32(array[5])
                    });
                }
                sr.Close();
            }
            int i = 1;
            foreach (Sales s in S)
            {
                Console.Write($"{i} ");
                s.show();
                i++;
            }
        }
        public void Add()
        {
            Console.WriteLine("Вы выбрали добавление новой продажи");
            Console.WriteLine("Введите название товара");
            string item = Console.ReadLine();
            Console.WriteLine("Введите дату продажи");
            string date = Console.ReadLine();
            Console.WriteLine("Введите название покупателя");
            string buyer = Console.ReadLine();
            Console.WriteLine("Введите количество товара");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите цену за единицу товара");
            int price = Convert.ToInt32(Console.ReadLine());
            int sum = amount * price;
            using (StreamWriter sw = new StreamWriter(File.Open(Path, FileMode.Append)))
            {
                sw.Write($"{item};");
                sw.Write($"{date};");
                sw.Write($"{buyer};");
                sw.Write($"{amount};");
                sw.Write($"{price};");
                sw.Write($"{sum}\n");
                sw.Close();
            }
        }
        public void Del(List<Sales> S)
        {
            S = new List<Sales>();
            using (StreamReader sr = new StreamReader(Path))
            {
                while (sr.EndOfStream != true)
                {
                    string[] array = sr.ReadLine().Split(';');
                    S.Add(new Sales()
                    {
                        Item = array[0],
                        Date = array[1],
                        Buyer = array[2],
                        Amount = Convert.ToInt32(array[3]),
                        Price = Convert.ToInt32(array[4]),
                        Sum = Convert.ToInt32(array[5])
                    });
                }
                sr.Close();
            }
            Console.WriteLine("Введите номер строки, которую нужно удалить");
            int d = Convert.ToInt32(Console.ReadLine());
            S.RemoveAt(d-1);
            using (StreamWriter sw = new StreamWriter(File.Open(Path, FileMode.Create)))
            {
                for (int i = 0; i < S.Count; i++)
                {
                    sw.Write($"{S[i].Item};");
                    sw.Write($"{S[i].Date};");
                    sw.Write($"{S[i].Buyer};");
                    sw.Write($"{S[i].Amount};");
                    sw.Write($"{S[i].Price};");
                    sw.Write($"{S[i].Sum}\n");
                }
                sw.Close();
            }
        }
    }
    public class TableSupplies : ReadData
    {
        public TableSupplies()
        {
            Path = "Supply.csv";
        }
        public void Show(List<Supplies> S)
        {
            S = new List<Supplies>();
            Console.Clear();
            using (StreamReader sr = new StreamReader(Path))
            {
                while (sr.EndOfStream != true)
                {
                    string[] array = sr.ReadLine().Split(';');
                    S.Add(new Supplies()
                    {
                        Item = array[0],
                        Supplier = array[1],
                        Date = array[2],
                        Amount = Convert.ToInt32(array[3]),
                        Price = Convert.ToInt32(array[4]),
                        Sum = Convert.ToInt32(array[5])
                    });
                }
                sr.Close();
            }
            int i = 1;
            foreach (Supplies s in S)
            {
                Console.Write($"{i} ");
                s.show();
                i++;
            }
        }
        public void Add()
        {
            Console.WriteLine("Вы выбрали добавление новой поставки");
            Console.WriteLine("Введите название товара");
            string item = Console.ReadLine();
            Console.WriteLine("Введите дату поставки");
            string date = Console.ReadLine();
            Console.WriteLine("Введите название поставщика");
            string supplier = Console.ReadLine();
            Console.WriteLine("Введите количество товара");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите цену за единицу товара");
            int price = Convert.ToInt32(Console.ReadLine());
            int sum = amount * price;
            using (StreamWriter sw = new StreamWriter(File.Open(Path, FileMode.Append)))
            {
                sw.Write($"{item};");
                sw.Write($"{date};");
                sw.Write($"{supplier};");
                sw.Write($"{amount};");
                sw.Write($"{price};");
                sw.Write($"{sum}\n");
                sw.Close();
            }
        }
        public void Del(List<Supplies> S)
        {
            S = new List<Supplies>();
            using (StreamReader sr = new StreamReader(Path))
            {
                while (sr.EndOfStream != true)
                {
                    string[] array = sr.ReadLine().Split(';');
                    S.Add(new Supplies()
                    {
                        Item = array[0],
                        Date = array[1],
                        Supplier = array[2],
                        Amount = Convert.ToInt32(array[3]),
                        Price = Convert.ToInt32(array[4]),
                        Sum = Convert.ToInt32(array[5])
                    });
                }
                sr.Close();
            }
            Console.WriteLine("Введите номер строки, которую нужно удалить");
            int d = Convert.ToInt32(Console.ReadLine());
            S.RemoveAt(d-1);
            using (StreamWriter sw = new StreamWriter(File.Open(Path, FileMode.Create)))
            {
                for (int i = 0; i < S.Count; i++)
                {
                    sw.Write($"{S[i].Item};");
                    sw.Write($"{S[i].Date};");
                    sw.Write($"{S[i].Supplier};");
                    sw.Write($"{S[i].Amount};");
                    sw.Write($"{S[i].Price};");
                    sw.Write($"{S[i].Sum}\n");
                }
                sw.Close();
            }
        }
    }
    public class TableItems : ReadData
    {
        public TableItems() 
        {
            Path = "Items.csv";
        }
        public void Show(List<Items> I)
        {
            I = new List<Items>();
            Console.Clear();
            using (StreamReader sr = new StreamReader(Path))
            {
                while (sr.EndOfStream != true)
                {
                    string[] array = sr.ReadLine().Split(';');
                    I.Add(new Items()
                    {
                        Name = array[0],
                        Price = array[1],
                        Type = array[2]
                    });
                }
                sr.Close();
            }
            int i = 1;
            foreach (Items t in I)
            {
                Console.Write($"{i} ");
                t.show();
                i++;
            }
            I.Clear();
        }
        public void Add()
        {
            Console.WriteLine("Вы выбрали добавление нового товара");
            Console.WriteLine("Введите название товара");
            string item = Console.ReadLine();
            Console.WriteLine("Введите цену товара");
            string price = Console.ReadLine();
            Console.WriteLine("Введите тип товара");
            string type = Console.ReadLine();
            using (StreamWriter sw = new StreamWriter(File.Open(Path, FileMode.Append)))
            {
                sw.Write($"{item};");
                sw.Write($"{price};");
                sw.Write($"{type}\n");
                sw.Close();
            }
        }
        public void Del(List<Items> I)
        {
            I = new List<Items>();
            using (StreamReader sr = new StreamReader(Path))
            {
                while (sr.EndOfStream != true)
                {
                    string[] array = sr.ReadLine().Split(';');
                    I.Add(new Items()
                    {
                        Name = array[0],
                        Price = array[1],
                        Type = array[2]
                    });
                }
                sr.Close();
            }
            Console.WriteLine("Введите номер строки, которую нужно удалить");
            int d = Convert.ToInt32(Console.ReadLine());
            I.RemoveAt(d-1);
            using (StreamWriter sw = new StreamWriter(File.Open(Path, FileMode.Create)))
            {
                for (int i = 0; i < I.Count; i++)
                {
                    sw.Write($"{I[i].Name};");
                    sw.Write($"{I[i].Price};");
                    sw.Write($"{I[i].Type}\n");
                }
                sw.Close();
            }
        }
    }
    public class TableSuppliers : ReadData
    {
        public TableSuppliers()
        {
            Path = "Suppliers.csv";
        }
        public void Show(List<Suppliers> S)
        {
            S = new List<Suppliers>();
            Console.Clear();
            using (StreamReader sr = new StreamReader(Path))
            {
                while (sr.EndOfStream != true)
                {
                    string[] array = sr.ReadLine().Split(';');
                    S.Add(new Suppliers()
                    {
                        Name = array[0],
                        Description = array[1]
                    });
                }
                sr.Close();
            }
            int i = 1;
            foreach (Suppliers s in S)
            {
                Console.Write($"{i} ");
                s.show();
                i++;
            }
            S.Clear();
        }
        public void Add()
        {
            Console.WriteLine("Вы выбрали добавление нового поставщика");
            Console.WriteLine("Введите название поставщика");
            string name = Console.ReadLine();
            Console.WriteLine("Введите описание");
            string description = Console.ReadLine();
            using (StreamWriter sw = new StreamWriter(File.Open(Path, FileMode.Append)))
            {
                sw.Write($"{name};");
                sw.Write($"{description}\n");
                sw.Close();
            }
        }
        public void Del(List<Suppliers> S)
        {
            S = new List<Suppliers>();
            using (StreamReader sr = new StreamReader(Path))
            {
                while (sr.EndOfStream != true)
                {
                    string[] array = sr.ReadLine().Split(';');
                    S.Add(new Suppliers()
                    {
                        Name = array[0],
                        Description = array[1]
                    });
                }
                sr.Close();
            }
            Console.WriteLine("Введите номер строки, которую нужно удалить");
            int d = Convert.ToInt32(Console.ReadLine());
            S.RemoveAt(d-1);
            using (StreamWriter sw = new StreamWriter(File.Open(Path, FileMode.Create)))
            {
                for (int i = 0; i < S.Count; i++)
                {
                    sw.Write($"{S[i].Name};");
                    sw.Write($"{S[i].Description}\n");
                }
                sw.Close();
            }
        }
    }
    public class TableBuyers : ReadData
    {
        public TableBuyers()
        {
            Path = "Buyers.csv";
        }
        public void Show(List<Buyers> B)
        {
            B = new List<Buyers>();
            Console.Clear();
            using (StreamReader sr = new StreamReader(Path))
            {
                while (sr.EndOfStream != true)
                {
                    string[] array = sr.ReadLine().Split(';');
                    B.Add(new Buyers()
                    {
                        Name = array[0],
                        Description = array[1]
                    });
                }
                sr.Close();
            }
            int i = 1;
            foreach (Buyers b in B)
            {
                Console.Write($"{i} ");
                b.show();
                i++;
            }
            B.Clear();
        }
        public void Add()
        {
            Console.WriteLine("Вы выбрали добавление нового покупателя");
            Console.WriteLine("Введите название покупателя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите описание");
            string description = Console.ReadLine();
            using (StreamWriter sw = new StreamWriter(File.Open(Path, FileMode.Append)))
            {
                sw.Write($"{name};");
                sw.Write($"{description}\n");
                sw.Close();
            }
        }
        public void Del(List<Buyers> B)
        {
            B = new List<Buyers>();
            using (StreamReader sr = new StreamReader(Path))
            {
                while (sr.EndOfStream != true)
                {
                    string[] array = sr.ReadLine().Split(';');
                    B.Add(new Buyers()
                    {
                        Name = array[0],
                        Description = array[1]
                    });
                }
                sr.Close();
            }
            Console.WriteLine("Введите номер строки, которую нужно удалить");
            int d = Convert.ToInt32(Console.ReadLine());
            B.RemoveAt(d-1);
            using (StreamWriter sw = new StreamWriter(File.Open(Path, FileMode.Create)))
            {
                for (int i = 0; i < B.Count; i++)
                {
                    sw.Write($"{B[i].Name};");
                    sw.Write($"{B[i].Description}\n");
                }
                sw.Close();
            }
        }
    }
}
