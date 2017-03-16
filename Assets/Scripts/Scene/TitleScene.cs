using Ultimate.Scene;

public class TitleScene : SceneHandlerBase
{
    private AirVRCameraRig _airVrCameraRig;

    public override void OnEnterScene()
    {
        _airVrCameraRig = FindObjectOfType<AirVRCameraRig>();
        _airVrCameraRig.pointer.isEnabled = true;
    }    

    public void ChangeToSelectScene()
    {
        GameManager.Instacne.sceneManger.ChangeScene("Select");
    }

    public override void OnExitScene()
    {
        _airVrCameraRig.pointer.isEnabled = false;
    }
}
