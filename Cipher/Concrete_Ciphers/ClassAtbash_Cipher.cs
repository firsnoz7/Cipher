using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cipher
{
    public class Atbash_Cipher : Abstract_Cipher
    {
        public Atbash_Cipher() 
        {        }
        public static void set_key(int s) { }
        public override string encrypt(string s)
        {
            return new string(s.Select(x => (char)(alph_size - (int)x - 1)).ToArray());
        }

        public override string decrypt(string s)
        {
            return new string(s.Select(x => (char)(alph_size - (int)x - 1)).ToArray());
        }
    }
}
