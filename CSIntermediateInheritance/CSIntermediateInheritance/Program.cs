using System;
using Amazon;

namespace CSIntermediateInheritance
{

    partial class Program
    {

        static void Main(string[] args)
        {
            var customer = new Customer();
            Amazon.RateCalculator calculator = new RateCalculator();
        }
    }
}
