using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cipher;

namespace tests
{
    [TestClass]
    public class Cipher_tests
    {
        [TestMethod]
        public void cipher_test1()
        {
            /*Cesar_Cipher ces = new Cesar_Cipher(3);
            Vigenere_Cipher v=new Vigenere_Cipher("abc");
            Atbash_Cipher at=new Atbash_Cipher(5);*/
            Cesar_Cipher c1 = new Cesar_Cipher(10);
            Vigenere_Cipher v1 = new Vigenere_Cipher("gfgf");
            Atbash_Cipher a = new Atbash_Cipher();

            string t = "Hi bob";
            Assert.IsTrue(t == c1.decrypt(c1.encrypt(t)));
            Assert.IsTrue(t == v1.decrypt(v1.encrypt(t)));
            Assert.IsTrue(t == a.decrypt(a.encrypt(t)));
            t = "Not yet";
            Assert.IsTrue(t == c1.decrypt(c1.encrypt(t)));
            Assert.IsTrue(t == v1.decrypt(v1.encrypt(t)));
            t = "The American Dream is a national ethos of the United States";
            Assert.IsTrue(t == c1.decrypt(c1.encrypt(t)));
            Assert.IsTrue(t == v1.decrypt(v1.encrypt(t)));
            t = "just test it";
            Assert.IsTrue(t == c1.decrypt(c1.encrypt(t)));
            Assert.IsTrue(t == v1.decrypt(v1.encrypt(t)));
        }

        [TestMethod]
        public void cipher_test2()
        {
            Cesar_Cipher c2 = new Cesar_Cipher(5);
            Vigenere_Cipher v2 = new Vigenere_Cipher("xyz");
            Atbash_Cipher a2 = new Atbash_Cipher();

            string t = "Hi bob";
            Assert.IsTrue(t == c2.decrypt(c2.encrypt(t)));
            Assert.IsTrue(t == v2.decrypt(v2.encrypt(t)));
            Assert.IsTrue(t == a2.decrypt(a2.encrypt(t)));
            t = "Not yet";
            Assert.IsTrue(t == c2.decrypt(c2.encrypt(t)));
            Assert.IsTrue(t == v2.decrypt(v2.encrypt(t)));
            t = "The American Dream is a national ethos of the United States";
            Assert.IsTrue(t == c2.decrypt(c2.encrypt(t)));
            Assert.IsTrue(t == v2.decrypt(v2.encrypt(t)));
            t = "just test it";
            Assert.IsTrue(t == c2.decrypt(c2.encrypt(t)));
            Assert.IsTrue(t == v2.decrypt(v2.encrypt(t)));
        }

        [TestMethod]
        public void cipher_test3()
        {
            Cesar_Cipher c = new Cesar_Cipher(7);
            Vigenere_Cipher v2 = new Vigenere_Cipher("mno");
            Atbash_Cipher a2 = new Atbash_Cipher();

            string t = "Booble gum";
            Assert.IsTrue(t == c.decrypt(c.encrypt(t)));
            Assert.IsTrue(t == v2.decrypt(v2.encrypt(t)));
            Assert.IsTrue(t == a2.decrypt(a2.encrypt(t)));
            t = "cat dog";
            Assert.IsTrue(t == c.decrypt(c.encrypt(t)));
            Assert.IsTrue(t == v2.decrypt(v2.encrypt(t)));
            t = "The sun";
            Assert.IsTrue(t == c.decrypt(c.encrypt(t)));
            Assert.IsTrue(t == v2.decrypt(v2.encrypt(t)));
            t = "just test it";
            Assert.IsTrue(t == c.decrypt(c.encrypt(t)));
            Assert.IsTrue(t == v2.decrypt(v2.encrypt(t)));
        }
    }
}
