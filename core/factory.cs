using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core
{
    abstract class factory
    {
        public abstract List<Cipher> create_cipher(int arr_len);
    }

    class caesar_factory : factory
    {
        public caesar_factory();
        public override List<Cipher> create_cipher(int arr_len)
        {
            List<Cipher> res = new List<Cipher>(arr_len);
            res.ForEach(x => x = new Caesar());
            return res;
        }
    }

    class vigenere_factory : factory
    {
        public override List<Cipher> create_cipher(int arr_len)
        {
 	        List<Cipher> res = new List<Cipher>(arr_len);
            res.ForEach(x => x = new Vigenere());
            return new List<Cipher>();
        }

    }

    class atbash_factory : factory
    {
        public override List<Cipher> create_cipher(int arr_len)
        {
            List<Cipher> res = new List<Cipher>(arr_len);
            res.ForEach(x => x = new Atbash());
            return new List<Cipher>();
        } 
    }
}
