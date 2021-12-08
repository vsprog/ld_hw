using System;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Homework.LinqProvider
{
	public class DataTableExpressionsTranslator : ExpressionVisitor
	{
		StringBuilder resultString;

		public string Translate(Expression exp)
		{
			resultString = new StringBuilder();
			Visit(exp);

			return resultString.ToString();
		}

		protected override Expression VisitMethodCall(MethodCallExpression node)
		{
			if (node.Method.DeclaringType == typeof(Queryable) && node.Method.Name == "Where")
			{
				var predicate = node.Arguments[1];
				Visit(predicate);

				return node;
			}

			if (node.Method.DeclaringType == typeof(string))
            {
				string pattern = ((node.Arguments[0] as ConstantExpression).Value as string).Replace("\"", ""); ;
				string template = node.Method.Name switch
                {
                    "StartsWith" => $"{pattern}%",
                    "EndsWith" => $"%{pattern}",
                    "Contains" => $"%{pattern}%",
                    _ => throw new NotSupportedException(string.Format("Method {0} is not supported", node.Method.Name)),
                };
                Visit(node.Object);
				resultString.Append($" LIKE '{template}'");

				return node;
			}

			return base.VisitMethodCall(node);
		}

		protected override Expression VisitBinary(BinaryExpression node)
		{
			var leftNode = node.Left;
			var rightNode = node.Right;

			switch (node.NodeType)
			{
				case ExpressionType.Equal:
					if (leftNode.NodeType == ExpressionType.Constant && rightNode.NodeType == ExpressionType.MemberAccess)
                    {
						leftNode = node.Right;
						rightNode = node.Left;
					}

					if (!(leftNode.NodeType == ExpressionType.MemberAccess))
						throw new NotSupportedException(string.Format("Left operand should be property or field", node.NodeType));

					if (!(rightNode.NodeType == ExpressionType.Constant))
						throw new NotSupportedException(string.Format("Right operand should be constant", node.NodeType));

					Visit(leftNode);
					resultString.Append(" = '");
					Visit(rightNode);
					resultString.Append("'");
					break;

				case ExpressionType.And:
				case ExpressionType.AndAlso:
					Visit(leftNode);
					resultString.Append(" AND ");
					Visit(rightNode);
					break;

				default:
					throw new NotSupportedException(string.Format("Operation {0} is not supported", node.NodeType));
			};

			return node;
		}

		protected override Expression VisitMember(MemberExpression node)
		{
			resultString.Append(node.Member.Name);
			return base.VisitMember(node);
		}

		protected override Expression VisitConstant(ConstantExpression node)
		{
			resultString.Append(node.Value);
			return node;
		}
	}
}
