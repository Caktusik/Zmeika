using Shared;
using System;
using System.Diagnostics;
using Zmeika;
ConsoleRenderer renderer = new ConsoleRenderer(new ConsoleColor[3] { ConsoleColor.Red,ConsoleColor.Cyan, ConsoleColor.White }); 
Input input = new Input();
Player player = new Player(renderer);
Interfece interfece = new Interfece();
GameData.GetInstance().level = 1;
Apple apple = new Apple(renderer);
apple.SummonApple(apple.RandomPosishonIN().X, apple.RandomPosishonIN().Y);
while (true)
{
    while (GameData.GetInstance().IsGameGO)
    {

        input.ChekKeyInfo();
        player.CalculateCord();
        foreach (var zveno in GameData.GetInstance().teloZmeiki)
        {
            renderer.SetPixel(zveno.X, zveno.Y, '■', 0);
        }
        renderer.Render();
        interfece.Draw();
        renderer.DrawMap();
        if (((GameData.GetInstance().level * 2) + 3) == GameData.GetInstance().teloZmeiki.Count)
        {
            GameData.GetInstance().IsGameGO = false;
            GameData.GetInstance().sms = 1;
        }
        Thread.Sleep(200 / GameData.GetInstance().level);
    }
    while (!GameData.GetInstance().IsGameGO)
    {
        Console.Clear();
        switch (GameData.GetInstance().sms)
        {
            case (0):
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ПРОИГРЫШ");
                Thread.Sleep(2000);
                Environment.Exit(0);
                break;
            case (1):
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Уровень пройден, переход на следуюший...");
                Thread.Sleep(300);
                Console.Clear();
                Console.WriteLine("Уровень пройден, переход на следуюший..");
                Thread.Sleep(300);
                Console.Clear();
                Console.WriteLine("Уровень пройден, переход на следуюший.");
                Thread.Sleep(300);
                Console.Clear();
                Console.WriteLine("Уровень пройден, переход на следуюший");
                Thread.Sleep(200);
                GameData.GetInstance().level += 1;
                GameData.GetInstance().IsGameGO = true;
                GameData.GetInstance().teloZmeiki.Clear();
                GameData.GetInstance().teloZmeiki.Add(new Vector2Int(10, 10));
                GameData.GetInstance().teloZmeiki.Add(new Vector2Int(11, 10));
                GameData.GetInstance().teloZmeiki.Add(new Vector2Int(12, 10));
                for (int i = 0; i < Console.WindowWidth; i++)
                {
                    for (int j = 0; j < Console.WindowHeight; j++)
                    {
                        renderer[i, j] = ' ';
                    }
                }
                apple.SummonApple(apple.RandomPosishonIN().X, apple.RandomPosishonIN().Y);
                break;
        }

    }
}