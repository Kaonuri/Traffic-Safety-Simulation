using UnityEngine;

public class TSEventGaze : TSEvent
{
    [SerializeField] private Transform centerEyeAnchor;
    [SerializeField] private string targetTag;

    protected override void OnStart()
    {
    }

    void FixedUpdate()
    {
        Vector3 forward = centerEyeAnchor.TransformDirection(Vector3.forward);

        RaycastHit hit;
        Ray ray = new Ray(centerEyeAnchor.position, centerEyeAnchor.forward);

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.CompareTag(targetTag))
                QuitEvent();
        }
    }

    protected override void OnQuit()
    {
    }
}
