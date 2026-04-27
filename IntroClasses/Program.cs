using IntroClasses;

bool isPlaying = true;
Vector2 startingPosition = new Vector2(4, 2);
Player hero = new Player(startingPosition);
startingPosition.X = 0;
startingPosition.Y = 0;
    
//startingPosition = new Vector2(0, 0);
Player anotherHero = new Player(startingPosition);
hero.Display();
// Console.ReadKey(true);
while (isPlaying)
{
    isPlaying = hero.TakeTurn();
    isPlaying = anotherHero.TakeTurn();
}
Console.WriteLine("Goodbye");
