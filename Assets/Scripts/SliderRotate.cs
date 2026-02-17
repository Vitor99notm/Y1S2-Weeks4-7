using UnityEngine;

public class SliderRotate : MonoBehaviour
{

    //Public void so function can be accessed through buttons and/or sliders
    public void sliderRotate(float rotate)
    {
        //Rotates the game object through the z value
		Vector3 newRotation = transform.eulerAngles;
		newRotation.z += rotate;
		transform.eulerAngles = newRotation;
	}
}
