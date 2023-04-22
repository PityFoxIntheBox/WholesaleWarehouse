using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace WholesaleWarehouse
{
    internal class Menu
    {
        public void SelectAcc()
        {
            while (true) 
            {
                Console.Clear();
                Console.WriteLine("Введите номер таблицы, которую вы хотите посмотреть:" +
                    "\n1)Товары\n2)Покупатели\n3)Продажи");
                int a = Convert.ToInt32(Console.ReadLine());
                switch(a)
                {
                    case 1:
                        TableItems ti = new TableItems();
                        List<Items> I = new List<Items>();
                        Console.WriteLine("Что хотите сделать с таблицей?\n1)Удалить запись из таблицы\n2)Добавить запись в таблицу\n3)Просмотреть записи");
                        int m1 = Convert.ToInt32(Console.ReadLine());
                        switch(m1)
                        {
                            case 1:
                                ti.Del(I);
                                break;
                            case 2:
                                ti.Add();
                                break;
                            case 3:
                                ti.Show(I);
                                break;
                            default:
                                Console.WriteLine("Такого варианта нет");
                                break;
                        }
                        break;
                    case 2:
                        TableBuyers tb = new TableBuyers();
                        List<Buyers> B = new List<Buyers>();
                        Console.WriteLine("Что хотите сделать с таблицей?\n1)Удалить запись из таблицы\n2)Добавить запись в таблицу\n3)Просмотреть записи");
                        int m2 = Convert.ToInt32(Console.ReadLine());
                        switch(m2)
                        {
                            case 1:
                                tb.Del(B);
                                break;
                            case 2:
                                tb.Add();
                                break;
                            case 3:
                                tb.Show(B);
                                break;
                            default:
                                Console.WriteLine("Такого варианта нет");
                                break;
                        }
                        break;
                    case 3:
                        TableSales ts = new TableSales();
                        List<Sales> S = new List<Sales>();
                        Console.WriteLine("Что хотите сделать с таблицей?\n1)Удалить запись из таблицы\n2)Добавить запись в таблицу\n3)Просмотреть записи");
                        int m3 = Convert.ToInt32(Console.ReadLine());
                        switch(m3)
                        {
                            case 1:
                                ts.Del(S);
                                break;
                            case 2:
                                ts.Add();
                                break;
                            case 3:
                                ts.Show(S);
                                break;
                            default:
                                Console.WriteLine("Такого варианта нет");
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("Такого действия нет");
                        break;
                }
                Console.WriteLine("Хотите продолжить работу?\n1)Да\n2)Нет");
                int w = Convert.ToInt32(Console.ReadLine());
                if (w == 2)
                {
                    break;
                }
            }
            
        }
        public void SelectStor()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Введите номер таблицы, которую вы хотите посмотреть:" +
                    "\n1)Товары\n2)Поставщики\n3)Закупки");
                int a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        TableItems ti = new TableItems();
                        List<Items> I = new List<Items>();
                        Console.WriteLine("Что хотите сделать с таблицей?\n1)Удалить запись из таблицы\n2)Добавить запись в таблицу\n3)Просмотреть записи");
                        int m1 = Convert.ToInt32(Console.ReadLine());
                        switch (m1)
                        {
                            case 1:
                                ti.Del(I);
                                break;
                            case 2:
                                ti.Add();
                                break;
                            case 3:
                                ti.Show(I);
                                break;
                            default:
                                Console.WriteLine("Такого варианта нет");
                                break;
                        }
                        break;
                    case 2:
                        TableSuppliers ts = new TableSuppliers();
                        List<Suppliers> S = new List<Suppliers>();
                        Console.WriteLine("Что хотите сделать с таблицей?\n1)Удалить запись из таблицы\n2)Добавить запись в таблицу\n3)Просмотреть записи");
                        int m2 = Convert.ToInt32(Console.ReadLine());
                        switch (m2)
                        {
                            case 1:
                                ts.Del(S);
                                break;
                            case 2:
                                ts.Add();
                                break;
                            case 3:
                                ts.Show(S);
                                break;
                            default:
                                Console.WriteLine("Такого варианта нет");
                                break;
                        }
                        break;
                    case 3:
                        TableSupplies tsp = new TableSupplies();
                        List<Supplies> Sp = new List<Supplies>();
                        Console.WriteLine("Что хотите сделать с таблицей?\n1)Удалить запись из таблицы\n2)Добавить запись в таблицу\n3)Просмотреть записи");
                        int m3 = Convert.ToInt32(Console.ReadLine());
                        switch (m3)
                        {
                            case 1:
                                tsp.Del(Sp);
                                break;
                            case 2:
                                tsp.Add();
                                break;
                            case 3:
                                tsp.Show(Sp);
                                break;
                            default:
                                Console.WriteLine("Такого варианта нет");
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("Такого действия нет");
                        break;
                }
                Console.WriteLine("Хотите продолжить работу?\n1)Да\n2)Нет");
                int w = Convert.ToInt32(Console.ReadLine());
                if (w == 2)
                {
                    break;
                }
            }
        }
        public void SelectAd()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Введите что хотите сделать:" +
                    "\n1)Просмотреть всех пользователей\n2)Удалить пользователя\n3)Добавить пользователя");
                int a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        TableUsers tu1 = new TableUsers();
                        List<Users> U1 = new List<Users>();
                        tu1.Show(U1);
                        break;
                    case 2:
                        TableUsers tu2 = new TableUsers();
                        List<Users> U2 = new List<Users>();
                        tu2.Show(U2);
                        tu2.Del(U2);
                        break;
                    case 3:
                        TableUsers tu3 = new TableUsers();
                        List<Users> U3 = new List<Users>();
                        tu3.Add();
                        break;
                    default:
                        Console.WriteLine("Такого действия нет");
                        break;
                }
                Console.WriteLine("Хотите продолжить работу?\n1)Да\n2)Нет");
                int w = Convert.ToInt32(Console.ReadLine());
                if (w == 2)
                {
                    break;
                }
            }
        }
    }
}
