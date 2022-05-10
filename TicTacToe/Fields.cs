using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Fields
    {
        public string[] GameField = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        public string CrossNull;
        public string CrossNullComputer;

        public Fields(string crossnull)
        {
            CrossNull = crossnull;
            if (CrossNull == "x" || CrossNull == "X")
            {
                CrossNull = "X";
                CrossNullComputer = "O";
            }
            else if (CrossNull == "o" || CrossNull == "O" || CrossNull == "0")
            {
                CrossNull = "O";
                CrossNullComputer = "X";
            }
            else Console.WriteLine("Заданы неверные значения");

        }
        public void Print()
        {
            Console.WriteLine($"{GameField[0]}|{GameField[1]}|{GameField[2]}");
            Console.WriteLine($"{GameField[3]}|{GameField[4]}|{GameField[5]}");
            Console.WriteLine($"{GameField[6]}|{GameField[7]}|{GameField[8]}");
        }

        public bool Winner()
        {
            if (GameField[0] == CrossNull && GameField[4] == CrossNull && GameField[8] == CrossNull
                    || GameField[2] == CrossNull && GameField[4] == CrossNull && GameField[6] == CrossNull
                    || GameField[0] == CrossNull && GameField[3] == CrossNull && GameField[6] == CrossNull
                    || GameField[1] == CrossNull && GameField[4] == CrossNull && GameField[7] == CrossNull
                    || GameField[2] == CrossNull && GameField[5] == CrossNull && GameField[8] == CrossNull
                    || GameField[0] == CrossNull && GameField[1] == CrossNull && GameField[2] == CrossNull
                    || GameField[3] == CrossNull && GameField[4] == CrossNull && GameField[5] == CrossNull
                    || GameField[6] == CrossNull && GameField[7] == CrossNull && GameField[8] == CrossNull)
            {
                Print();
                Console.WriteLine("Вы победили!");
                return true;
            }
            else if (GameField[0] == CrossNullComputer && GameField[4] == CrossNullComputer && GameField[8] == CrossNullComputer
                || GameField[2] == CrossNullComputer && GameField[4] == CrossNullComputer && GameField[6] == CrossNullComputer
                || GameField[0] == CrossNullComputer && GameField[3] == CrossNullComputer && GameField[6] == CrossNullComputer
                || GameField[1] == CrossNullComputer && GameField[4] == CrossNullComputer && GameField[7] == CrossNullComputer
                || GameField[2] == CrossNullComputer && GameField[5] == CrossNullComputer && GameField[8] == CrossNullComputer
                || GameField[0] == CrossNullComputer && GameField[1] == CrossNullComputer && GameField[2] == CrossNullComputer
                || GameField[3] == CrossNullComputer && GameField[4] == CrossNullComputer && GameField[5] == CrossNullComputer
                || GameField[6] == CrossNullComputer && GameField[7] == CrossNullComputer && GameField[8] == CrossNullComputer)
            {
                Print();
                Console.WriteLine("Вы проиграли");
                return true;
            }
            int count = 0;
            foreach (string x in GameField)
            {
                if (x == CrossNull || x == CrossNullComputer)
                    count++;
            }
            if (count == 9)
            {
                Print();
                Console.WriteLine("Ничья!");
                return true;
            }
            return false;
        }

        public bool Game(int fiel)
        {
            if(fiel >= 1 && fiel <= 9)
            {
                if (GameField[fiel - 1] != CrossNull && GameField[fiel - 1] != CrossNullComputer)
                {
                    GameField[fiel - 1] = CrossNull;
                    return true;
                }
                return false;
            }
            else
            {
                Console.WriteLine("Вы ввели неверное значение ячейки. Выберите ячейку на поле, не занятую знаками X и O и в числовом диапазоне от 1 до 9" );
                return false;
            }
        }
        public void Computer()
        {
            int cnt = 0;
            foreach(string fiel in GameField)
            {
                if (fiel == "1" || fiel == "3" || fiel == "6" || fiel == "9") cnt++; 
            }
            if (GameField[0] == "1" && CrossNullComputer == "X") GameField[0] = CrossNullComputer;
            else if (GameField[4] != CrossNullComputer && GameField[4] != CrossNull)
                GameField[4] = CrossNullComputer;
            else
            {
                if (GameField[0] == CrossNullComputer && GameField[1] == CrossNullComputer && GameField[2] == "3")
                    GameField[2] = CrossNullComputer;
                else if (GameField[3] == CrossNullComputer && GameField[4] == CrossNullComputer && GameField[5] == "6")
                    GameField[5] = CrossNullComputer;
                else if (GameField[6] == CrossNullComputer && GameField[7] == CrossNullComputer && GameField[8] == "9")
                    GameField[8] = CrossNullComputer;
                else if (GameField[1] == CrossNullComputer && GameField[2] == CrossNullComputer && GameField[0] == "1")
                    GameField[0] = CrossNullComputer;
                else if (GameField[4] == CrossNullComputer && GameField[5] == CrossNullComputer && GameField[3] == "4")
                    GameField[3] = CrossNullComputer;
                else if (GameField[7] == CrossNullComputer && GameField[8] == CrossNullComputer && GameField[6] == "7")
                    GameField[6] = CrossNullComputer;
                else if (GameField[0] == CrossNullComputer && GameField[3] == CrossNullComputer && GameField[6] == "7")
                    GameField[6] = CrossNullComputer;
                else if (GameField[1] == CrossNullComputer && GameField[4] == CrossNullComputer && GameField[7] == "8")
                    GameField[7] = CrossNullComputer;
                else if (GameField[2] == CrossNullComputer && GameField[5] == CrossNullComputer && GameField[8] == "9")
                    GameField[8] = CrossNullComputer;
                else if (GameField[3] == CrossNullComputer && GameField[6] == CrossNullComputer && GameField[0] == "1")
                    GameField[0] = CrossNullComputer;
                else if (GameField[4] == CrossNullComputer && GameField[7] == CrossNullComputer && GameField[1] == "2")
                    GameField[1] = CrossNullComputer;
                else if (GameField[5] == CrossNullComputer && GameField[8] == CrossNullComputer && GameField[2] == "3")
                    GameField[2] = CrossNullComputer;
                else if (GameField[0] == CrossNullComputer && GameField[4] == CrossNullComputer && GameField[8] == "9")
                    GameField[8] = CrossNullComputer;
                else if (GameField[8] == CrossNullComputer && GameField[4] == CrossNullComputer && GameField[0] == "1")
                    GameField[0] = CrossNullComputer;
                else if (GameField[6] == CrossNullComputer && GameField[4] == CrossNullComputer && GameField[2] == "3")
                    GameField[2] = CrossNullComputer;
                else if (GameField[2] == CrossNullComputer && GameField[4] == CrossNullComputer && GameField[6] == "7")
                    GameField[6] = CrossNullComputer;
                else if (GameField[0] == CrossNullComputer && GameField[2] == CrossNullComputer && GameField[1] == "2")
                    GameField[1] = CrossNullComputer;
                else if (GameField[3] == CrossNullComputer && GameField[5] == CrossNullComputer && GameField[4] == "5")
                    GameField[4] = CrossNullComputer;
                else if (GameField[6] == CrossNullComputer && GameField[8] == CrossNullComputer && GameField[7] == "8")
                    GameField[7] = CrossNullComputer;
                else if (GameField[0] == CrossNullComputer && GameField[6] == CrossNullComputer && GameField[3] == "4")
                    GameField[3] = CrossNullComputer;
                else if (GameField[1] == CrossNullComputer && GameField[7] == CrossNullComputer && GameField[4] == "5")
                    GameField[4] = CrossNullComputer;
                else if (GameField[2] == CrossNullComputer && GameField[8] == CrossNullComputer && GameField[5] == "6")
                    GameField[5] = CrossNullComputer;
                else
                {
                    if (GameField[0] == CrossNull && GameField[1] == CrossNull && GameField[2] == "3")
                        GameField[2] = CrossNullComputer;
                    else if (GameField[3] == CrossNull && GameField[4] == CrossNull && GameField[5] == "6")
                        GameField[5] = CrossNullComputer;
                    else if (GameField[6] == CrossNull && GameField[7] == CrossNull && GameField[8] == "9")
                        GameField[8] = CrossNullComputer;
                    else if (GameField[1] == CrossNull && GameField[2] == CrossNull && GameField[0] == "1")
                        GameField[0] = CrossNullComputer;
                    else if (GameField[4] == CrossNull && GameField[5] == CrossNull && GameField[3] == "4")
                        GameField[3] = CrossNullComputer;
                    else if (GameField[7] == CrossNull && GameField[8] == CrossNull && GameField[6] == "7")
                        GameField[6] = CrossNullComputer;
                    else if (GameField[0] == CrossNull && GameField[3] == CrossNull && GameField[6] == "7")
                        GameField[6] = CrossNullComputer;
                    else if (GameField[1] == CrossNull && GameField[4] == CrossNull && GameField[7] == "8")
                        GameField[7] = CrossNullComputer;
                    else if (GameField[2] == CrossNull && GameField[5] == CrossNull && GameField[8] == "9")
                        GameField[8] = CrossNullComputer;
                    else if (GameField[3] == CrossNull && GameField[6] == CrossNull && GameField[0] == "1")
                        GameField[0] = CrossNullComputer;
                    else if (GameField[4] == CrossNull && GameField[7] == CrossNull && GameField[1] == "2")
                        GameField[1] = CrossNullComputer;
                    else if (GameField[5] == CrossNull && GameField[8] == CrossNull && GameField[2] == "3")
                        GameField[2] = CrossNullComputer;
                    else if (GameField[0] == CrossNull && GameField[4] == CrossNull && GameField[8] == "9")
                        GameField[8] = CrossNullComputer;
                    else if (GameField[8] == CrossNull && GameField[4] == CrossNull && GameField[0] == "1")
                        GameField[0] = CrossNullComputer;
                    else if (GameField[6] == CrossNull && GameField[4] == CrossNull && GameField[2] == "3")
                        GameField[2] = CrossNullComputer;
                    else if (GameField[2] == CrossNull && GameField[4] == CrossNull && GameField[6] == "7")
                        GameField[6] = CrossNullComputer;
                    else if (GameField[0] == CrossNull && GameField[2] == CrossNull && GameField[1] == "2")
                        GameField[1] = CrossNullComputer;
                    else if (GameField[3] == CrossNull && GameField[5] == CrossNull && GameField[4] == "5")
                        GameField[4] = CrossNullComputer;
                    else if (GameField[6] == CrossNull && GameField[8] == CrossNull && GameField[7] == "8")
                        GameField[7] = CrossNullComputer;
                    else if (GameField[0] == CrossNull && GameField[6] == CrossNull && GameField[3] == "4")
                        GameField[3] = CrossNullComputer;
                    else if (GameField[1] == CrossNull && GameField[7] == CrossNull && GameField[4] == "5")
                        GameField[4] = CrossNullComputer;
                    else if (GameField[2] == CrossNull && GameField[8] == CrossNull && GameField[5] == "6")
                        GameField[5] = CrossNullComputer;
                    else
                    {
                        if (GameField[8] == "9" && CrossNullComputer == "X" && cnt <= 2) GameField[8] = CrossNullComputer;
                        else if (GameField[6] == "7" && CrossNullComputer == "X" && cnt <= 2) GameField[6] = CrossNullComputer;
                        else if (GameField[2] == "3" && CrossNullComputer == "X" && cnt <= 2) GameField[2] = CrossNullComputer;
                        else if (GameField[4] == CrossNullComputer && GameField[0] == CrossNullComputer && GameField[3] == "4" &&
                            GameField[5] == "6" && GameField[6] == "7") GameField[3] = CrossNullComputer;
                        else if (GameField[4] == CrossNullComputer && GameField[0] == CrossNullComputer && GameField[1] == "2"
                            && GameField[7] == "8" && GameField[2] == "3") GameField[1] = CrossNullComputer;
                        else if (GameField[4] == CrossNullComputer && GameField[2] == CrossNullComputer && GameField[1] == "2"
                            && GameField[7] == "8" && GameField[0] == "1") GameField[1] = CrossNullComputer;
                        else if (GameField[4] == CrossNullComputer && GameField[2] == CrossNullComputer && GameField[5] == "6"
                            && GameField[3] == "4" && GameField[8] == "9") GameField[5] = CrossNullComputer;
                        else if (GameField[4] == CrossNullComputer && GameField[6] == CrossNullComputer && GameField[3] == "4"
                            && GameField[0] == "1" && GameField[5] == "6") GameField[3] = CrossNullComputer;
                        else if (GameField[4] == CrossNullComputer && GameField[6] == CrossNullComputer && GameField[7] == "8"
                            && GameField[8] == "9" && GameField[1] == "2") GameField[7] = CrossNullComputer;
                        else if (GameField[4] == CrossNullComputer && GameField[8] == CrossNullComputer && GameField[7] == "8"
                            && GameField[6] == "7" && GameField[1] == "2") GameField[7] = CrossNullComputer;
                        else if (GameField[4] == CrossNullComputer && GameField[8] == CrossNullComputer && GameField[5] == "6"
                            && GameField[3] == "4" && GameField[2] == "3") GameField[5] = CrossNullComputer;
                        else
                        {
                            if (GameField[0] == "1" || GameField[2] == "3" || GameField[6] == "7" || GameField[8] == "9")
                            {
                                Random rand = new Random();
                                var arr1 = new[] { 1, 3, 7, 9 };
                                int rndMember;
                                int i = 0;
                                while(true)
                                {
                                    int count = 0;
                                    foreach(var item in arr1)
                                    {
                                        if(GameField[item - 1] == "1" || GameField[item - 1] == "3" || GameField[item - 1] == "7"
                                            || GameField[item - 1] == "9") count++;
                                    }
                                    if(count == 1 && GameField[1] == "2" && GameField[7] == "8")
                                    {
                                        var arr3 = new[] { 2, 8 };
                                        rndMember = arr3[rand.Next(arr3.Length)];
                                        GameField[rndMember - 1] = CrossNullComputer;
                                        break;
                                    }
                                    if (count == 1 && GameField[3] == "4" && GameField[5] == "6")
                                    {
                                        var arr3 = new[] { 4, 6 };
                                        rndMember = arr3[rand.Next(arr3.Length)];
                                        GameField[rndMember - 1] = CrossNullComputer;
                                        break;
                                    }
                                    rndMember = arr1[rand.Next(arr1.Length)];
                                    if (GameField[rndMember - 1] != CrossNullComputer && GameField[rndMember - 1] != CrossNull)
                                    {
                                        GameField[rndMember - 1] = CrossNullComputer;
                                        break;
                                    }
                                    if (arr1.Length == 1)
                                        break;
                                    int[] arr2 = new int[arr1.Length - 1];
                                    foreach (var item in arr1)
                                    {
                                        if (item != rndMember)
                                        {
                                            arr2[i] = item;
                                            i++;
                                        }
                                    }
                                    i = 0;
                                    arr1 = arr2;
                                }
                            }
                            else
                            {
                                Random rand = new Random();
                                var arr1 = new[] { 2, 4, 6, 8 };
                                int rndMember;
                                int i = 0;
                                while (true)
                                {
                                    rndMember = arr1[rand.Next(arr1.Length)];
                                    if (GameField[rndMember - 1] != CrossNullComputer && GameField[rndMember - 1] != CrossNull)
                                    {
                                        GameField[rndMember - 1] = CrossNullComputer;
                                        break;
                                    }
                                    if (arr1.Length == 1)
                                        break;
                                    int[] arr2 = new int[arr1.Length - 1];
                                    foreach (var item in arr1)
                                    {
                                        if (item != rndMember)
                                        {
                                            arr2[i] = item;
                                            i++;
                                        }
                                    }
                                    i = 0;
                                    arr1 = arr2;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
