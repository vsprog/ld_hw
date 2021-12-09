namespace Task2.ClassMapper
{
    public class MappingGenerator
    {
        public IMapper<TSource, TDestination> Generate<TSource, TDestination>()
        {
            return new Mapper<TSource, TDestination>();
        }
    }
}
