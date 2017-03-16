using UnityEngine;

public class TSEventSetPlayerPosition : TSEvent
{    
    private Player player;
    [SerializeField] private Transform stopPoint;

    protected override void OnStart()
    {
        player = GameManager.Instacne.player;
    }

    private void Update()
    {
        Vector3 direction = (stopPoint.position - GameManager.Instacne.player.transform.position).normalized;
        player.navMeshAgent.Move(direction * player.speed * Time.deltaTime);

        if (Vector3.SqrMagnitude(stopPoint.position - player.transform.position) < 1f)
        {
            QuitEvent();
        }
    }

    protected override void OnQuit()
    {        
    }
}
