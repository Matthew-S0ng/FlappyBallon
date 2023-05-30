using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallonScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody2D;
    public float flapStrength = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) == true)
        {
           myRigidBody2D.velocity = Vector2.up * flapStrength;
        }
    
    }
}
