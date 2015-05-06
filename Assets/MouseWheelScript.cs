using UnityEngine;
using System.Collections;

public class MouseWheelScript : MonoBehaviour {
    
    //Hello There

    public float cameraScrollSpeed; //Control how fast the camera zooms
    public bool middlePressed; //For storing if our middle mouse button is pressed or not
    public Camera myCamera; //For storing and using our camera

    void Start(){
        myCamera = GetComponent<Camera>(); //Store our camera
    }

	void Update () {
        
        //Did we press down the middle mouse button?
        if (Input.GetButtonDown("Fire3")){
            middlePressed = true;
        }

        //Did we let go of the middle mouse button?
        if (Input.GetButtonUp("Fire3")) {
            middlePressed = false;
        }

        //If the middle button pressed bool is true...
        if (middlePressed){
            
            //Put your panning stuff here

        }
        //Otherwise, we are NOT pressomg the middle mouse button, eh?
        else{
            //Store the value of our mouse scroll
            float mouseScroll = Input.GetAxis("Mouse ScrollWheel");

            //Set the ortho size (ie; zoom) based on the direction we scrolled multiplied by our scroll speed
            myCamera.orthographicSize = myCamera.orthographicSize - mouseScroll * cameraScrollSpeed;
        }
	}
}
