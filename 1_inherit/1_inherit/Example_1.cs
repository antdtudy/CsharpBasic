using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _1_inherit
{
    public  class Example_1
    {
       public static void Show()
        {
            Type t = typeof(SimpleClass);
            BindingFlags flags = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy;

            MemberInfo[] members = t.GetMembers(flags);
            Console.WriteLine($"Type {t.Name} has {members.Length} members: ");

            foreach (var member in members)
            {
                string access = "";
                string stat = "";
                var method = member as MethodBase;
                if (method!=null)
                {
                    if (method.IsPublic)
                        access = "Public";
                    else if (method.IsPrivate)
                        access = "Public";
                    else if (method.IsFamily)
                        access = "Protected";
                    else if (method.IsAssembly)
                        access = "Internal";
                    else if (method.IsFamilyAndAssembly)
                        access = "protected Internal";
                    if (method.IsStatic)
                        stat = "Static";
                    var output = $"{member.Name} ({member.MemberType}): {access}{stat}, Declared by {member.DeclaringType}";
                    Console.WriteLine(output);
                }
            }
        }
    }

   public class SimpleClass
    {

    }
}
