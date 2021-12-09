using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Task2.ClassMapper
{
    [TestClass]
    public class MapperTest
    {
        [TestMethod]
        public void TestMapping()
        {
            var mapGenerator = new MappingGenerator();
            var mapper = mapGenerator.Generate<Foo, Bar>();

            var foo = new Foo()
            {
                Id = Guid.NewGuid(),
                Description = "Foo object"
            };
            var bar = mapper.Map(foo);

            Console.WriteLine($"foo id: {foo.Id}, foo description: {foo.Description}");
            Console.WriteLine($"bar id: {bar.Id}, bar description: {bar.Description}");
        }
    }

    public class Foo 
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
    }

    public class Bar 
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
    }
}
