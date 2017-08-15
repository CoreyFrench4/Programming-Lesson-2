using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsController : MonoBehaviour {
    public float acceleration = 50f;

    private Rigidbody rigid;
    // Use this for initialization
    void Start () {
        rigid = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            rigid.AddForce(transform.forward * acceleration);
        }

        

        if (Input.GetKey(KeyCode.S))
        {
            rigid.AddForce(-transform.forward * acceleration);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rigid.AddForce(transform.right * acceleration);
        }

     

        if (Input.GetKey(KeyCode.A))
        {
            rigid.AddForce(-transform.right * acceleration);
        }
    }
}
