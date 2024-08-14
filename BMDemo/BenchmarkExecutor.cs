using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMDemo
{

    public class BenchmarkExecutor
    {
        [Benchmark]
        public void Execute() 
        {
            var calculator = new Calculator();
            calculator.Add(2, 3);
        }
    }
}
