using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace CSIntermediateInheritance
{

    partial class Program
    {

        static void Main(string[] args)
        {
            var list = new ArrayList();
            list.Add(1);
            list.Add("Jim");
            list.Add(DateTime.Today);

            var anotherList = new List<int>();
            var names = new List<string>();
        }
    }
}
