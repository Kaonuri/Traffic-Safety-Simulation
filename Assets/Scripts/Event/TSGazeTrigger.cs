using UnityEngine;

public class TSGazeTrigger : MonoBehaviour
{
    [SerializeField] private GameObject awareSign;

    public bool clear { private set; get; }

    private void Awake()
    {
        if (awareSign != null)
            awareSign.gameObject.SetActive(false);
    }

    public void Clear()
    {
        if(awareSign != null)
            awareSign.gameObject.SetActive(true);
        clear = true;
    }
}
