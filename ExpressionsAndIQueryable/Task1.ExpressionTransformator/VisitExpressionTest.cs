using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Task1.ExpressionTransformator
{
    [TestClass]
    public class VisitExpressionTest
    {
        [TestMethod]
        public void TestVisit()
        {
            var argsToReplace = new Dictionary<string, object>
            {
                { "a", 1 },
                { "b", 1 }
            };
            Expression<Func<int, int, int>> source = (a, b) => (2 * b) + (a - 1) + (a + 1) + (a + 3) + 1;
            Expression<Func<int, int, int>> changed = new ReplaceExpressionVisitor(argsToReplace).VisitAndConvert(source, String.Empty);
            

            Console.WriteLine($"source expression: {source}\nresult: {source.Compile().Invoke(2, 2)}");
            Console.WriteLine($"changed expression: {changed}\nresult: {changed.Compile().Invoke(2, 2)}");
        }
    }
}
