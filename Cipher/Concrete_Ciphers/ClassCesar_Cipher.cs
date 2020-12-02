using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cipher
{
    //Шифр Цезаря
    public class Cesar_Cipher : Abstract_Cipher
    {

        int key;
        public Cesar_Cipher(int k) { key = k; }
        public override string encrypt(string s)
        {
            return new string(s.Select(x => (char)(((int)x + key) % alph_size)).ToArray());
        }

        public override string decrypt(string s)
        {
            return new string(s.Select(x => (char)(((int)x - key + alph_size) % alph_size)).ToArray());
        }
    }
}
