using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
    private CharacterController characterController;
    private Camera playerCamera;
    private Vector3 moveDirection;

    public float speed = 0.005f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;

    // Use this for initialization
	void Start () {
        characterController = gameObject.GetComponent<CharacterController>();
        playerCamera = gameObject.GetComponentInChildren<Camera>();
        moveDirection = Vector3.zero;
	}
	
	// Update is called once per frame
	void Update () {
        MovePlayer();
        RotatePlayer();
	}

    private void MovePlayer()
    {
        if (characterController.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;

            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;
        }
        moveDirection.y -= gravity * Time.deltaTime;
        characterController.Move(moveDirection);
    }

    private void RotatePlayer()
    {
        if(Input.GetAxis("Mouse X") < 0) //left
        {
            gameObject.transform.RotateAround(transform.position, transform.up, -40 * 0.1f);
        }
        if (Input.GetAxis("Mouse X") > 0) //Right
        {
            gameObject.transform.RotateAround(transform.position, transform.up, 40 * 0.1f);
        }
    }
}
