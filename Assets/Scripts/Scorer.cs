using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;
    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag != "Hit")
        {
            hits++; //I can also use hits = hits + 1; same thing  
            Debug.Log("You've Hit Something This Many Times: " + hits);
        }
        
    }
}
