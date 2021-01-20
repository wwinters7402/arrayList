using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;

namespace arrayList
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ListArray()
        {
            ArrayList myArray = new ArrayList();
            myArray.Add("Today");
            myArray.Add(2);
            myArray.Add(20M);
            System.Console.WriteLine(myArray.Count);



        }













    }
}




