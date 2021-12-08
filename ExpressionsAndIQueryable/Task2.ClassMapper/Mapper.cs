using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Task2.ClassMapper
{
    public class Mapper<TSource, TDestination> : IMapper<TSource, TDestination>
    {
        private readonly Func<TSource, TDestination> converter;

        internal Mapper()
        {
            var sourceParam = Expression.Parameter(typeof(TSource));            
            var init = DestinationCtorExpression(sourceParam);

            converter = Expression.Lambda<Func<TSource, TDestination>>(init, sourceParam).Compile();
        }

        public TDestination Map(TSource source)
        {
            return converter.Invoke(source);
        }

        private MemberInitExpression DestinationCtorExpression(ParameterExpression sourceParam)
        {
            var outType = typeof(TDestination);
            var sourceProperties = typeof(TSource).GetProperties();
            var propList = new List<MemberBinding>();
            var outProperties = outType.GetProperties().ToDictionary(p => p.Name);

            foreach (var prop in sourceProperties)
            {
                if (outProperties.TryGetValue(prop.Name, out var outProperty))
                {
                    var accessMember = Expression.MakeMemberAccess(sourceParam, prop);
                    var assignMember = Expression.Bind(outProperty, accessMember);

                    propList.Add(assignMember);
                }
            }

            return Expression.MemberInit(Expression.New(outType), propList);
        }
    }
}
