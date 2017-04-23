using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker
{ 
   /// <summary>
   /// Класс для проверки правильности ввода имени и фамилии
   /// </summary>
   public static class DataChecking
    {
        /// <summary>
        /// Статический класс проверяющий на содержания в строке не буквенные символы
        /// </summary>
        /// <param name="val"></param>
        /// <returns>Возвратить строку с большой буквы</returns>
        public static string SetChecking(string val)
        {
            val = val.Trim();
            for (int i = 0; i < val.Length; i++)
            {
                if(!Char.IsLetter(val[i]))
                {
                    throw new ArgumentException("Имя содержит неправильные символы");

                }
            }
            return (val.Substring(0, 1).ToUpper() + val.Remove(0, 1));
        }
            }

}
