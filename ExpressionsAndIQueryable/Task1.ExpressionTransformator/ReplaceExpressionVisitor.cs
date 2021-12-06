using System;
using System.Linq.Expressions;

namespace Task1.ExpressionTransformator
{
    public class ReplaceExpressionVisitor : ExpressionVisitor
    {
		public int indent = 0;

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
            var nodeType = node.NodeType;

            if (nodeType == ExpressionType.Add || nodeType == ExpressionType.Subtract)
            {
                ParameterExpression param = null;
                ConstantExpression constant = null;

                if (node.Left.NodeType == ExpressionType.Parameter)
                {
                    param = (ParameterExpression)node.Left;
                }
                else if (node.Left.NodeType == ExpressionType.Constant)
                {
                    constant = (ConstantExpression)node.Left;
                }

                if (node.Right.NodeType == ExpressionType.Parameter)
                {
                    param = (ParameterExpression)node.Right;
                }
                else if (node.Right.NodeType == ExpressionType.Constant)
                {
                    constant = (ConstantExpression)node.Right;
                }

                if (param != null && constant != null && constant.Type == typeof(int) && (int)constant.Value == 1)
                {
                    return nodeType == ExpressionType.Add ? Expression.Increment(param) : Expression.Decrement(param);
                }

            }
            return base.VisitBinary(node);
        }
	}
}
