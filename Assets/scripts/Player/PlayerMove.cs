using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    CharacterController SS;
    public float MoveSpeed = 5.0f;
    public static float RunSpeed = 12.0f;
    public float JumpSpeed = 15.0f;
    public float gravity = -9.8f;
    public float YSpeed = -1.5f;
    public float Standing = -1.5f;
    public float MinSpeed = -10.0f;
    public GameObject playerObject;
    void Start()
    {
        SS = GetComponent<CharacterController>();
    }

    void Update()
    {        
        SS.Move(Vector3.forward * Time.deltaTime * RunSpeed);

            Vector3 movement=new Vector3(0,0,0);

        if (Input.GetKeyDown(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.gameObject.transform.position.x > LevelBoundary.leftSide)
            {
                SS.Move(Vector3.left * Time.deltaTime * MoveSpeed);
            }
        }


        if (Input.GetKeyDown(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (this.gameObject.transform.position.x < LevelBoundary.rightSide)
            {
                SS.Move(Vector3.right * Time.deltaTime * MoveSpeed);
            }
        }


        if (SS.isGrounded)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                YSpeed = JumpSpeed;
                playerObject.GetComponent<Animator>().Play("Jump");
            }

            else
            {
                YSpeed = Standing;
                playerObject.GetComponent<Animator>().Play("Standard Run");
            }

        }

        else
        {
            YSpeed += 5 * gravity * Time.deltaTime;
            if (YSpeed < MinSpeed)
            {
                YSpeed = MinSpeed;
            }
        }

        movement.y = YSpeed;
        movement *= Time.deltaTime;
        SS.Move(movement);
    }
}
