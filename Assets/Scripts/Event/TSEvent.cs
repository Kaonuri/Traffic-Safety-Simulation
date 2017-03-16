using UnityEngine;

public abstract class TSEvent : MonoBehaviour
{
    [SerializeField] protected TSEvent nextEvent;

    protected virtual void Awake()
    {
        gameObject.SetActive(false);
    }

    protected abstract void OnStart();
    protected abstract void OnQuit();

    public void StartEvent()
    {
        gameObject.SetActive(true);
        OnStart();
    }

    public void QuitEvent()
    {
        gameObject.SetActive(false);
        OnQuit();

        if (nextEvent == null)
            return;

        nextEvent.StartEvent();
    }
}
