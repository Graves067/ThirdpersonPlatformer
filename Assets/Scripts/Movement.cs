using System;
using Unity.Cinemachine;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private Boolean Grounded = true;
    [SerializeField] private Rigidbody Rigidbody;
    [SerializeField] private float Speed = 2f;
    [SerializeField] private float jumpForce = 2.0f;
    [SerializeField] private CinemachineCamera freeLookCamera;

    public int MaxJump = 2;
    public int jCount = 0;

    // Update is called once per frame
    void Update()
    {

        transform.forward = freeLookCamera.transform.forward;
        transform.rotation = Quaternion.Euler(0, transform.rotation.eulerAngles.y, 0);

        Cursor.lockState = CursorLockMode.Locked;


        Vector3 inputVector = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 inputXZPlane = new(inputVector.x, 0, inputVector.y);
            Rigidbody.AddForce(freeLookCamera.transform.forward * Speed);
        } 



        if (Input.GetKeyDown(KeyCode.Space) && jCount < MaxJump)
        {
            jCount++;
            Rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            Grounded = false;

        }

        if (Grounded == true)
        {
            jCount = 0; // Reset jump count on ground
        }

        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Grounded = true;
        }
    }
}
