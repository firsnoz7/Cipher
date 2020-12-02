using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cipher
{
    //Фабрика Виженера.
    public class Vigenere_Cipher_Fabric : Abstract_Cipher_Fabric
    {
        public Vigenere_Cipher_Fabric() { }
        //Сделать список рабочих
        public override List<Abstract_Cipher> make_product(int n, string key)
        {
            for (int i = 0; i < key.Length; i++)
                if ((int)key[i] >= 123)
                    throw new ArgumentException("В ключе шифра виженера есть запрещённый символ " + key[i]);
            List<Abstract_Cipher> l = new List<Abstract_Cipher>();
            for (int i = 0; i < n; i++)
                l.Add(new Vigenere_Cipher(key));
            return l;
        }
        public override List<string> split(string text, int max_count_of_workers, string key)
        {
            List<string> result = new List<string>();
            int cout_of_words_for_each = text.Length / key.Length / max_count_of_workers;
            for (int i = 0; i < max_count_of_workers; i++)
            {
                result.Add("");
                for (int j = 0; j < key.Length * cout_of_words_for_each; j++)
                    result[i] += text[i * key.Length * cout_of_words_for_each + j];
            }
            for (int i = max_count_of_workers * cout_of_words_for_each * key.Length; i < text.Length; i++)
                result[max_count_of_workers - 1] += text[i];
            return result;
            
        }
    }
}
