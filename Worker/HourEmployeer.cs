using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker
{
    /// <summary>
    /// Работник с почасовой оплатой.
    /// </summary>
    [Serializable]
    public class HourEmployeer : IEmployeer

    {
        /// <summary>
        /// Фамилия работника
        /// </summary>
        private string _surname;
        
        /// <summary>
        /// Имя работника
        /// </summary>
        private string _name;
        
        /// <summary>
        /// Возраст работника
        /// </summary>
        private int _age;

        /// <summary>
        /// Цена в час
        /// </summary>
        private int _hourCost;
      
        /// <summary>
        /// Отработанные часы
        /// </summary>
        private int _hoursWorked;
       
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="age"></param>
        /// <param name="hoursCost"></param>
        /// <param name="hoursWorked"></param>
        public HourEmployeer(string name, string surname, int age, int hoursCost, int hoursWorked)
        {
            Name = name;
            Surname = surname;
            Age = age;
            HourCost = hoursCost;
            HoursWorked = hoursWorked;
        }
        public HourEmployeer()
        {

        }

        ///<summary>
        ///Аксессор имени
        ///</summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = DataChecking.SetChecking(value);
            }
        }
       
        /// <summary>
        /// Аксессор Фамилии
        /// </summary>
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = DataChecking.SetChecking(value);
            }
        }
       
        /// <summary>
        /// Аксессор возраста
        /// </summary>
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 18)
                    throw new Exception("Лицам до 18 лет регистрация запрещена");
                else
                {
                    _age = value;
                }
            }
        }

      
        /// <summary>
        /// Свойство, возвращающее стоимость часа работы
        /// </summary>
        public int HourCost
        {
            get
            {
                return _hourCost;
            }
            set
            {
                if (value < 150)
                {
                    throw new Exception();
                }
                _hourCost = value;
            }
        }
     
        /// <summary>
        /// Получение суммы отработанных часов
        /// </summary>
        public int HoursWorked
        {
            get { return _hoursWorked; }
            set
            {
                if (value < 0 || value > 300)
                {
                    throw new ArgumentException();
                }
                _hoursWorked = value;
            }
        }
        
        /// <summary>
        /// Сумма отработанных часов*Стоймость часа
        /// </summary>
        /// <returns></returns>
        public double Salary { get
            {
                return (_hoursWorked * _hourCost);
            } }


    }
}
