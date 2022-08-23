using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectPresent : MonoBehaviour
{
    // Start is called before the first frame update
    public float range;
    public Camera playerCamera;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit rCast;
        if(Physics.Raycast(playerCamera.transform.position, playerCamera.transform.forward, out rCast, range) && rCast.transform.tag == "")
        {
            
        }
    }
}
