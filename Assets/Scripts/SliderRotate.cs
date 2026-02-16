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

    //Public void so function can be accessed through buttons and/or sliders
    public void sliderRotate(float rotate)
    {
        //Rotates the game object through the z value
		Vector3 newRotation = transform.eulerAngles;
		newRotation.z += rotate;
		transform.eulerAngles = newRotation;
	}
}
