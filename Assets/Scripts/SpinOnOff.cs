using UnityEngine;

public class SpinOnOff : MonoBehaviour
{
    public float speed = 100;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newRotation = transform.eulerAngles;
        newRotation.z += speed * Time.deltaTime;
        transform.eulerAngles = newRotation;
    }

    public void SpinOn()
    {
        speed = 100;
    }

    public void SpinOff()
    {
        speed = 0;
    }
}
