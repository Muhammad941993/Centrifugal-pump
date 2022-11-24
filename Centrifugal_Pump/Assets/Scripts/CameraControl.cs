using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        CameraMovement();
    }
   

    void CameraMovement()
    {
        float rotateHorizontal = Input.GetAxis("Mouse X");
        float rotateVertical = Input.GetAxis("Mouse Y");
        float Zoomin = Input.mouseScrollDelta.y * Time.deltaTime;
        float ArroeX = Input.GetAxis("Horizontal") * Time.deltaTime;
        float Arroey = Input.GetAxis("Vertical") * Time.deltaTime;

        transform.Rotate(-rotateVertical, rotateHorizontal, 0);
        //transform.Translate(Vector3.forward * Zoomin * Time.deltaTime);
        transform.Translate(ArroeX, Arroey, Zoomin);
    }
}
