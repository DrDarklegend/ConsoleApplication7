using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker
{

    /// <summary>
    /// Работник по окладу
    /// </summary>
    [Serializable]
    public class PaymentOfSalary : IEmployeer
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
        /// Оклад
        /// </summary>
        private int _monthCost;
       
        /// <summary>
        /// Процент от стажа работы
        /// </summary>
        private int _percentageoftime;
      
        /// <summary>
        /// Ставка
        /// </summary>
        private double _rate;
      
        /// <summary>
        /// Стаж
        /// </summary>
        private int _experience;
      
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="age"></param>
        /// <param name="salary"></param>
        /// <param name="rate"></param>
        /// <param name="experience"></param>
        public PaymentOfSalary(string name,string surname, int age,int salary,double rate,int experience)
        {
            Name = name;
            Surname = surname;
            Age = age;
            MonthCost = salary;
            Rate = rate;
            Experience = experience;
        }
        public PaymentOfSalary()
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
                if (value < 18 || value > 150)
                    throw new Exception("Лицам до 18 лет регистрация запрещена");
                else
                {
                    _age = value;
                }
            }
        }
       
        /// <summary>
        /// Оклад
        /// </summary>
        public int MonthCost
        {
            get
            {
                return _monthCost;
            }
            set
            {
                if (value < 30000 || value > 1000000)
                {

                    throw new ArgumentException("Оклад не долден быть меньше 30тысяч и больше миллиона");
                }

                _monthCost = value;

            }
        }
       
        /// <summary>
        /// Ставка работника
        /// </summary>
        public double Rate
        {
            get
            {
                return _rate;
            }
            set
            {
                if (value < 0 || value > 1) 
                {
                    throw new ArgumentException("Ставка не должна быть меньше нуля и больше единицы");
                }
                _rate = value;
            }

        }

        ///<summary>
        ///Стаж
        ///</summary>
        public int Experience
        {
            get
            {
                return _experience;
            }
            set
            {
                if (value < 0 || value > 30)
                {
                    throw new ArgumentException("Стаж работы не может превышать 30 лет");
                }
            }

        }

        public double Salary { get { return (_monthCost * _rate * (1 + (_experience * 1.0 / 3.0))); } }
    }
}


