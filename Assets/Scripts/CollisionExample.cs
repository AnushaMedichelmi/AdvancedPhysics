using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision Enter State");
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Collison Stay State");
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Collision Exit State");
    }
}
