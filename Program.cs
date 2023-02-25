using System.Reflection;

namespace UserRegisterationProblemusingReflectionDay22
{
    class program
    {
        public static void Main(string[] args)
        {
            Type c = typeof(PersonDetails);

            ConstructorInfo[] constructorInfos = c.GetConstructors();

            foreach (ConstructorInfo ci in constructorInfos)
            {
                Console.WriteLine(ci);
            }

            MethodInfo[] methodInfos = c.GetMethods();

            foreach (MethodInfo ci in methodInfos)

            {
                Console.WriteLine(ci);
            }
        }
    }
}