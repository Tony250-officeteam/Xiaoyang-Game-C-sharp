using System;

public class TUI
{
	public static void draw()
    {
		Console.SetCursorPosition(0, 18);
		for(int i =1;i < 60; i++)Console.Write("-");
		
    }
	public static void map(int y,int x,string z)
	{
		///第一个数据显示纵行，第二个数据显示横行,第三个数据显示地图名称。
		Console.Clear();
		Console.SetCursorPosition(0, 2);
		Console.Write(z);
		Console.SetCursorPosition(15,4);
		for(int i = 0; i<2*x+2; i++)Console.Write("-");
		int a = 5;
		for(int i = 0;i < y; i++)
        {
			Console.SetCursorPosition(15, a);
			Console.Write("|");
			for (int j = 0;j < x; j++)
            {
				if (j == HelloWorldApplication.HelloWorld.dx && i == HelloWorldApplication.HelloWorld.dy && HelloWorldApplication.HelloWorld.dx !=114514 && HelloWorldApplication.HelloWorld.dy != 114514)
                {
					Console.Write("D ");
					continue;
				}
				if (j == HelloWorldApplication.HelloWorld.xx && i == HelloWorldApplication.HelloWorld.xy && HelloWorldApplication.HelloWorld.xx != 114514 && HelloWorldApplication.HelloWorld.xy != 114514)
				{
					Console.Write("R ");
					continue;
				}
				Console.Write("O ");
			}
			Console.Write("|");
			a++;
        }//绘制地图
		Console.SetCursorPosition(15, a);
		for (int i = 0; i < 2*x+2; i++) Console.Write("-");//绘制边框
		Console.SetCursorPosition(0, 18);
		Console.WriteLine("------------------------------------------------------------------------");
		Console.SetCursorPosition(0,19);
		//Console.WriteLine("xx:{0},xy:{1}",HelloWorldApplication.HelloWorld.xx, HelloWorldApplication.HelloWorld.xy);
		Console.Write(".&&>");
		if (Console.ReadKey().Key == ConsoleKey.F9)
        {
			Load_game.cmd();
			map(y,x,z);
		}
		if (Console.ReadKey().Key == ConsoleKey.UpArrow)
        {
			if(HelloWorldApplication.HelloWorld.xy == 0)
            {
				HelloWorldApplication.HelloWorld.xy = 0;
				map(y, x, z);
			}
			HelloWorldApplication.HelloWorld.xy--;
			map(y, x, z);
		}
		if (Console.ReadKey().Key == ConsoleKey.DownArrow)
		{
			if (HelloWorldApplication.HelloWorld.xy == y-1)
			{
				HelloWorldApplication.HelloWorld.xy = y-1;
				map(y, x, z);
			}
			HelloWorldApplication.HelloWorld.xy++;
			map(y, x, z);
		}
		if (Console.ReadKey().Key == ConsoleKey.LeftArrow)
		{
			if (HelloWorldApplication.HelloWorld.xx == 0)
			{
				HelloWorldApplication.HelloWorld.xx = 0;
				map(y, x, z);
			}
			HelloWorldApplication.HelloWorld.xx--;
			map(y, x, z);
		}
		if (Console.ReadKey().Key == ConsoleKey.RightArrow)
		{
			if (HelloWorldApplication.HelloWorld.xx == x-1)
			{
				HelloWorldApplication.HelloWorld.xx = x-1;
				map(y, x, z);
			}
			HelloWorldApplication.HelloWorld.xx++;
			map(y, x, z);
		}else map(y, x, z);
	}
}
