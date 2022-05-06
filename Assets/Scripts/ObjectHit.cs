using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("You crashed into the wall!");   
            GetComponent<MeshRenderer>().material.color = Color.blue;
            gameObject.tag = "Hit";
        }
        
    }
}
