using Ultimate.Scene;
using UnityEngine;

public class PlayScene : SceneHandlerBase
{
    [SerializeField] private AirVRPointer _airVRPointer;

    public override void OnEnterScene()
    {
    }

    protected override void ManualUpdate()
    {
        base.ManualUpdate();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _airVRPointer.isEnabled = !_airVRPointer.isEnabled;
        }
    }

    public override void OnExitScene()
    {
    }

    public void ChangeScene(Object nextScene)
    {
        GameManager.Instacne.sceneManger.ChangeScene(nextScene.name);
    }
}
