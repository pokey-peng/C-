using System;using System.Threading.Tasks;
namespace CSharpBook.Chapter14
{
    class AsyncAwait
    {
        private static async Task DoWorkAsync()
        {
            await Task.Run(() =>
            {
                long sum = 0;
                for (long i = 0; i < 99999999; i++) { sum += i; }
                Console.WriteLine("�첽����������Ϊ��{0}", sum);
            });
        }
        public static void Main()
        {
            Console.WriteLine("��ʼ�����첽����");
            DoWorkAsync();
            Console.WriteLine("����ִ��Main����");
            Console.ReadKey();
        }
    }
}
