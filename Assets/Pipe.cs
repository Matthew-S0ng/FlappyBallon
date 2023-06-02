using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float deadZone = -45f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime; //means multiplication happens on every PC//

        if(transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
