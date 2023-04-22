using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WholesaleWarehouse
{
    internal class Auth
    {
        public string path = "Users.csv";
        public int entry(ref List<Users> U, int flag)
        {
            Console.WriteLine("Введите ваш логин");
            string logcheck = Console.ReadLine();
            Console.WriteLine("Введите ваш пароль");
            string passcheck = Console.ReadLine();
            string surname, name, patr, login, pass;
            int role;
            using (StreamReader sr = new StreamReader(path))
            {
                while (sr.EndOfStream != true)
                {
                    string[] array = sr.ReadLine().Split(';');
                    surname = array[0];
                    name = array[1];
                    patr = array[2];
                    login = array[3];
                    pass = array[4];
                    role = Convert.ToInt32(array[5]);
                    if ((logcheck == login) && (passcheck == pass))
                    {
                        flag = 1;
                        U.Add(new Users
                        {
                            Surname = surname,
                            Name = name,
                            Patronymic = patr,
                            Role = role
                        });
                    }
                }
                sr.Close();
                return flag;
            }
        }
    }
}
