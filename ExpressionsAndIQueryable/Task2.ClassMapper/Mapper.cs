using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Task2.ClassMapper
{
    public class Mapper<TSource, TDestination> : IMapper<TSource, TDestination>
    {
        private readonly Func<TSource, TDestination> converter;
        private readonly Type outType;
        private readonly Type inType;

        internal Mapper()
        {
            outType = typeof(TDestination);
            inType = typeof(TSource);

            var sourceParam = Expression.Parameter(inType);            
            List<MemberBinding> propList = GetMembers(sourceParam);
            var init = Expression.MemberInit(Expression.New(outType), propList);
            
            converter = Expression.Lambda<Func<TSource, TDestination>>(init, sourceParam).Compile();
        }

        public TDestination Map(TSource source)
        {
            return converter.Invoke(source);
        }

        private List<MemberBinding> GetMembers(ParameterExpression sourceParam)
        {
            var sourceProperties = inType.GetProperties();
            var result = new List<MemberBinding>();
            var outProperties = outType.GetProperties().ToDictionary(p => p.Name);

            foreach (var prop in sourceProperties)
            {
                if (outProperties.TryGetValue(prop.Name, out var outProperty))
                {
                    var accessMember = Expression.MakeMemberAccess(sourceParam, prop);
                    var assignMember = Expression.Bind(outProperty, accessMember);

                    result.Add(assignMember);
                }
            }

            return result;
        }
    }
}
