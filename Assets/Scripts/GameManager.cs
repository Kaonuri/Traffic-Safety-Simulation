using Ultimate;
using Ultimate.Scene;

public sealed class GameManager
{
    private static readonly GameManager _instance = new GameManager();
    public SceneManager sceneManger { private set; get; }
    public WindowManager windowManager { private set; get; }

    public Player player { private set; get; }

    public static GameManager Instacne
    {
        get { return _instance; }
    }

    private GameManager()
    {
        UGL.ProvideSceneManager();
        sceneManger = UGL.sceneManager;
    }

    public void SetPlayer(Player player)
    {
        this.player = player;
    }

    public void SetWindowManger(WindowManager windowManager)
    {
        this.windowManager = windowManager;
    }
}   
