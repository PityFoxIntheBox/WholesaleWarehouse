using System.Security.Principal;

namespace WholesaleWarehouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Добро пожаловать на склад оптовой торговли");
            Thread.Sleep(1000);
            Console.WriteLine("-_-");
            Thread.Sleep(1000);
            Console.WriteLine("-_0");
            Thread.Sleep(1000);
            Console.WriteLine("^_^");
            Thread.Sleep(1000);
            Auth au = new Auth();
            List<Users> users = new List<Users>();
            while (true)
            {
                int flag = au.entry(ref users, 0);
                if(flag == 0)
                {
                    Console.WriteLine("Вас нет в системе, попробуйте снова");
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine($"Добро пожаловать {users[0].Surname} {users[0].Name} {users[0].Patronymic}");
            Menu menu = new Menu();
            if (users[0].Role == 0)
            {
                Console.WriteLine("Ваша роль - администратор");
                Thread.Sleep(3000);
                menu.SelectAd();
            }
            if (users[0].Role==1)
            {
                Console.WriteLine("Ваша роль - работник бухгалтерии");
                Thread.Sleep(3000);
                menu.SelectAcc();
            }
            if (users[0].Role==2) 
            {
                Console.WriteLine("Ваша роль - работник склада");
                Thread.Sleep(3000);
                menu.SelectStor();
            }

        }
    }
}
