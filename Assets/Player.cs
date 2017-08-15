using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // <acess-specifier> <data-type> (optional initialization) 
    public int lives = 3;
    public float rotationSpeed = 2;
    public float acceleration = 50f;
    public float deceleration = 0.025f;

    private Rigidbody2D rigid; //default value null



    // Use this for initialization
    // <acess-specifier> <return-type> <function-name>
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rigid.AddForce(transform.right * acceleration);
        }

        else

        {
            rigid.velocity = rigid.velocity + -rigid.velocity * deceleration;
        }

        if (Input.GetKey(KeyCode.S))
        {
            rigid.AddForce(-transform.right * acceleration);
        }

        else

        {
            rigid.velocity = rigid.velocity + -rigid.velocity * deceleration;
        }


        if (Input.GetKey(KeyCode.A))
        {
            rigid.rotation += rotationSpeed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            rigid.rotation += -rotationSpeed;
        }
    }
}

