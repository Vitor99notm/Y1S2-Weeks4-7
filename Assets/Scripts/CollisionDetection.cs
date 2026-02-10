using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    public Transform charPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Calculates the distance between the car and the character
        float distance = Vector2.Distance(transform.position, charPos.position);

        //Character start position
        Vector2 startPos = transform.position;
        startPos.x = 0;
        startPos.y = -4.35f;

        //If character hit, take back to start
        if(distance < 1)
        {
            charPos.position = startPos;
        }
    }
}
