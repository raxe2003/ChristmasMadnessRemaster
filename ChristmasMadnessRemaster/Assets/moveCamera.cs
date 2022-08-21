using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCamera : MonoBehaviour
{
    // Start is called before the first frame update
    public float Xsensitivity = 100f;
    public float Ysensitivity = 100f;
    public Transform player;
    public Transform camera;

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
        camera.Rotate(-moveX * Time.deltaTime, 0, 0);

    }
}
