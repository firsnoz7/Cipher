using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cipher
{
    //Абстрактная фабрика
    public abstract class Abstract_Cipher_Fabric
    {
        public abstract List<Abstract_Cipher> make_product(int n, string key);
        public abstract List<string> split(string text, int max_count_of_workers, string key);
    }
}
