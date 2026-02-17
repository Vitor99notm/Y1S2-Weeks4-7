using UnityEngine;
using UnityEngine.Events;

public class ContactSensor : MonoBehaviour
{
    public SpriteRenderer hazard;
    public bool isInHazard = false;
    public UnityEvent OnEnterHazard;
    public UnityEvent OnExitHazard;

    public UnityEvent<float> OnRandomNumber; 

    void Start()
    {
        
    }

    void Update()
    {
        //is the player inside the hazard sprite?
        if (hazard.bounds.Contains(transform.position) == true)
        {
            if(isInHazard == true)
            {
                //we're still in the hazard

            }
            else
            {
                //just entered the hazard
                //Y: player HAS tripped the sensor
                isInHazard = true;
                Debug.Log("Entered the hazard!");
                OnEnterHazard.Invoke();
            }


        }
        else
        {
            if(isInHazard == true)
            {
                //we just left the hazard
                //N: player has NOT tripped the sensor
                isInHazard = false;
                Debug.Log("Exited the hazard!");
                OnExitHazard.Invoke();
                OnRandomNumber.Invoke(Random.Range(0,10));
            }
            else
            {
                //we're still not in the hazard
                
            }


        }

    }

    public void ShowNumber(float number)
    {
        Debug.Log(number);
    }
}
