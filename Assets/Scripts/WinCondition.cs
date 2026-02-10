using UnityEngine;
using UnityEngine.UI;

public class WinCondition : MonoBehaviour
{
    //public Text winCondition;
    public Transform charPos;
    public GameObject textSprite;
    public AudioSource winSound;
    public float winCount = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Distance between finish and character
        float distance = Vector2.Distance(transform.position, charPos.position);

        if(distance < 1)
        {
           //Good code to remember to easily activate objects that are off.
           textSprite.SetActive(true);

            if (winCount == 0)
            {
                winSound.Play();
                winCount = 1;
            }
        }
    }
}
