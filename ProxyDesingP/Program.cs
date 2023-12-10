using System;

namespace Proxy
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Proxy proxy = new Proxy();
            proxy.Request();


            Console.ReadKey(); //Codu saxlama
        }
    }



    public abstract class Subject
    {
        public abstract void Request();
    }



    public class RealSubject : Subject
    {
        public override void Request()
        {
            Console.WriteLine(" RealSubjectn Request");
        }
    }



    public class Proxy : Subject
    {
        private RealSubject ?realSubject;

        public override void Request()
        {

            if (realSubject == null)
            {
                realSubject = new RealSubject();
            }

            realSubject.Request();
        }
    }
}

