using UnityEngine;

public class TSEventActivateWindow : TSEvent
{
    [SerializeField] private string hierachyName;

    protected override void OnStart()
    {
        GameManager.Instacne.windowManager.hierarchyManager.ActivateHierarchy(hierachyName);
        QuitEvent();
    }

    protected override void OnQuit()
    {
    }
}

