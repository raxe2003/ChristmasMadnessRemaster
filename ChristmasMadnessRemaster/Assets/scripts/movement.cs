using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{


    public float gravity = - 2f;
    public float jumpHeight = 4f;
    public float playerSpeed = 5;
    public float sprintingSpeed = 10;
    public CharacterController cc;

    Vector3 velocity;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cc.isGrounded && velocity.y<0)
        {
            velocity.y = -2;
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            playerSpeed = sprintingSpeed;
            print("sprinting");
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        cc.Move(move * playerSpeed * Time.deltaTime);

           if (Input.GetButtonDown("Jump"))
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
        velocity.y += gravity * Time.deltaTime;
        cc.Move(velocity * Time.deltaTime);
        playerSpeed = 10;

    }
}
