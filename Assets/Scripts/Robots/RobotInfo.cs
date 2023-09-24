using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotInfo : MonoBehaviour
{

	public GameObject robot;
	public bool hovering;
	private Vector3 sizeGoal;

    // Start is called before the first frame update
    void Start()
    {
        sizeGoal = new Vector3(1f,1f,1f);
    }

    // Update is called once per frame
    void Update()
    {
        if(hovering) {
        	sizeGoal = new Vector3(1.1f,1.1f,1.1f);
        }
        else {
        	sizeGoal = new Vector3(1f,1f,1f);
        }
        
        
        transform.localScale = Vector3.Lerp(transform.localScale,
        	sizeGoal, 3.5f * Time.deltaTime);
        	
	hovering = false;
    }
}
