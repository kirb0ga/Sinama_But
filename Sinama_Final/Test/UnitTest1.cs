using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sinama_Final;


namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Tasks tsk = new Tasks();
            tsk.Id = 1;
            tsk.Gorevli = 2;
            tsk.Aciklama = "açıklama";
            tsk.Baslik = "baslik";
        }
    }
}
