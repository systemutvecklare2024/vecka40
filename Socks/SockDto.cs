using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Socks
{
    internal class SockDto
    {
        public int Size { get; set; }
        public string Color { get; set; }
        public int Grade { get; set; }

        public SockDto(int size, string color, int grade)
        {
            Size = size;
            Color = color;
            Grade = grade;
        }

        public static SockDto FromSock(Sock sock)
        {
            return new SockDto(sock.Size, sock.Color, sock.Grade);
        }

        public Sock ToSock()
        {
            return new Sock(Size, Color, Grade);
        }
    }
}
