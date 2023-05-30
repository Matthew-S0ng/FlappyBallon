using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicManage logic;
    public bool ballisAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManage>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && ballisAlive)
        {
            myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, flapStrength);
        }
     
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        ballisAlive = false;
    }
}
