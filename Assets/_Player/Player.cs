using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private CharacterController thisController;
    [SerializeField] private float JumpValue = 10;
    [SerializeField] private float Gravity = 10;

    private bool Jump = false;
    private Vector3 MoveDirection = Vector3.zero;
    private Transform playerMesh = null;
    private Animator thisAnimator = null;

    private float moveSpeed = 0.05f;

    void Start()
    {
        thisController = GetComponent<CharacterController>();
        thisAnimator = GetComponentInChildren<Animator>();
        playerMesh = transform.GetChild(0);
    }

    void Update()
    {
        if (!Jump)
        {
            if (Input.GetKey(KeyCode.Space))
                Jump = true;

            if (thisController.isGrounded)
            {
                float MoveX = Input.GetAxis("Horizontal") * moveSpeed;
                MoveDirection = transform.right * MoveX;

                float AngleZ = transform.eulerAngles.z - (MoveX * 50000 * Time.deltaTime);
                AngleZ = Mathf.Clamp(AngleZ, -45, 45);
                playerMesh.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, AngleZ);
            }

            MoveDirection.y -= Gravity * Time.deltaTime;
        }

        else
        {
            if (transform.position.y >= 0.25f)
                Jump = false;
            else
                MoveDirection.y += JumpValue * Time.deltaTime;
        }

        thisController.Move(MoveDirection);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -1.5f, 1.5f), transform.position.y, transform.position.z);
    }

}
