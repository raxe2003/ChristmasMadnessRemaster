using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCamera : MonoBehaviour
{
    // Start is called before the first frame update
    private float Xsensitivity = 1000f;
    private float Ysensitivity = 1000f;
    public Transform player;
    public Transform playerCamera;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //move y
        float moveY = Input.GetAxis("Mouse X") * Xsensitivity;
        player.Rotate(0, moveY * Time.deltaTime, 0);

        // moze x
        float moveX = Input.GetAxis("Mouse Y") * Ysensitivity;
        playerCamera.Rotate(-moveX * Time.deltaTime, 0, 0);

    }
}
