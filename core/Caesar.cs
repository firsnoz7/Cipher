using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core
{ 
    public class Caesar : Cipher
    {
        static int key;
        public static void set_key(int k, int s) { key = k; alph_size = s; }
        public Caesar() {  }
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
