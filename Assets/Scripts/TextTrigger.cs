using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextTrigger : MonoBehaviour {

    public GameObject textA;

	// Use this for initialization
	void Start ()
    {
        textA.SetActive(false);
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnTriggerEnter(Collider　other)
    { 
            textA.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        textA.SetActive(false);
        
    }
}
