using UnityEngine;

public class TSEventTrigger : MonoBehaviour
{
    [SerializeField] private TSEvent firstEvent;

    protected virtual void OnTriggerEnter(Collider enterColl)
    {
        if (!enterColl.transform.CompareTag("Player"))
            return;

        if(firstEvent != null)
            firstEvent.StartEvent();

        gameObject.SetActive(false);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(1, 0, 0, 0.4F);
        Gizmos.DrawCube(transform.position, GetComponent<BoxCollider>().size);
    }
}
