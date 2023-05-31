using System;
using System.ServiceModel;

namespace EmployeeWebServiceHost
{
    public class Program
    {
        static void Main(string[] args)
        {
            using(ServiceHost host = new ServiceHost(typeof(EmployeeWebService.EmployeeService)))
            {
                host.Open();
                Console.WriteLine("Host started @" + DateTime.Now);
                Console.ReadLine();
            }
        }
    }
}
