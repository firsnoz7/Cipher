using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cipher
{
    //Шифр Виженера.
    public class Vigenere_Cipher : Abstract_Cipher
    {
        string key;

        public Vigenere_Cipher(string k)
        {
            key = k;
        }
        public override string encrypt(string s)
        {
            char[] res = new char[s.Length];
            int j_key = 0;
            for (int i = 0; i < s.Length; ++i)
            {
                res[i] = (char)(((int)s[i] + (int)key[j_key]) % alph_size);
                j_key = (j_key + 1) % key.Length;
            }

            return new string(res);
        }

        public override string decrypt(string s)
        {
            char[] res = new char[s.Length];
            int j_key = 0;
            for (int i = 0; i < s.Length; ++i)
            {
                res[i] = (char)(((int)s[i] - (int)key[j_key] + alph_size) % alph_size);
                j_key = (j_key + 1) % key.Length;
            }

            return new string(res);
        }
    }
}
