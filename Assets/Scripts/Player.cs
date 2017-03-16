using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    public Transform centerEyeAnchor { private set; get; }
    public AirVRCameraRig airVRCameraRig { private set; get; }
    
    public float speed = 2f;
    public bool canMove = true;

    public NavMeshAgent navMeshAgent { private set; get; }

    [SerializeField] private TSEvent startingEvent;

    private void Awake()
    {
        GameManager.Instacne.SetPlayer(this);

        centerEyeAnchor = Camera.main.transform;
        airVRCameraRig = GetComponentInChildren<AirVRCameraRig>();
        
        navMeshAgent = GetComponent<NavMeshAgent>();
        navMeshAgent.updateRotation = false;
    }

    private void Start()
    {
        startingEvent.StartEvent();
    }

    private void Update()
    {
        if (canMove)
        {
            if (AirVRInput.GetButton(airVRCameraRig, AirVRInput.Touchpad.Button.Touch))
            {
                Move();
            }            
        }
    }

    public void Move()
    {
        navMeshAgent.Move(centerEyeAnchor.forward * speed * Time.deltaTime);
    }

    public void ActiveMove()
    {
        canMove = true;
    }

    public void DeactiveMove()
    {
        canMove = false;
    }
}