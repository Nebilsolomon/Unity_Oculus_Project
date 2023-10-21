using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saber : MonoBehaviour
{

    private int destroyedObjectCount = 0;
    public float sensitivity = 2.0f;




    void Update()
    {
   

        this.controllerSaberWithMouse();
    }











    void controllerSaberWithMouse()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        // Adjust the hand anchor position based on mouse movement
        Vector3 newPosition = transform.position + new Vector3(mouseX * sensitivity, mouseY * sensitivity, 0f);
        transform.position = newPosition;
    }




private void OnTriggerEnter(Collider other)
{
    if (other.gameObject.tag == "CubeTag")
    {

     
                destroyedObjectCount++;

            Debug.Log("Destroyed objects: " + destroyedObjectCount);
             Destroy(other.gameObject);
     
    }
}


}








