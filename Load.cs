using System;

public class Load_game
{
    public static string[] str = new string[200];

    public static  void cmd()
    {
        Console.Write("({0})",str[63]);
        string a = Console.ReadLine();
        switch (a)
        {
            case "help":
                {
                    Console.WriteLine(str[64]);
                    Console.WriteLine(str[65]);
                    Thread.Sleep(3000);
                    break;
                }
            case "exit":
                {
                    Environment.Exit(0);
                    break;
                }
        }
    }
    public static void ot(string a, string b)
    {
        Console.Clear();
        Console.SetCursorPosition(7, 7);
        Console.WriteLine("{0}：", a);
        Console.SetCursorPosition(7, 9);
        Console.WriteLine("==================================================");

        Console.SetCursorPosition(7, 11);
        foreach (char c in b)
        {
            Console.Write(c);
            (int Left, int Top) p = Console.GetCursorPosition();
            if (p.Left == (7 + 75)) { Console.SetCursorPosition(7,p.Top+1); }
        }
            
        //Console.WriteLine("{0}", b);
        Console.SetCursorPosition(7, 25);
        Console.WriteLine("<enter> ->>");
        Console.ReadKey();
        Console.Clear();
    }
    public static void load(int a)
	{
        string file = "";
        if (a == 0)
        {
            file = "Zh.txt";
        }
        if (a == 1)
        {
            file = "En.txt";

        }
        int choice = 0;
        Console.Clear();
        StreamReader date = new StreamReader(file);
        Console.WriteLine("loading......");
        for (int i = 0; i < 66; i++)
        {
            str[i] = date.ReadLine();

        }
        date.Close();
        ppp();

        void ppp()
        {
            Console.Clear();

            while (true)
            {
                for (int i = 0; i < 7; i++)
                {
                    Console.SetCursorPosition(10, i + 4); Console.WriteLine(Load_game.str[i + 1]);
                }
                for (int i = 0; i < 14; i++)
                {
                    Console.SetCursorPosition(5, i + 12); Console.WriteLine(Load_game.str[i + 8]);
                }
                for (int i = 0; i < 4; i++)
                {
                    Console.SetCursorPosition(40, i + 18); Console.WriteLine(Load_game.str[i + 22]);
                }
                for (int i = 0; i < 3; i++)
                {
                    if (i == choice)
                    {
                        Console.SetCursorPosition(40, i + 18); Console.WriteLine("|{0}|", Load_game.str[i + 22]);
                    }
                }
                Console.SetCursorPosition(0, 29);
                Console.Write("<tab> -> ↑↓  ；<enter> -> √      注意，如果没有选项，则为退出游戏\n  notice!if there is nothting to remind you how to choice,ti is exit the game. ");
                if (Console.ReadKey().Key == ConsoleKey.Tab)
                {
                    if (choice == 3) choice = -1;
                    choice++;
                    continue;
                }
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    switch (choice)
                    {
                        case 0:
                            {
                                HelloWorldApplication.HelloWorld.beforeGame();
                                break;
                            }
                        case 1:
                            {
                                Console.Clear();
                                Console.SetCursorPosition(0, 0); Console.WriteLine("|{0}|", Load_game.str[38]);
                                System.Threading.Thread.Sleep(3000);
                                Console.Clear();
                                break;
                            }
                        case 2:
                            {
                                for (int i = 0; i < 11; i++)
                                {
                                    Console.SetCursorPosition(0, i + 3); Console.WriteLine("|{0}|", Load_game.str[i + 26]);
                                }
                                Console.ReadKey();
                                ppp();
                                break;
                            }
                        case 3: 
                            {
                                Environment.Exit(0);
                                break;
                            }
                    }
                }
            }
        }
    }


        }

