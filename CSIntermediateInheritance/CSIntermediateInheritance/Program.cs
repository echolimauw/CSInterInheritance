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
            StreamReader reader = new StreamReader(new FileStream());

            var list = new ArrayList();
            list.Add(1);
            list.Add("Jim");
            list.Add(new Text());

            var anotherList = new List<Shape>();
        }
    }
}
