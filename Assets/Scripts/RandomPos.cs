using UnityEngine;

public class RandomPos : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector2 randomPos = transform.position;
        randomPos.x = Random.Range(-10, 10);
        randomPos.y = Random.Range(-3,3);
        transform.position = randomPos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
