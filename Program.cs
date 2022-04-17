using System;
using System.Threading;

namespace HelloWorldApplication
{

    /* 类名为 HelloWorld */
    class HelloWorld
    {
        public static int xx, xy; //小样的坐标,向右，向下为正方向
        public static int dx, dy; //门的坐标，当都是114514的时候，没有门
        public static int message = 0;//全场广播
        static void unMain(string[] args)//测试使用函数；
        {
            Load_game.load(1);
            for (int i = 0; i < 62; i++) Console.WriteLine(Load_game.str[i]);
        }
        /* main函数 */
        static void Main(string[] args)
        {
#pragma warning disable CA1416 // 验证平台兼容性
            Console.WindowHeight = 31;
            Console.WindowWidth = 100;
            Console.BufferHeight = 31;
            Console.BufferWidth = 100;
            Console.WindowWidth = 100;
#pragma warning restore CA1416 // 验证平台兼容性
            Console.Title = "小样の大冒险";
            StreamReader welcome_sceen = new StreamReader("welcome.txt");
            Console.SetCursorPosition(0, 5);
            for (int a = 0; a < 16; a++) Console.WriteLine(welcome_sceen.ReadLine());
            welcome_sceen.Close();
            Thread.Sleep(3000);
            Console.Clear();
            int set = 0;
            ppp();

            void ppp()
            {
                switch (set)
                {
                    case 0:
                        {
                            Console.Clear();
                            Console.SetCursorPosition(35, 11);
                            Console.Write("|中文|");
                            Console.SetCursorPosition(35, 13);
                            Console.Write("English");
                            Console.SetCursorPosition(0, 30);
                            Console.Write("<tab> -> ↑↓  ；<enter> -> √");
                            if (Console.ReadKey().Key == ConsoleKey.Tab)
                            {
                                if (set == 1) set = -1;
                                set++;
                                ppp();
                            }
                            if (Console.ReadKey().Key == ConsoleKey.Enter)
                            {
                                StartGame(set);
                            }
                            break;
                        }
                    case 1:
                        {
                            Console.Clear();
                            Console.SetCursorPosition(35, 11);
                            Console.Write("中文");
                            Console.SetCursorPosition(35, 13);
                            Console.Write("|English|");
                            Console.SetCursorPosition(0, 30);
                            Console.Write("<tab> -> ↑↓  ；<enter> -> √");
                            if (Console.ReadKey().Key == ConsoleKey.Tab)
                            {
                                if (set == 1) set = -1;
                                set++;
                                ppp();
                            }
                            if (Console.ReadKey().Key == ConsoleKey.Enter)
                            {
                                StartGame(set);
                            }
                            break;
                        }
                }
            }

        }

        static void StartGame(int a)
        {
            Load_game.load(a);
            Console.ReadKey();
        }
        public static void beforeGame()
        {
            for (int i = 0;i < 4; i++)
            {
                Load_game.ot(Load_game.str[39], Load_game.str[i + 42]);
            }
            WayToStudio();
        }
        public static void WayToStudio()
        {
            xx = 2;
            xy = 2;
            TUI.map(5, 10, "测试");
        }
    }
}