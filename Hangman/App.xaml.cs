using Hangman.Data;

namespace Hangman;

public partial class App : Application
{

    public static GameRepository GameRepository { get; private set; }

    public App(GameRepository gameRepository)
	{
		InitializeComponent();

		MainPage = new AppShell();

        GameRepository = gameRepository;
    }

    protected override Window CreateWindow(IActivationState activationState)
    {
        var window = base.CreateWindow(activationState);

        return window;
    }
}

