using IntroClasses;

bool isPlaying = true;
Player hero = new Player();
hero.Display();
// Console.ReadKey(true);
while (isPlaying)
{
    isPlaying = hero.TakeTurn();
}
Console.WriteLine("Goodbye");
