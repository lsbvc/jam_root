using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour
{
    public float sensibility = 200;
    public Transform playerBody;
    public static CameraLook instance;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensibility * Time.deltaTime;
        playerBody.Rotate(Vector3.up * mouseX);

    }
}