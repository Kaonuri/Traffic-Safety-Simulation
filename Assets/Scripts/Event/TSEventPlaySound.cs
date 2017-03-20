using UnityEngine;

public class TSEventPlaySound : TSEvent
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip audioClip;

    protected override void OnStart()
    {
        audioSource.clip = audioClip;
        audioSource.Play();
        QuitEvent();
    }

    protected override void OnQuit()
    {
    }
}
