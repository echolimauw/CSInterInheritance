﻿namespace CSIntermediateInheritance
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            System.Console.WriteLine("Promote logic changed.");
        }
    }
}

