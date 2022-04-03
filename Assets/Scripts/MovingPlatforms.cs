using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatforms : MonoBehaviour {

    public Transform movingPlatform;
    public Transform startPos;
    public Transform endPos;
    public Vector3 newPosition;
    public string currentState;
    public float smooth;
    public float resetTime;

	void Start () {
        ChangeTarget();
		
	}
	
	
	void FixedUpdate ()
    {
        movingPlatform.position = Vector3.Lerp(movingPlatform.position, newPosition, smooth * Time.deltaTime);
		
	}

    void ChangeTarget()
    {
        if (currentState == "Moving to startPos")
        {
            currentState = "Moving to endPos";
            newPosition = endPos.position;
        }

        else if (currentState == "Moving to endPos")
        {
            currentState = "Moving to startPos";
            newPosition = startPos.position;
        }

        else if (currentState == "")
        {
            currentState = "Moving to endPos";
            newPosition = endPos.position;
        }
        Invoke("ChangeTarget", resetTime);
    }


}
