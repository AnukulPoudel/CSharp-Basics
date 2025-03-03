using System.Threading.Tasks;

namespace Programming
{
    class AsyncAwait
    {
        async static public Task<int> Sum(int a, int b){
            await Task.Delay(2000);
            return a+b;
        }
    }
}