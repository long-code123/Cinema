using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Management
{
    public class Room
    {
        public int IdMovie;
        public bool[,] Seat;

        public Room(int idMovie)
        {
            this.IdMovie = idMovie;
            this.Seat = new bool[5, 5];
        }

        public void ShowSeat()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (Seat[i, j] == false)
                    {
                        Console.Write($"[{i * 5 + j + 1}]\t");
                    }
                    else
                    {
                        Console.Write("[X]\t");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
