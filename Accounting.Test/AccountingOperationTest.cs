using Accounting.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Test
{
    internal class AccountingOperationTest
    {
        [Test]
        public void SumTwoValuesTest()
        {
            AccountingOperation accountingOperation = new AccountingOperation();

            int result = accountingOperation.SumTwoValues(4, 5);
            Assert.AreEqual(9, result);
        }

        [TestCase(5,5,ExpectedResult =10)]
        [TestCase(5,20,ExpectedResult =25)]
        public int SumTwoValuesTestCases(int x, int y)
        {
            AccountingOperation accountingOperation = new AccountingOperation();

            return accountingOperation.SumTwoValues(x,y);
        }
    }
}
