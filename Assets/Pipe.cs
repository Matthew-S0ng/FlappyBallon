using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -45;
    public LogicManage logic;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManage>();
    }

    // Update is called once per frame
    void Update()
    {
        if(logic.playerScore % 5 == 0 && logic.playerScore != 0)
        {
            moveSpeed = moveSpeed + 1;
            transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime; //means multiplication happens on every PC//
        }
        

        if(transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
