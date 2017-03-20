using UnityEngine;

public class TSEventStopSound : TSEvent
{
    [SerializeField] private AudioSource audioSource;

    protected override void OnStart()
    {
        audioSource.Stop();
        QuitEvent();
    }

    protected override void OnQuit()
    {
    }
}
