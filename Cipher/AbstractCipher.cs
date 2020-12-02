using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cipher
{
    //Абстрактный шифр
    public abstract class Abstract_Cipher
    {
        public static int alph_size = 123;
        abstract public string encrypt(string s);
        abstract public string decrypt(string s);
    }
}
