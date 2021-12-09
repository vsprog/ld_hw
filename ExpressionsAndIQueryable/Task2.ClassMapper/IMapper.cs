using System;
using System.Collections.Generic;
using System.Text;

namespace Task2.ClassMapper
{
    public interface IMapper<in TSource, out TDestination>
    {
        TDestination Map(TSource source);
    }
}
