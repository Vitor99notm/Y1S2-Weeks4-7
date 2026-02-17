using UnityEngine;
using UnityEngine.Events;

public class SpikeHazards : MonoBehaviour
{
    public SpriteRenderer spikes;
    public bool isInSpikes = false;
    public UnityEvent OnEnterSpikes;
    public UnityEvent OnExitSpikes;


    void Start()
    {
        
    }

    void Update()
    {
        if (spikes.bounds.Contains(transform.position) == true)
        {
            if (isInSpikes == true)
            {

            }
            else
            {
                isInSpikes = true;
                OnEnterSpikes.Invoke();
            }
        }
        else
        {
            if (isInSpikes == true)
            {
                isInSpikes = false;
                OnExitSpikes.Invoke();
            }
        }
    }
}
