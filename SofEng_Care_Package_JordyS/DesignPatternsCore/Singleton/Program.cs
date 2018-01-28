﻿using System;

namespace Singleton
{
    /// <summary>
    /// Ensure a class has only one instance and provide a global point of access to it.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            LoadBalancer b1 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b2 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b3 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b4 = LoadBalancer.GetLoadBalancer();

            // Same instance?

            if (b1 == b2 && b2 == b3 && b3 == b4)
            {
                Console.WriteLine("Same instance\n");
            }

            // Load balance 15 server requests

            LoadBalancer balancer = LoadBalancer.GetLoadBalancer();
            for (int i = 0; i < 15; i++)
            {
                string server = balancer.Server;
                Console.WriteLine("Dispatch Request to: " + server);
            }

            Console.ReadKey();
        }
//        // Structural Code
//        static void Main()
//        {
//            // Constructor is protected -- cannot use new
//
//            Singleton s1 = Singleton.Instance();
//            Singleton s2 = Singleton.Instance();
// 
//            // Test for same instance
//
//            if (s1 == s2)
//            {
//                Console.WriteLine("Objects are the same instance");
//            }
// 
//            // Wait for user
//
//            Console.ReadKey();
//        }
//    }
// 
//    /// <summary>
//    /// The 'Singleton' class
//    /// </summary>
//    class Singleton
//
//    {
//        private static Singleton _instance;
// 
//        // Constructor is 'protected'
//
//        protected Singleton()
//        {
//        }
// 
//        public static Singleton Instance()
//        {
//            // Uses lazy initialization.
//
//            // Note: this is not thread safe.
//
//            if (_instance == null)
//            {
//                _instance = new Singleton();
//            }
// 
//            return _instance;
//        }
//    }
//}
    }
}