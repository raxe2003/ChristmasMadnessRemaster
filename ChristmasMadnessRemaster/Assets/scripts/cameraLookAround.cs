using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraLookAround : MonoBehaviour
{
    private float mouseSens = 1000f;
    public Transform playerBody;
    public Transform playerCamera;
    private float xRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime;

        playerBody.Rotate(Vector3.up * mouseX);

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -45, 45);
        playerCamera.localRotation = Quaternion.Euler(xRotation, 0, 0);

    }
}
