using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject Pipe;
    public Pipe pipes;
    public float spawnRate = 2f;
    private float timer = 0f;
    public float heightOffset = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        //Every frame it ask if timer is less than spawnrate, if it is count timer up, if not spawn a pipe and reset timer//
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;

        }
        else
        {
            spawnPipe();
            timer = 0f;
        }
    }
        void spawnPipe()
        {
            //Instantiate spawns new gameobject//
            float lowestPoint = transform.position.y - heightOffset;
            float highestPoint = transform.position.y + heightOffset;

            Instantiate(Pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
        }
      
    }
