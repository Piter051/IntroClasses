namespace IntroClasses;

public class Player : Character
{
    private readonly Dictionary<ConsoleKey, Vector2> _inputMap;

    public Player(Vector2 startingPosition, Dictionary<ConsoleKey, Vector2> inputMap) : base(startingPosition)
    {
        _inputMap = inputMap;
    }

    
    public override bool TakeTurn()
    {
        bool isPlaying = true;
        ConsoleKeyInfo input = Console.ReadKey(true);
        Console.SetCursorPosition(_position.X, _position.Y);
        Console.Write(" ");

        if (_inputMap.ContainsKey(input.Key))
        {
            Vector2 direction = _inputMap[input.Key];
            Move(direction);
        }
        switch (input.Key)
        {
            case ConsoleKey.Q:
                isPlaying = false;
                break;
        }
   
        Display();
        return isPlaying;
    }
}
