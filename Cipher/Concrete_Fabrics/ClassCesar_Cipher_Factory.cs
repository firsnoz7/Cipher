using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cipher
{
    //Фабрика Цезаря, которая умеет "выпускать" группы рабочих и разбивать текст.
    public class Cesar_Cipher_Fabric : Abstract_Cipher_Fabric
    {
        public Cesar_Cipher_Fabric() { }
        //Сделать список рабочих
        public override List<Abstract_Cipher> make_product(int n, string key)
        {
            int x;
            if (!int.TryParse(key, out x))
                throw new ArgumentException("Для шифра Цезаря ключ должен быть целым чилом");
            List<Abstract_Cipher> l = new List<Abstract_Cipher>();
            for (int i = 0; i < n; i++)
                l.Add(new Cesar_Cipher(x));
            return l;
        }
        public override List<string> split(string text, int max_count_of_workers, string key)
        {
            List<string> result = new List<string>();
            int cout_of_letter_for_each = text.Length / max_count_of_workers;
            for (int i = 0; i < max_count_of_workers; i++)
            {
                result.Add("");
                for (int j = 0; j < cout_of_letter_for_each; j++)
                    result[i] += text[i * cout_of_letter_for_each + j];
            }
            for (int i = max_count_of_workers * cout_of_letter_for_each; i < text.Length; i++)
                result[max_count_of_workers - 1] += text[i];
            return result;
        }
    }
}
