using System;
using FakerLibrary;

namespace StringGenerator
{
    class StringGenerator : IGenerator
    {
        public bool CanGenerate(Type type)
        {
            return type == typeof(string);
        }

        public object Generate(GeneratorContext context)
        {
            return "german";
        }
    }
}
