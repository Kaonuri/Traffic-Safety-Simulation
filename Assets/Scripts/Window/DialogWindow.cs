using UnityEngine;

public class DialogWindow : MonoBehaviour
{
    [SerializeField] private GameObject[] dialogs;

    private int currentDialogIndex = 0;

    public void Awake()
    {
//        foreach (var text in texts)
//        {
//            text.enabled = false;
//        }
//
//        foreach (var image in images)
//        {
//            image.enabled = false;
//        }
//
//        depths[currentScriptIndex].text.enabled = true;
//        depths[currentScriptIndex].image.enabled = true;
    }

    public void NextScript()
    {
        TutorialFinish();

//        depths[currentScriptIndex].text.enabled = false;
//        depths[currentScriptIndex].image.enabled = false;
//
//        if (currentScriptIndex == depths.Length - 1)
//            return;
//
//        currentScriptIndex++;
//        depths[currentScriptIndex].text.enabled = true;
//        depths[currentScriptIndex].image.enabled = true;
    }

    public void TutorialFinish()
    {
//        if (currentScriptIndex == 1)
//        {
//            GameManager.Instacne.player.canMove = true;
//            Deactive();
//        }
    }

    public void Active()
    {
        var windowManager = GameManager.Instacne.windowManager;
        var centerEyeAnchor = GameManager.Instacne.player.centerEyeAnchor;

        windowManager.transform.localPosition = new Vector3(centerEyeAnchor.localPosition.x, windowManager.transform.localPosition.y, centerEyeAnchor.localPosition.z);
        windowManager.transform.LookAt(GameManager.Instacne.player.centerEyeAnchor);
        windowManager.transform.localEulerAngles = new Vector3(0f, windowManager.transform.localEulerAngles.y, windowManager.transform.localEulerAngles.z);
        windowManager.transform.localPosition -= windowManager.transform.forward * 3f;

        var airVRPointer = GameManager.Instacne.player.airVRCameraRig.pointer;

        if (airVRPointer == null)
        {
            Debug.LogError("airVRPointer is null");
            return;
        }

        airVRPointer.isEnabled = true;
    }

    public void Deactive()
    {

        var airVRPointer = GameManager.Instacne.player.airVRCameraRig.pointer;

        if (airVRPointer == null)
        {
            Debug.LogError("airVRPointer is null");
            return;
        }

        airVRPointer.isEnabled = false;
    }
}
