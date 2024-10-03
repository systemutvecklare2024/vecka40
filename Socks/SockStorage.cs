using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Socks
{
    internal class SockStorage
    {
        public string Path { get; private set; }

        public SockStorage(string path)
        {
            Path = path;
        }

        public void Load()
        {
            Console.WriteLine(Path);
            string json = File.ReadAllText(Path);
            var data = JsonSerializer.Deserialize<List<SockDto>>(json);
            if (data == null)
            {
                throw new Exception("No data found.");
            }

            List<Sock> socks = new List<Sock>();

            foreach(var item in data)
            {
                try
                {
                    var sock = item.ToSock();
                    if (sock != null)
                    {
                        socks.Add(sock);
                    }
                }
                catch (Exception ex) {
                    Console.WriteLine($"Unable to add sock: {ex.Message}");
                }
            }

            foreach (var sock in socks)
            {
                Console.WriteLine(sock);
            }
        }

        public void Save() { }
    }
}
