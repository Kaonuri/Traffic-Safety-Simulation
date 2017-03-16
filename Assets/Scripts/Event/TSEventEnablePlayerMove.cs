public class TSEventEnablePlayerMove : TSEvent
{
    protected override void OnStart()
    {
        GameManager.Instacne.player.canMove = true;
        QuitEvent();
    }

    protected override void OnQuit()
    {
    }
}
