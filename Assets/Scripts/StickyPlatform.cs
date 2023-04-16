using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyPlatform : MonoBehaviour
{
    void OnCollisionEnter(Collision collision) 
    {
        if (collision.gameObject.name == "Bean (Player)") 
        {
            collision.gameObject.transform.SetParent(transform);
        }
    }
    
    void OnCollisionExit(Collision collision) 
    {
        if (collision.gameObject.name == "Bean (Player)") 
        {
            collision.gameObject.transform.SetParent(null);
        }
    }
}
