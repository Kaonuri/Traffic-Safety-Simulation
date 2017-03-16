using UnityEngine;

public class TSEventMoveVehicle : TSEvent
{
    [SerializeField] private Vehicle vehicle;

    protected override void OnStart()
    {
        if(!vehicle.gameObject.activeSelf)
            vehicle.gameObject.SetActive(true);
        vehicle.navMove.StartMove();
    }

    private void Update()
    {
        if (vehicle.navMove.currentPoint == vehicle.navMove.waypoints.Length - 1)
        {
            QuitEvent();
        }
    }

    protected override void OnQuit()
    {
        vehicle.gameObject.SetActive(false);
    }
}
