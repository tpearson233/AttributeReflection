using System;
using System.Reflection;

namespace AttributeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Person p = new Person() {Name="Terrance",Id="1234"};

            GetPropertyValues(p);
            //string jsonStr= MyJsonParser.parse(a);

            
        }
        public static void GetPropertyValues(Object obj)        
    {
            
            Type t = obj.GetType();
            PropertyInfo[] props = t.GetProperties();
              foreach (var prop in props)
              {
                  if(prop.GetIndexParameters().Length==0)
                  Console.WriteLine(" {0}",prop.GetValue(obj));
              }
     

    }
    }
}
