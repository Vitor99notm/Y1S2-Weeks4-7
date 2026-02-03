using UnityEngine;

public class SliderRotate : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void sliderRotate(float rotate)
    {
		Vector3 newRotation = transform.eulerAngles;
		newRotation.z += rotate;
		transform.eulerAngles = newRotation;
	}
}
