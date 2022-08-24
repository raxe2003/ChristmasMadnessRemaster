using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectPresent : MonoBehaviour
{
    // Start is called before the first frame update
    public float range;
    public Camera playerCamera;
    bool didHit = false;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        changeMaterial changeM;
        RaycastHit rCast;
        if (Physics.Raycast(playerCamera.transform.position, playerCamera.transform.forward, out rCast, range) && rCast.transform.tag == "presents" && Input.GetKey(KeyCode.E))
        {

            changeMaterial ch = rCast.collider.GetComponent<changeMaterial>();
            changeM = ch;
            if (ch != null)
            {
                Debug.Log("got materail");
                ch.materialChange("new");
                didHit = true;
            }
            Debug.Log("hit " + rCast.transform.name);
        }
        
    }
}
