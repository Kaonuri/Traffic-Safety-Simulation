using Ultimate.Scene;
using UnityEngine;

public class SelectScene : SceneHandlerBase
{
    [SerializeField] private AirVRPointer _airVRPointer;

    private bool sceneLoading = false;

    public override void OnEnterScene()
    {        
        _airVRPointer.isEnabled = true;
    }

    public void ChangeScene(string nextSceneName)
    {
        if (sceneLoading == true)
            return;

        sceneLoading = true;        
        GameManager.Instacne.sceneManger.ChangeScene(nextSceneName);
    }

    public override void OnExitScene()
    {
    }
}
