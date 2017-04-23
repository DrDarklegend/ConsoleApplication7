using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using Worker;

namespace Forms

{
    [Serializable]
    class Serialization
    {
        private static readonly BinaryFormatter _formatter = new BinaryFormatter();
        public static void Serialize(string fileName, List<IEmployeer> file)
        {
            using (var fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                _formatter.Serialize(fs, file);
            }
        }

        public static List<IEmployeer> Deserialize(string fileName)
        {
            using (var fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                var file = (List<IEmployeer>)_formatter.Deserialize(fs);
                return file;
            }
        }
    }
}
