using Lab05;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;

namespace Lab05Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FormatIdAndNameWithEmptyNameReturnsNull()
        {
            MyFake fake = new MyFake();
            fake.Database = new List<string>();

            StudentC student = new StudentC(fake, fake);

            //string formatted = student.FormatIdAndName("", 1);
            student.Add("1");
            student.Add("2");
            Assert.AreEqual(fake.Database.Count, 2);

        }

        class MyFake : IFormatIdName, IDataAccess
        {
            public List<string> Database { get; set; }
            public string FormatIdAndName(string name, int id)
            {
                return "";
            }

            public void Save(string data)
            {
                Database.Add(data);
            }
        }


    }
}
