using Ultimate.Scene;
using UnityEngine;

public class SelectScene : SceneHandlerBase
{
    [SerializeField] private AirVRPointer _airVRPointer;

    public override void OnEnterScene()
    {        
        _airVRPointer.isEnabled = true;
    }

    public void ChangeScene(Object nextScene)
    {
        GameManager.Instacne.sceneManger.ChangeScene(nextScene.name);
    }

    public override void OnExitScene()
    {
    }
}
