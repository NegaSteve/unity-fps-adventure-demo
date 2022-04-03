using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class teleport: MonoBehaviour
{

    public Transform respawn;
    public Transform respawn2;
    

    private void OnControllerColliderHit(ControllerColliderHit col)
    {
        if (col.collider.gameObject.tag == "Respawn")
        {
            transform.position = respawn.position;
        }

        if (col.collider.gameObject.tag == "Respawn2")
        {
            transform.position = respawn2.position;
        }

    }
}