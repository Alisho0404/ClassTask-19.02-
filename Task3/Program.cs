 
var player = new Player();
Console.Write("Enter player's name: "); 
player.Name = Console.ReadLine();
Console.Write("Enter player's number: ");
player.Number=int.Parse(Console.ReadLine());
Console.Write("Enter player's position: ");
player.Position = Console.ReadLine();
Console.Write("Enter player's team: ");
player.Team = Console.ReadLine();

Console.WriteLine();

player.ScoreGoal();
player.AssistGoal(player.Name);

Console.WriteLine();
player.GetInfo();
player.ScoreGoal();
player.AssistGoal(player.Name);


class Player
{
    public string Name;
    public int Number;
    public string Position;
    public string Team;
    public void ScoreGoal() 
    {
        Console.WriteLine($"Player {Name} scores a goal.");
    } 
    public void AssistGoal(string player_name) 
    { 
        Name= player_name;
        Console.WriteLine($"Player {Name} assists a goal for Neymar.");
    } 
    public void GetInfo() 
    {
        Console.WriteLine($"Name: {Name}\nNumber: {Number}\nPosition: {Position}\nTeam: {Team}");
    }
} 

