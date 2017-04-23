using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker
{
   /// <summary>
   /// Интерфейс работников  
   /// </summary>
  public  interface IEmployeer
    {
        /// <summary>
        /// Имя работника
        /// </summary>
        string Name { get; set; }
        
        /// <summary>
        /// Фамилия работника
        /// </summary>
        string Surname { get; set; }
        
        /// <summary>
        /// Возраст работника
        /// </summary>
        int Age { get; set; }
        
        /// <summary>
        /// Расчёт заработной платы
        /// </summary>
        /// <returns>Размер заработной платы</returns>
        double Salary { get; }


    }
}
