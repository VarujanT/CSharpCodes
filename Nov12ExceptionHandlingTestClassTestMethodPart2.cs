using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class TestClass
    {
        public static int TestMethod(int a, DateTime tm, double d)
        {
            try
            {
                if (a ==0)
                {
                    ZeroParamException ze = new ZeroParamException();
                    ze.HelpLink = "Facebook.com";
                    ze.Data.Add("Name", "Artak");
                    ze.Data.Add("Height", 1.85);
                    throw new ZeroParamException("First Exception");
                }
                Console.WriteLine(a.ToString("C"));
                if (tm.Hour < 12)
                {
                    throw new MorningException("Early Morning");
                }
                if (tm.Hour > 6 )
                {
                    throw new EveningException("Late Evening");
                }
                Console.WriteLine(tm.ToLongTimeString());
                if(d == 3.14)
                {
                    throw new PiException("It's Known Constant");
                }
                Console.WriteLine(d * d);
                
            }
            //catch (ZeroParamException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            catch (MorningException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (EveningException e)
            {
                Console.WriteLine(e.Message);
            }
            //catch (PiException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            return a * a * a;

        }
    }

    public class ZeroParamException:ApplicationException
    {
        public ZeroParamException(string msg = "Param is Zero"): base(msg)
        {

        }
    }

    public class MorningException : Exception
    {
        public MorningException(string msg = "Good Morning") : base(msg)
        {

        }
    }
    public class EveningException : SystemException
    {
        public EveningException(string msg = "Good Evening") : base(msg)
        {

        }
    }
    public class PiException : ApplicationException
    {
        public PiException(string msg = "Good Pi") : base(msg)
        {

        }
    }
}