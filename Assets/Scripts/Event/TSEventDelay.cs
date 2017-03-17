using UnityEngine;
using Time = Ultimate.Time;

public class TSEventDelay : TSEvent
{
    [SerializeField] private float duration;
    private float elapsedTime;

    protected override void OnStart()
    {
        elapsedTime = 0f;
    }

    private void Update()
    {
        if(elapsedTime > duration)
            QuitEvent();

        elapsedTime += Time.globalDeltaTime;
    }

    protected override void OnQuit()
    {
    }
}
