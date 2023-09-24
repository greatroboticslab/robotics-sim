using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manip : MonoBehaviour
{

	public GameObject pointer;
	public SelectMenu selectMenu;
	public MainCam cam;
	public GameObject curRobot;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    public void StartRobot(RobotInfo robotInfo) {
    	curRobot = Instantiate(robotInfo.robot);
    	curRobot.transform.position = Vector3.zero;
    	cam.camPos = new Vector3(0.4f,1,-0.4f);
    	cam.targetPos = new Vector3(0,1.0f,0);
    }

    // Update is called once per frame
    void Update()
    {
        
        //Mouseover
        RaycastHit hit1;
		if (Physics.Raycast(pointer.transform.position, pointer.transform.TransformDirection(Vector3.forward), out hit1, Mathf.Infinity))
		{
			if(hit1.collider.gameObject.tag == "SelectableRobot") {
			hit1.collider.GetComponent<RobotInfo>().hovering = true;
		}
	}
        
        if (Input.GetMouseButtonDown(0)) {

		RaycastHit hit;
		if (Physics.Raycast(pointer.transform.position, pointer.transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
		{
			if(hit.collider.gameObject.tag == "SelectableRobot") {
		    		//Debug.Log("Did Hit");
		    		RobotInfo ri = hit.collider.GetComponent<RobotInfo>();
		    		StartRobot(ri);
		    		selectMenu.HideSelections();
		    		cam.mode = 1;
		    		Cursor.lockState = CursorLockMode.None;
		    	}
		}
        	
        }
        
    }
}
