using UnityEngine;
using Time = Ultimate.Time;

public class TSEventDeactivateWindow : TSEvent
{
    [SerializeField] private string hierachyName;

    private Hierarchy hierarchy;
    private CanvasGroup canvasGroup;

    private float elapsedTime;
    private float fadeDuration = 0.3f;

    protected override void OnStart()
    {

        canvasGroup = GameManager.Instacne.windowManager.hierarchyManager.GetHierarchy(hierachyName).GetComponent<CanvasGroup>();

        canvasGroup.alpha = 1f;
        elapsedTime = 0f;
    }

    private void Update()
    {
        canvasGroup.alpha -= Time.globalDeltaTime / fadeDuration;
        elapsedTime += Time.globalDeltaTime;        

        if (elapsedTime >= fadeDuration)
        {
            GameManager.Instacne.windowManager.hierarchyManager.DeactivateHierarchy(hierachyName);
            QuitEvent();
        }
    }

    protected override void OnQuit()
    {
    }
}

