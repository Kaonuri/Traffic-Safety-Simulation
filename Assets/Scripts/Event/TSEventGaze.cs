using UnityEngine;

public class TSEventGaze : TSEvent
{
    [SerializeField] private Transform centerEyeAnchor;
    [SerializeField] private TSGazeTrigger[] gazeTriggers;

    public bool allGazeTriggerIsClear
    {
        get
        {
            foreach (var gazeTrigger in gazeTriggers)
            {
                if (gazeTrigger.clear == false)
                {
                    return false;
                }
            }
            return true;
        }
    }

    protected override void OnStart()
    {
    }

    private void FixedUpdate()
    {
        Raycast();

        if(allGazeTriggerIsClear == true)
            QuitEvent();
    }

    private void Raycast()
    {
        RaycastHit hit;
        Ray ray = new Ray(centerEyeAnchor.position, centerEyeAnchor.forward);

        if (Physics.Raycast(ray, out hit))
        {
            var currentGazeTrigger = hit.transform.GetComponent<TSGazeTrigger>();

            if (currentGazeTrigger == null)
                return;

            foreach (var gazeTrigger in gazeTriggers)
            {
                if (currentGazeTrigger == gazeTrigger)
                {
                    currentGazeTrigger.Clear();                    
                }
            }
        }
    }

    protected override void OnQuit()
    {
    }
}
