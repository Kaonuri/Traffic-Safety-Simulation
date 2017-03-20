using Ultimate;
using UnityEngine;

public class WindowManager : MonoBehaviour
{
    public HierarchyManager hierarchyManager { private set; get; }
    public CanvasGroup canvasGroup { private set; get; }

    public AudioSource audioSource;
    public AudioClip[] audioClips;

    private void Awake()
    {
        GameManager.Instacne.SetWindowManger(this);
        hierarchyManager = GetComponent<HierarchyManager>();
        hierarchyManager.onActivateHierarchy += OnActivateHandler;
        hierarchyManager.onDeactivateHierarchy += OnDeactivateHandler;
        hierarchyManager.onChangeHierarchy += OnChangeHandler;
    }

    public void OnActivateHandler()
    {
        audioSource.PlayOneShot(audioClips[1]);

        var centerEyeAnchor = GameManager.Instacne.player.centerEyeAnchor;

        transform.localPosition = new Vector3(centerEyeAnchor.localPosition.x, transform.localPosition.y, centerEyeAnchor.localPosition.z);
        transform.LookAt(GameManager.Instacne.player.centerEyeAnchor);
        transform.localEulerAngles = new Vector3(0f, transform.localEulerAngles.y, transform.localEulerAngles.z);
        transform.localPosition -= transform.forward * 3f;

        var airVRPointer = GameManager.Instacne.player.airVRCameraRig.pointer;

        if (airVRPointer == null)
        {
            Debug.LogError("airVRPointer is null");
            return;
        }

        airVRPointer.isEnabled = true;
    }

    public void OnChangeHandler()
    {
        audioSource.PlayOneShot(audioClips[1]);
    }

    public void OnDeactivateHandler()
    {
        audioSource.PlayOneShot(audioClips[2]);

        var airVRPointer = GameManager.Instacne.player.airVRCameraRig.pointer;

        if (airVRPointer == null)
        {
            Debug.LogError("airVRPointer is null");
            return;
        }

        airVRPointer.isEnabled = false;
    }

    public void PlayMotorcyclePanelSound()
    {
        audioSource.PlayOneShot(audioClips[0]);
    }
}
