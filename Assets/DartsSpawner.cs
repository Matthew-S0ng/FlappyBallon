using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DartsSpawner : MonoBehaviour
{
    public GameObject Dart;
    public LogicManage logic;
    public float spawnRate = 2;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManage>();
    }


    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate)
        {
            timer += Time.deltaTime;
            if (logic.playerScore % 5 == 0 && logic.playerScore != 0)
            {
                spawnDart();
            }
            if (logic.playerScore > 20 && Input.GetKeyDown(KeyCode.Space))
            {
                spawnDart();
            }
        }
        else
        {
            spawnDart();
            timer = 0;
        }
       
    }
    void spawnDart()
    {
        Instantiate(Dart, new Vector3(transform.position.x, Random.Range(-12, 12), 0), transform.rotation);
    }
}