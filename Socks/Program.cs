namespace Socks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SockStorage storage = new SockStorage("sockList.json");
            storage.Load();
        }
    }
}
