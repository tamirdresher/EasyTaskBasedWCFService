using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using Contracts;

namespace EasyTaskBasedWCFService
{
   
    public class Calculator : ICalculator
    {
        public async Task<int> AddAsync(int left, int right)
        {
            await Task.Delay(TimeSpan.FromSeconds(2));
            return left + right;
        }

        public int Minus(int left, int right)
        {
            return left - right;
        }
    }
}
