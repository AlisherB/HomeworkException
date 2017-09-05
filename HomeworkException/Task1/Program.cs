using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task1
{
    class Program
    {
        /*
         1.	Перехватить исключение запроса к несуществующему веб ресурсу и вывести сообщение о том, что произошла ошибка. 
         Программа должна завершиться без ошибок.
         */
        static void Main(string[] args)
        {
            Write("Введите веб-ресурс: ");
            string web = ReadLine();
            try
            {
                throw new Exception($"Несуществующий веб-ресурс!");
            }
            catch (Exception ex)
            {
                WriteLine(ex);
            }
            ReadLine();
        }
    }
}
