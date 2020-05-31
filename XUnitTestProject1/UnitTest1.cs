using BankApp;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }
        [Fact]
        public void Test2()
        {
            var account = new Bankfunct("Kendra", 10000);

            Assert.Throws<InvalidOperationException> (
                
                ()=> account.MakeWithrawl(750000, DateTime.Now, "Attempt to Overdraw")

                );
        }
        [Fact]
        public void Test3()
        {
            var account = new Bankfunct("Kendra", 10000);

            Assert.Throws<ArgumentOutOfRangeException>(

                () => new Bankfunct("Invalid", -50)

                );
        }
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, Add(2, 2));
        }
        [Fact]
        public void PassingTest1()
        {
            Assert.Equal(4, Add(2, 2));
        }
        [Fact]
        public void FailingTest()
        {
            Assert.Equal(5, Add(2, 2));
        }

        int Add(int x, int y)
        {
            return x + y;
        }
    }
}
