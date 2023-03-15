using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            int pbr;//playerbagrandom
            int select;//bag1den seçilenler
            int l = 2;
            int m = 0;
            int n = 0;
            int won = 1;
            int won2 = 1;
            int won3 = 1;
            int won4 = 1;
            int MONEY1 = 0;
            int MONEY2 = 0;
            bool lastcontrol = true;
            Random playerbagsrandom = new Random();
            #region BAG1
            char[] bag1 = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            #endregion
            #region BAG2
            char[] bag2 = new char[26];
            for (int i = 0; i < bag2.Length; i++)
            {
                bag2[i] = ' ';
            }
            #endregion
            #region PLAYER1 BAGS
            char[] player1bag = new char[8];
            pbr = playerbagsrandom.Next(0, 14);
            player1bag[0] = bag1[pbr];
            player1bag[1] = bag1[pbr];
            player1bag[2] = bag1[pbr];
            player1bag[3] = bag1[pbr];
            while (player1bag[1] == player1bag[0])
            {
                pbr = playerbagsrandom.Next(0, 14);
                player1bag[1] = bag1[pbr];
            }
            while (player1bag[2] == player1bag[0] || player1bag[2] == player1bag[1])
            {
                pbr = playerbagsrandom.Next(0, 14);
                player1bag[2] = bag1[pbr];
            }
            while (player1bag[3] == player1bag[0] || player1bag[3] == player1bag[1] || player1bag[3] == player1bag[2])
            {
                pbr = playerbagsrandom.Next(0, 14);
                player1bag[3] = bag1[pbr];
            }
            pbr = playerbagsrandom.Next(14, 26);
            player1bag[4] = bag1[pbr];
            player1bag[5] = bag1[pbr];
            player1bag[6] = bag1[pbr];
            player1bag[7] = bag1[pbr];
            while (player1bag[5] == player1bag[4])
            {
                pbr = playerbagsrandom.Next(14, 26);
                player1bag[5] = bag1[pbr];
            }
            while (player1bag[6] == player1bag[4] || player1bag[6] == player1bag[5])
            {
                pbr = playerbagsrandom.Next(14, 26);
                player1bag[6] = bag1[pbr];
            }
            while (player1bag[7] == player1bag[4] || player1bag[7] == player1bag[5] || player1bag[7] == player1bag[6])
            {
                pbr = playerbagsrandom.Next(14, 26);
                player1bag[7] = bag1[pbr];
            }
            #endregion
            #region PLAYER2 BAGS
            char[] player2bag = new char[8];
            pbr = playerbagsrandom.Next(0, 14);
            player2bag[0] = bag1[pbr];
            player2bag[1] = bag1[pbr];
            player2bag[2] = bag1[pbr];
            player2bag[3] = bag1[pbr];
            while (player2bag[1] == player2bag[0])
            {
                pbr = playerbagsrandom.Next(0, 14);
                player2bag[1] = bag1[pbr];
            }
            while (player2bag[2] == player2bag[0] || player2bag[2] == player2bag[1])
            {
                pbr = playerbagsrandom.Next(0, 14);
                player2bag[2] = bag1[pbr];
            }
            while (player2bag[3] == player2bag[0] || player2bag[3] == player2bag[1] || player2bag[3] == player2bag[2])
            {
                pbr = playerbagsrandom.Next(0, 14);
                player2bag[3] = bag1[pbr];
            }
            pbr = playerbagsrandom.Next(14, 26);
            player2bag[4] = bag1[pbr];
            player2bag[5] = bag1[pbr];
            player2bag[6] = bag1[pbr];
            player2bag[7] = bag1[pbr];
            while (player2bag[5] == player2bag[4])
            {
                pbr = playerbagsrandom.Next(14, 26);
                player2bag[5] = bag1[pbr];
            }
            while (player2bag[6] == player2bag[4] || player2bag[6] == player2bag[5])
            {
                pbr = playerbagsrandom.Next(14, 26);
                player2bag[6] = bag1[pbr];
            }
            while (player2bag[7] == player2bag[4] || player2bag[7] == player2bag[5] || player2bag[7] == player2bag[6])
            {
                pbr = playerbagsrandom.Next(14, 26);
                player2bag[7] = bag1[pbr];
            }
            #endregion
            while (true)
            {
                //A B C D E F G H I J K L M N O P Q R S T U V W X Y Z
                #region playerların baglerinin yazılması
                Console.SetCursorPosition(0, m);
                Console.Write("PLAYER 1 BAG :");
                for (int i = 0; i < player1bag.Length; i++)
                {
                    if (player1bag[i] != ' ')
                        Console.Write(" " + player1bag[i]);
                }
                Console.SetCursorPosition(0, m + 1);
                Console.Write("PLAYER 2 BAG :");
                for (int i = 0; i < player1bag.Length; i++)
                {
                    if (player2bag[i] != ' ')
                        Console.Write(" " + player2bag[i]);
                }
                #endregion
                #region BAG1 nin ekrana yazılması
                Console.SetCursorPosition(40, m);
                Console.Write("BAG 1 :");
                for (int i = 0; i < bag1.Length; i++)
                {
                    if (bag1[i] == ' ')
                    {
                        Console.Write("");
                    }
                    else
                        Console.Write(" " + bag1[i]);
                }
                #endregion
                #region BAG2 nin ekrana yazılması
                Console.SetCursorPosition(40, m + 1);
                Console.Write("BAG 2 :");
                for (int i = 0; i < bag2.Length; i++)
                {
                    if (bag2[i] != ' ')
                    {
                        Console.Write(" " + bag2[i]);
                    }
                }
                #endregion
                #region awards
                Console.SetCursorPosition(0, m + 2);

                if (won == 1)
                {
                    if (player1bag[0] == ' ' && player1bag[1] == ' ' && player1bag[2] == ' ' && player1bag[3] == ' ' || player1bag[4] == ' ' && player1bag[5] == ' ' && player1bag[6] == ' ' && player1bag[7] == ' ')
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("!!! PLAYER 1 1.ÇİNKO !!!  PLAYER 1 GETS THE AWARD $10");
                        Console.ResetColor();
                        MONEY1 = 10;
                        l = l + 1;
                        m = m + 1;
                        won = 0;
                    }
                }

                if (won2 == 1)
                {
                    if (player2bag[0] == ' ' && player2bag[1] == ' ' && player2bag[2] == ' ' && player2bag[3] == ' ' || player2bag[4] == ' ' && player2bag[5] == ' ' && player2bag[6] == ' ' && player2bag[7] == ' ')
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("!!! PLAYER 2 1.ÇİNKO !!!  PLAYER 2 GETS THE AWARD $10");
                        Console.ResetColor();
                        MONEY2 = 10;
                        l = l + 1;
                        m = m + 1;

                        won2 = 0;
                    }
                }
                if ((player1bag[0] == ' ' && player1bag[1] == ' ' && player1bag[2] == ' ' && player1bag[3] == ' ' && player1bag[4] == ' ' && player1bag[5] == ' ' && player1bag[6] == ' ' && player1bag[7] == ' ') && (player2bag[0] == ' ' && player2bag[1] == ' ' && player2bag[2] == ' ' && player2bag[3] == ' ' && player2bag[4] == ' ' && player2bag[5] == ' ' && player2bag[6] == ' ' && player2bag[7] == ' '))
                {
                    won3 = 0;
                    won4 = 0;
                }
                if (won3 == 1)
                {
                    if (player1bag[0] == ' ' && player1bag[1] == ' ' && player1bag[2] == ' ' && player1bag[3] == ' ' && player1bag[4] == ' ' && player1bag[5] == ' ' && player1bag[6] == ' ' && player1bag[7] == ' ')
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("!!! PLAYER 1 GETS THE AWARD $30");
                        Console.ResetColor();
                        l = l + 1;
                        m = m + 1;
                        won3 = 0;
                    }
                }

                if (won4 == 1)
                {
                    if (player2bag[0] == ' ' && player2bag[1] == ' ' && player2bag[2] == ' ' && player2bag[3] == ' ' && player2bag[4] == ' ' && player2bag[5] == ' ' && player2bag[6] == ' ' && player2bag[7] == ' ')
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("!!! PLAYER 2 GETS THE AWARD $30");
                        Console.ResetColor();
                        l = l + 1;
                        m = m + 1;
                        won4 = 0;
                    }
                }

                #endregion
                Console.SetCursorPosition(0, l);
                Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                #region OYUN BİTİRME

                if ((player1bag[0] == ' ' && player1bag[1] == ' ' && player1bag[2] == ' ' && player1bag[3] == ' ' && player1bag[4] == ' ' && player1bag[5] == ' ' && player1bag[6] == ' ' && player1bag[7] == ' ') && (player2bag[0] == ' ' && player2bag[1] == ' ' && player2bag[2] == ' ' && player2bag[3] == ' ' && player2bag[4] == ' ' && player2bag[5] == ' ' && player2bag[6] == ' ' && player2bag[7] == ' '))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("PLAYER 1 GETS $" + (MONEY1 + 15));
                    Console.WriteLine("PLAYER 2 GETS : $" + (MONEY2 + 15));
                    Console.WriteLine("NO ONE IS THE WINNER");
                    Console.ResetColor();
                    Console.ReadLine();
                    lastcontrol = false;
                    break;

                }
                if (lastcontrol)
                {
                    if (player1bag[0] == ' ' && player1bag[1] == ' ' && player1bag[2] == ' ' && player1bag[3] == ' ' && player1bag[4] == ' ' && player1bag[5] == ' ' && player1bag[6] == ' ' && player1bag[7] == ' ')
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("PLAYER 1 GETS $" + (MONEY1 + 30));
                        Console.WriteLine("PLAYER 2 GETS $" + MONEY2);
                        Console.WriteLine("PLAYER 1 IS THE WINNER");
                        Console.ResetColor();
                        Console.ReadLine();
                        break;
                    }
                    if (player2bag[0] == ' ' && player2bag[1] == ' ' && player2bag[2] == ' ' && player2bag[3] == ' ' && player2bag[4] == ' ' && player2bag[5] == ' ' && player2bag[6] == ' ' && player2bag[7] == ' ')
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("PLAYER 1 GETS $" + MONEY1);
                        Console.WriteLine("PLAYER 2 GETS $" + (MONEY2 + 30));
                        Console.WriteLine("PLAYER 2 IS THE WINNER");
                        Console.ResetColor();
                        Console.ReadLine();
                        break;
                    }
                }
                #endregion
                #region BAG1 den eleman seçimi
                select = playerbagsrandom.Next(0, 26);
                while (bag1[select] == ' ')
                {
                    Random randomagain = new Random();
                    int ra = randomagain.Next(0, 26);
                    select = ra;
                }
                    for (int i = 0; i < bag1.Length; i++)//selecte eşit olan charı bulma
                    {
                        if (select == i)//eşitlik yakalandı
                        {

                            if (bag1[select] != ' ')//boş eleman değilse
                            {
                                for (int k = 0; k < 8; k++)//playerların elemanlarının kontrolü
                                {
                                    if (player1bag[k] == bag1[select] && player2bag[k] == bag1[select])//2 oyuncuda da varsa
                                    {
                                        player1bag[k] = ' ';
                                        player2bag[k] = ' ';
                                    }
                                    else if (player1bag[k] == bag1[i])//1. oyuncuda varsa
                                        player1bag[k] = ' ';
                                    else if (player2bag[k] == bag1[i])//2. oyuncuda varsa
                                        player2bag[k] = ' ';
                                }
                                bag2[n] = bag1[select];
                                bag1[select] = ' ';
                                n = n + 1;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("SELECTED LETTER : " + bag2[n - 1]);
                                Console.ResetColor();
                                break;
                            }
                            //eğer boş eleman ise yeniden random attırılıyor





                        }
                    }
                
                #endregion
                l = l + 4;
                m = m + 4;
            }
        }
    }
}
