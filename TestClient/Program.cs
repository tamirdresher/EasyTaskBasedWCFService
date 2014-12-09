using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Configuration;
using System.Text;
using System.Threading.Tasks;
using Contracts;

namespace TestClient
{
    class Program
    {
        static  void Main(string[] args)
        {
            Task.Run(async () =>
            {
var channelFactory = new ChannelFactory<ICalculatorAsync>("BasicHttpBinding_ICalculator");
var Calculator = channelFactory.CreateChannel();
var result = await Calculator.MinusAsync(5, 1);
Console.WriteLine("5 - 1 = {0}", result);
            }).Wait();
        }
    }
}
