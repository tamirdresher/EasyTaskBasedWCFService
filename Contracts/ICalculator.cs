using System.ServiceModel;
using System.Threading.Tasks;

namespace Contracts
{
    [ServiceContract]
    public interface ICalculator
    {

        [OperationContract]
        Task<int> AddAsync(int left,int right);

        [OperationContract]
        int Minus(int left, int right);
    }


    [ServiceContract]
    public interface ICalculatorAsync:ICalculator
    {

        [OperationContract(
            Action = "http://tempuri.org/ICalculator/Minus",
            ReplyAction = "http://tempuri.org/ICalculator/MinusResponse")]
        Task<int> MinusAsync(int left, int right);
    }

   
}
