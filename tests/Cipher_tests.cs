using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using core;

namespace tests
{
    [TestClass]
    public class Cipher_tests
    {
        [TestMethod]
        public void cipher_test1()
        {
            Caesar.set_key(10, 123);
            Vigenere.set_key("abcde", 123);
            Atbash.set_key(123);
            Caesar c1 = new Caesar();
            Vigenere v1 = new Vigenere();
            Atbash a = new Atbash();

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
            Caesar.set_key(5, 123);
            Vigenere.set_key("FBI", 123);
            Atbash.set_key(123);
            Caesar c2 = new Caesar();
            Vigenere v2 = new Vigenere();
            Atbash a = new Atbash();

            string t = "Hi bob";
            Assert.IsTrue(t == c2.decrypt(c2.encrypt(t)));
            Assert.IsTrue(t == v2.decrypt(v2.encrypt(t)));
            Assert.IsTrue(t == a.decrypt(a.encrypt(t)));
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
    }
}
