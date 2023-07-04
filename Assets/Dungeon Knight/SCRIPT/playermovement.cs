using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player_Movement : MonoBehaviour
{
    //Speed
    public int moveSpeed;

    //RigidBody
    public Rigidbody2D rigidBody;
    private Vector2 movementInput;
    public Animator anim;
    //to play animation
    public int coinsCount;
    public int healthPoints;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        ////Basic WASD Movement of Player
        ////W
        //if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        //{
        //    anim.enabled = true;
        //    anim.SetTrigger("BackAni");
        //}
        //if (Input.GetKeyUp(KeyCode.W))
        //{
        //    anim.enabled = false;
        //}

        ////S
        //if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.UpArrow))
        //{
        //    anim.enabled = true;
        //    anim.SetTrigger("ForwardAni");
        //}
        //if (Input.GetKeyUp(KeyCode.W))
        //{
        //    anim.enabled = false;
        //}
        ////A
        //if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        //{
        //    anim.enabled = true;
        //    anim.SetTrigger("LeftAni");
        //}
        //if (Input.GetKeyUp(KeyCode.W))
        //{
        //    anim.enabled= false;
        //}
        ////D
        //if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        //{
        //    anim.enabled = true;
        //    anim.SetTrigger("RightAni");
        //}
        //if (Input.GetKeyUp(KeyCode.W))
        //{
        //    anim.enabled = false;

        anim.SetFloat("horizontal", movementInput.x);
        anim.SetFloat("vertical", movementInput.y);
        anim.SetFloat("speed", movementInput.sqrMagnitude);


    }

    // best for physics calculations
    private void FixedUpdate()
    {
        //makes out player move
        rigidBody.velocity = movementInput * moveSpeed;
    }

    private void OnMove(InputValue inputValue)
    {
        //WASD = vector 2 nvalues
        movementInput = inputValue.Get<Vector2>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("coins"))
        {
            Destroy(collision.gameObject);
            coinsCount++;
        }

        if (collision.gameObject.CompareTag("health"))
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("speed"))
        {
            Transform col = collision.transform;
            col.transform.position = new Vector2(999, 999);
        }
    }


}