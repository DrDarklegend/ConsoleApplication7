using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worker;

namespace WorkerConsole  
{
    class Program
    { 
    static void Main(string[] args)
    {
            //Создание объектов
            var empl1 = new HourEmployeer("Пётр","Малышев",23,165,150);
            var empl2 = new HourEmployeer("Пётр", "Малышев", 21, 150, 120);
            var empl3 = new PaymentOfSalary("Генадий", "Чёрный", 60, 33000, 0.3, 30);
            var empl4 = new PaymentOfSalary("Валерий", "Петрович", 29, 31000, 1.0, 1);
            //Создание списка
            var Employeer = new List<IEmployeer> { empl1, empl2, empl3, empl4 };
            //Запросить запись данных о работнике у пользователя
            Console.WriteLine("Введите имя работника, фамилию, возраст, оклад, ставка работника, стаж");
            //Проверка
            try
            {
                empl4.Name = Console.ReadLine();
                empl4.Surname = Console.ReadLine();
                empl4.Age = Convert.ToInt32(Console.ReadLine());
                empl4.Salary = Convert.ToInt32(Console.ReadLine());
                empl4.Rate = Convert.ToDouble(Console.ReadLine());
                empl4.Experience = Convert.ToInt32(Console.ReadLine());
            }
            //Есть ошибка
            catch (FormatException)
            {
                Console.WriteLine("Ошибка, несоответствие форматов");
            }
            //Перебор объектов
            foreach (var empl in Employeer)
            {
                Console.WriteLine("{0}, {1}, возраст {2} лет, Расчёт зарабатной платы {3},",
                empl.Name, empl.Surname, empl.Age, empl.CalculateSalary());
            }
            Console.WriteLine(salaryformonth.WorkingDaysInMonth[(DateTime.Now.Month - 1)]);
            Console.ReadKey();
        }

    }
}
