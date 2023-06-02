using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class messageRed : MonoBehaviour
{
    public GameObject Message;
    public LogicManage logic;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManage>();
    }

    // Update is called once per frame
    void Update()
    {
        if(logic.playerScore == 4)
        {
            Message.SetActive(true);
        }
        else if(logic.playerScore >= 6)
        {
            Message.SetActive(false);
        }

    }
}
