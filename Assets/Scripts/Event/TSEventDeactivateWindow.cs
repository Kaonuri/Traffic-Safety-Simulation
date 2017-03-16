using UnityEngine;

public class TSEventDeactivateWindow : TSEvent
{
    [SerializeField] private string hierachyName;

    protected override void OnStart()
    {
        GameManager.Instacne.windowManager.hierarchyManager.DeactivateHierarchy(hierachyName);
        QuitEvent();
    }

    protected override void OnQuit()
    {
    }
}

