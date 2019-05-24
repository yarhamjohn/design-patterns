using System;
using Singleton.Singleton;

namespace Singleton
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var balancer1 = LoadBalancer.GetLoadBalancer();
            var balancer2 = LoadBalancer.GetLoadBalancer();
            var balancer3 = LoadBalancer.GetLoadBalancer();
            var balancer4 = LoadBalancer.GetLoadBalancer();

            if (balancer1 == balancer2 && balancer2 == balancer3 && balancer3 == balancer4)
            {
                Console.WriteLine("The load balancers are all the same instance");
            }
            else
            {
                Console.WriteLine("The load balancers are different instances");
            }
        }
    }
}
