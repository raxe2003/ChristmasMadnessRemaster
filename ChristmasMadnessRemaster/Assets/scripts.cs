using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scripts : MonoBehaviour

 {
    // Start is called before the first frame update
    public float playerSpeed = 10f;
    public CharacterController cc;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Basic Movement
        if (Input.GetKey(KeyCode.W))
        {
            cc.Move(Vector3.forward * playerSpeed * Time.deltaTime);
        }else if (Input.GetKey(KeyCode.S))
        {
            cc.Move(Vector3.back * playerSpeed * Time.deltaTime);
        }else if (Input.GetKey(KeyCode.D))
        {
            cc.Move(Vector3.right * playerSpeed * Time.deltaTime);
        }else if (Input.GetKey(KeyCode.A))
        {
            cc.Move(Vector3.left * playerSpeed * Time.deltaTime);
        }

        

    }
}
