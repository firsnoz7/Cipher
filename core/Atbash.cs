using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core
{
    public class Atbash : Cipher
    {
        public Atbash() { }
        public static void set_key(int s) { alph_size = s; }
        public override string encrypt(string s)
        {
            return new string(s.Select(x => (char)(owner.alph_size - (int)x - 1)).ToArray());
        }

        public override string decrypt(string s)
        {
            return new string(s.Select(x => (char)(owner.alph_size - (int)x - 1)).ToArray());
        }
    }
}
