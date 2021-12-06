using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq.Expressions;

namespace Task1.ExpressionTransformator
{
    [TestClass]
    public class VisitExpressionTest
    {
        [TestMethod]
        public void TestVisit()
        {
            Expression<Func<int, int>> source = (a) => 3 * (a - 1) * (a + 1);
            Expression<Func<int, int>> changed = new ReplaceExpressionVisitor().VisitAndConvert(source, String.Empty);
            

            Console.WriteLine($"source expression: {source}\nresult: {source.Compile().Invoke(2)}");
            Console.WriteLine($"changed expression: {changed}\nresult: {changed.Compile().Invoke(2)}");

        }
    }
}
