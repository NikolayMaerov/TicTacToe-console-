using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe;

namespace CSharpEssentials
{
    class Program
    {
        static void Main(string[] args)
        {
            string crossnull;
            while (true)
            {
                Console.WriteLine("Выберите крестик(X) или нолик(O):");
                crossnull = Console.ReadLine();
                if (crossnull == "x" || crossnull == "X" || crossnull == "o" || crossnull == "O" || crossnull == "0")
                    break;
                else
                {
                    Console.WriteLine("Вы ввели неверное значение");
                }
            }
            Fields fields = new Fields(crossnull);
            if(crossnull == "o" || crossnull == "O" || crossnull == "0") fields.Computer();
            fields.Print();
            int fiel;
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine("Введите ячейку на поле:");
                do
                {
                    fiel = Convert.ToInt32(Console.ReadLine());
                }
                while (!fields.Game(fiel));
                if (fields.Winner()) break;
                fields.Computer();
                if (fields.Winner()) break;
                fields.Print();
            }

        }
    }
}