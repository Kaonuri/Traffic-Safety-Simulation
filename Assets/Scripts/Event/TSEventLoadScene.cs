using UnityEngine;

public class TSEventLoadScene : TSEvent
{
    [SerializeField] private string sceneName;

    protected override void OnStart()
    {
        GameManager.Instacne.sceneManger.ChangeScene(sceneName);
        QuitEvent();
    }

    protected override void OnQuit()
    {
    }
}
