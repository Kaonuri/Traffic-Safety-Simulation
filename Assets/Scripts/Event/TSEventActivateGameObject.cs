using UnityEngine;

public class TSEventActivateGameObject : TSEvent
{
    [SerializeField] private GameObject gameObject;

    protected override void OnStart()
    {
        gameObject.SetActive(true);
        QuitEvent();
    }

    protected override void OnQuit()
    {
    }
}
