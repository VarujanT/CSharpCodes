using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using static System.Console;

namespace LateBinding
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Enter Assembly Path...");
            string asmName = @"C:\Users\LabUser26\Desktop\OOP Varujan Mets\Student.dll\Student.dll\bin\Debug\Student.dll.dll";
            Assembly asm = Assembly.LoadFile(asmName);
            Write("Enter Class Name");
            string className = "Student.dll.Student";//ReadLine();
            Type typeStudent = asm.GetType(className);
            object o = Activator.CreateInstance(typeStudent);
            MethodInfo mi = typeStudent.GetMethod("First", new Type[]{});
            mi.Invoke(o, null);
            mi = typeStudent.GetMethod("Second", new Type[] { typeof(int), typeof(bool) });
            mi.Invoke(o, new object[] { 10, true });
        }
    }
}