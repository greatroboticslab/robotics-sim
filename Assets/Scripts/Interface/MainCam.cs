using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCam : MonoBehaviour
{

    public float sensitivity;
    public int mode;
    
    public Vector3 targetPos;
    public Vector3 camPos;

    // Start is called before the first frame update
    void Start()
    {
    	Cursor.lockState = CursorLockMode.Locked;
        camPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
    
    	transform.position = Vector3.Lerp(transform.position, camPos, 0.6f*Time.deltaTime);
    	
    	
        if(mode == 0) {
        	Vector3 lookRot = transform.localRotation.eulerAngles;
        	lookRot.y += Input.GetAxis("Mouse X") *Time.deltaTime * sensitivity;
        	transform.localRotation = Quaternion.Euler(lookRot);
        }
        else {	
    		Quaternion desiredRotation = Quaternion.LookRotation(targetPos - transform.position);
    		transform.rotation = Quaternion.Slerp(transform.rotation, desiredRotation, 0.5f * Time.deltaTime);
        }
    }
}
