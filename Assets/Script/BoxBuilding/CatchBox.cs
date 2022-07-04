using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchBox : MonoBehaviour
{
    [Header("PlayerMoving")]
    [SerializeField] private float moveSpeed;
    private Vector2 moveInput;
    public Rigidbody2D theRB;
    public Transform Body;

    private bool moveLeft;
    private bool dontMove;


    void Start()
    {
        dontMove = true;
    }

    void Update()
    {HandleMoving();}

     void HandleMoving()
    {
        if (dontMove)
        { StopMoving();}
        else
        {
           if (moveLeft)
            { MoveLeft();}
            else if (!moveLeft)
            { MoveRight();}
        }}

    public void AllowMovement(bool movement)
    {
        dontMove = false;
        moveLeft = movement;
    }

    public void DontAllowMovement()
    {
        dontMove = true;
    }

    public void MoveLeft()
    {
        theRB.velocity = new Vector2(-moveSpeed, theRB.velocity.y);
        Body.localScale = new Vector3(-1f, 1f, 1f);
    }
    public void MoveRight()
    {
        theRB.velocity = new Vector2(moveSpeed, theRB.velocity.y);
        Body.localScale = Vector3.one;
    }

    public void StopMoving()
    {
        theRB.velocity = new Vector2(0f, theRB.velocity.y);
    }
}
