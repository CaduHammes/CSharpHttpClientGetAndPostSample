using HttpGetAndPostPractice.Service;
using System.Threading.Tasks;

namespace HttpGetAndPostPractice
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await HttpGetService.GetMethod();
            HttpPostService.PostMethod();
        }
    }
}
