using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core
{
    public class owner
    {
        public static int alph_size;
        List<factory> factories;

        public owner(int size) {
            factories = new List<factory>() { 
                new caesar_factory(), 
                new vigenere_factory(), 
                new atbash_factory() };
            alph_size = size; 
        }
    }
}
