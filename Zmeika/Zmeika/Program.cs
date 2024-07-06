using Shared;
using System.Diagnostics;
using Zmeika;
bool IsGameGO = true;
//Render render = new Render();
ConsoleRenderer renderer = new ConsoleRenderer(new ConsoleColor[2] { ConsoleColor.Red, ConsoleColor.Yellow });
Input input = new Input();
Player player = new Player(renderer);
//ConsoleColor[] color = new ConsoleColor[2] { ConsoleColor.Red, ConsoleColor.Yellow };

while (IsGameGO)
{

    input.ChekKeyInfo();
    player.CalculateCord();
    //render.PrintCord(GameData.GetInstance().Cords);
    renderer.SetPixel(GameData.GetInstance().Cords[0], GameData.GetInstance().Cords[1], '■', 0);
    renderer.Render();
    Thread.Sleep(200);
}