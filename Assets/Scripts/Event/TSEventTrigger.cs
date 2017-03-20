using Ultimate;
using UnityEngine;

public class TSEventTrigger : MonoBehaviour
{
    [SerializeField] private TSEvent firstEvent;
    [SerializeField] private AudioClip audioClip;

    public AudioSource audioSource;

    protected virtual void OnTriggerEnter(Collider enterColl)
    {
        if (!enterColl.transform.CompareTag("Player"))
            return;

        if(firstEvent != null)
            firstEvent.StartEvent();

        audioSource.PlayOneShot(audioClip);
        
        gameObject.SetActive(false);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(1, 0, 0, 0.4F);
        Gizmos.DrawCube(transform.position, GetComponent<BoxCollider>().size);
    }
}
