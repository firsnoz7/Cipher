using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core
{
    public abstract class Cipher
    {
        protected static int alph_size;
        public abstract string encrypt(string s);
        public abstract string decrypt(string s);
    }

}
