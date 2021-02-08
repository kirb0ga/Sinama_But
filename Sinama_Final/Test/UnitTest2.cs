using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sinama_Final;

namespace Test
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            Users u = new Users();
            u.Ad = "admin";
            u.Id = 1;
            u.KullaniciAdi = "admin";
            u.Parola = "123";
            u.Soyad = "admin";

        }
    }
}
