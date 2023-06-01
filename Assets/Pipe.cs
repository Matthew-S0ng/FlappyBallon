using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float deadZone = -45f;
    public LogicManage logic;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManage>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime; //means multiplication happens on every PC//

        if (logic.playerScore % 5 == 0 && logic.playerScore != 0)
        {
            IncreaseSpeed();
        }
        

        if(transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
    void IncreaseSpeed()
    {
        moveSpeed += 0.05f;
    }
}
