using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicManage logic;
    public bool ballisAlive = true;
    [SerializeField] private AudioSource balloonPop;
    private bool hasPlayedPop = false;

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

        if(transform.position.y > 13 || transform.position.y < -13)
        {
            logic.gameOver();
            ballisAlive = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(!hasPlayedPop)
        {
            logic.gameOver();
            balloonPop.Play();
            ballisAlive = true;
        }
        ballisAlive = false;
    }

}
