using UnityEngine;
using Time = Ultimate.Time;

public class TSEventActivateWindow : TSEvent
{
    [SerializeField] private string hierachyName;

    private Hierarchy hierarchy;
    private CanvasGroup canvasGroup;

    private float elapsedTime;
    private float fadeDuration = 0.6f;

    protected override void OnStart()
    {
        GameManager.Instacne.windowManager.hierarchyManager.ActivateHierarchy(hierachyName);
        canvasGroup = GameManager.Instacne.windowManager.hierarchyManager.GetHierarchy(hierachyName).GetComponent<CanvasGroup>();
        canvasGroup.alpha = 0f;        
        elapsedTime = 0f;
    }

    private void Update()
    {
        canvasGroup.alpha += Time.globalDeltaTime / fadeDuration;
        elapsedTime += Time.globalDeltaTime;

        if (elapsedTime >= fadeDuration)
        {
            QuitEvent();
        }
    }

    protected override void OnQuit()
    {
    }
}
