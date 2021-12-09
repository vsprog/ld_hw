using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Task1.ExpressionTransformator
{
    public class ReplaceExpressionVisitor : ExpressionVisitor
    {
		public int indent = 0;
        private readonly IDictionary<string, object> paramsToReplace;

        public ReplaceExpressionVisitor(IDictionary<string, object> replacers)
        {
            paramsToReplace = replacers;
        }
        
        public override Expression Visit(Expression node)
		{
			if (node == null) return base.Visit(node);

			Console.WriteLine("{0}{1} - {2}", new String(' ', indent * 4), node.NodeType, node.GetType());

			indent++;
			Expression result = base.Visit(node);
			indent--;

			return result;
		}

		protected override Expression VisitBinary(BinaryExpression node)
        {
            if (node.Right.NodeType == ExpressionType.Constant && (int)(node.Right as ConstantExpression).Value == 1)
            {
                if (node.NodeType == ExpressionType.Add)
                {
                    return VisitUnary(Expression.Increment(node.Left));
                }

                if (node.NodeType == ExpressionType.Subtract)
                {
                    return VisitUnary(Expression.Decrement(node.Left));
                }
            }

            return base.VisitBinary(node);
        }

        protected override Expression VisitLambda<T>(Expression<T> node)
        {
            if (node is null)
            {
                throw new ArgumentNullException(nameof(node));
            }

            return Expression.Lambda(Visit(node.Body), node.Parameters);
        }

        protected override Expression VisitParameter(ParameterExpression node)
        {
            if (paramsToReplace.TryGetValue(node.Name, out object constValue))
            {
                return Expression.Constant(constValue);
            }

            return base.VisitParameter(node);
        }
    }
}
