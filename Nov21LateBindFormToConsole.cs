using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace LateBindFormToConsole
{
    class Program
    {
        #region Assembly System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
        // C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.6.1\System.Windows.Forms.dll
        #endregion

        static void Main(string[] args)
        {
            Assembly asm = Assembly.Load(@"System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089");
            Console.WriteLine(asm.GetName());
            Console.WriteLine(asm.GetName().Version);
            Type type = asm.GetType("System.Windows.Forms.Form");
            //foreach (var v in type.GetMethods())
            //{
            //    Console.WriteLine(v.Name);
            //}
            Object o = Activator.CreateInstance(type);
            MethodInfo mi = type.GetMethod("Show", new Type[0]);
            mi.Invoke(o, null);
            Console.ReadKey();
            Type typeapp = asm.GetType("System.Windows.Forms.Application");
            MethodInfo miRun = typeapp.GetMethod("Run", new Type[0]);
            miRun.Invoke(null, null);
        }
    }
}