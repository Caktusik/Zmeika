using Zmeika;
bool IsGameGO = true;
Render render = new Render();
Input input = new Input();
Player player = new Player();

while (IsGameGO)
{

    input.ChekKeyInfo();
    player.CalculateCord();
    render.PrintCord(GameData.GetInstance().Cords);
    Thread.Sleep(200);
}