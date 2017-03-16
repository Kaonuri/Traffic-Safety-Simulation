public class TSEventDisablePlayerMove : TSEvent
{
    protected override void OnStart()
    {
        GameManager.Instacne.player.canMove = false;
        QuitEvent();
    }

    protected override void OnQuit()
    {
    }
}
