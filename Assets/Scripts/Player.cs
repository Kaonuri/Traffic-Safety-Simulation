using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    private AudioSource audioSource;
    [SerializeField] private AudioClip[] footstepClips;

    public Transform centerEyeAnchor { private set; get; }
    public AirVRCameraRig airVRCameraRig { private set; get; }
    
    public float speed = 2f;
    public bool canMove = true;

    public NavMeshAgent navMeshAgent { private set; get; }

    [SerializeField] private TSEvent startingEvent;

    private void Awake()
    {
        GameManager.Instacne.SetPlayer(this);

        audioSource = GetComponent<AudioSource>();

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
        if(AirVRInput.GetButton(airVRCameraRig, AirVRInput.Touchpad.Button.BackButton))
        {
            GameManager.Instacne.sceneManger.ChangeScene("Title");
        }

        if (canMove)
        {
            if (AirVRInput.GetButton(airVRCameraRig, AirVRInput.Touchpad.Button.Touch))
            {
                Move();
                if (!audioSource.isPlaying)
                {
                    audioSource.clip = footstepClips[Random.Range(0, footstepClips.Length - 1)];
                    audioSource.Play();
                }
            }

            else
            {
                audioSource.Stop();
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