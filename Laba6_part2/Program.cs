using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Laba6_part2
{
    class Program
    {
   
            public static bool GetPropertyAttribute(PropertyInfo checkType, Type attributeType, out object attribute)
            {
                bool Result = false;
                attribute = null;
     
                var isAttribute = checkType.GetCustomAttributes(attributeType, false);
                if (isAttribute.Length > 0)
                {
                    Result = true;
                    attribute = isAttribute[0];
                }

                return Result;
            }


            static void Main(string[] args)
            {
                Type t = typeof(Circle);

                Console.WriteLine("Тип " + t.FullName + " унаследован от " + t.BaseType.FullName);
                Console.WriteLine("Пространство имен " + t.Namespace);
                Console.WriteLine("Находится в сборке " + t.AssemblyQualifiedName);

                Console.WriteLine("\nКонструкторы:");
                foreach (var x in t.GetConstructors())
                {
                    Console.WriteLine(x);
                }

                Console.WriteLine("\nМетоды:");
                foreach (var x in t.GetMethods())
                {
                    Console.WriteLine(x);
                }

                Console.WriteLine("\nСвойства:");
                foreach (var x in t.GetProperties())
                {
                    Console.WriteLine(x);
                }

                Console.WriteLine("\nПоля данных (public):");
                foreach (var x in t.GetFields())
                {
                    Console.WriteLine(x);
                }

                Console.WriteLine("\nСвойства, помеченные атрибутом:");
                foreach (var x in t.GetProperties())
                {
                    object attrObj;
                    if (GetPropertyAttribute(x, typeof(NewAttribute), out attrObj))
                    {
                        NewAttribute attr = attrObj as NewAttribute;
                        Console.WriteLine(x.Name + " - " + attr.Description);
                    }
                }

                Console.WriteLine("\nВызов метода:");

       
                Circle fi = (Circle)t.InvokeMember(null, BindingFlags.CreateInstance, null, null, new object[] { });

                object[] parameters = new object[] { 3, 2 };

                object Result = t.InvokeMember("example", BindingFlags.InvokeMethod, null, fi, parameters);
                Console.WriteLine("example(3,2)={0}", Result);

                Console.ReadLine();
            }
    }
}