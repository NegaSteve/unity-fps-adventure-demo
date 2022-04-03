using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsToCollect : MonoBehaviour
{
    public static int objects = 0;
    public AudioClip sound;

   
    // Use this for initialization
    void Awake ()
    {
        objects++;
		
	}
	
	// Update is called once per frame
	void OnTriggerEnter  (Collider plyr)
    {
        if (plyr.gameObject.tag == "Player")
        {
            //omponent<AudioSource>().Play();
            AudioSource.PlayClipAtPoint(sound, transform.position);
           //ebug.Log("Sound played");
            objects--;
            gameObject.SetActive(false);
            //Debug.Log("Object");

        }
		
	}
}
