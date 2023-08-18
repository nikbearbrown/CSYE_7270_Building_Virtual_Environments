using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Playercontroll : MonoBehaviour
{
    // Set A Rigid body
    private Rigidbody2D rb;
    // Horizontal speeo
    private float speed = 1f; 
    // Get role animation
    private Animator anim;


    void Awake()
    {
        // Load objtives
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        name = this.gameObject.name;
    }

    void Update()
    {
        playermove();

    }

    void playermove()
    {
        // Get input A is -1 D is 1
        float horizontalmove = Input.GetAxis("Horizontal");
        // Get facing direction 
        float facedirection = Input.GetAxisRaw("Horizontal");
        move = false;
        // define facing direction
        if (facedirection != 0)
        {
            transform.localScale = new Vector3(facedirection, 1, 1);
        }
        // define movements
        if (horizontalmove != 0)
        {
            this.transform.position = new Vector2(horizontalmove * speed * Time.fixedDeltaTime+ this.transform.position.x, this.transform.position.y);
            move = true;
        }
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.position = new Vector2(this.transform.position.x, this.transform.position.y+ speed * Time.fixedDeltaTime);
            move = true;
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.position = new Vector2(this.transform.position.x, -speed * Time.fixedDeltaTime+ this.transform.position.y);
            move = true;
        }
        //ִ Run animation
        anim.SetBool("run", move);
    }


}
