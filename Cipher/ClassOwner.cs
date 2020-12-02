using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cipher
{
      //Класс владельца фабрик. Устанавливает текущую фабрику, 
    //разбивает текст на части, устанавливает ключ рабочим, шифрует, дешефрует. 
    public class owner
    {
        public owner(){}
        Abstract_Cipher_Fabric current; //Текущая фабрика
        //Установка текущей фабрики
        private void set_fabric(int n){
            if(n==1)
                current=new Cesar_Cipher_Fabric();
            if (n == 2)
                current = new Vigenere_Cipher_Fabric();
            if (n == 3)
                current = new Atbash_Cipher_Fabric();
        }
        public string encrypt(string s,int n,int number_of_cipher,string key){
            set_fabric(n);
            List<Abstract_Cipher> l=current.make_product(number_of_cipher,key);
            List<string> part = current.split(s, number_of_cipher,key);
            string result="";
            for (int i = 0; i < part.Count; i++)
            {
                result += l[i].encrypt(part[i]);
            }
            return result;
        }
        public string decrypt(string s, int n, int number_of_cipher, string key)
        {
            set_fabric(n);
            List<Abstract_Cipher> l = current.make_product(number_of_cipher,key);
            List<string> part = current.split(s, number_of_cipher,key);
            string result = "";
            for (int i = 0; i < part.Count; i++)
            {
                result += l[i].decrypt(part[i]);
            }
            return result;
        }
    }

}

