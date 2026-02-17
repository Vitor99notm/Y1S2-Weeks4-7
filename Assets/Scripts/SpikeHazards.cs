using UnityEngine;
using UnityEngine.Events;

public class SpikeHazards : MonoBehaviour
{
    public float currentTime = 0;
    public float maxTime = 3;

    public SpriteRenderer spikes;
    public bool isInSpikes = false;
    public UnityEvent OnEnterSpikes;
    public UnityEvent OnExitSpikes;


    void Start()
    {
        
    }

    void Update()
    {
        currentTime += Time.deltaTime;

        //Timer to countdown when the spikes turn off/on
        if(currentTime > maxTime)
        {
            currentTime = 0;
            //spikes.gameObject.SetActive(!gameObject.activeInHierarchy);

            //After each instance that the timer reaches 3 seconds the spikes object turns off/on
            if(spikes.gameObject.activeInHierarchy == false)
            {
                spikes.gameObject.SetActive(true);
            }
            else if(spikes.gameObject.activeInHierarchy == true)
            {
                spikes.gameObject.SetActive(false);
            }
        }

        if (spikes.bounds.Contains(transform.position) == true && spikes.gameObject.activeInHierarchy)
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
