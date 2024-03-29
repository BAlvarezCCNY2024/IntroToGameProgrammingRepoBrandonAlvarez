using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    //M/W Class
    //GLOBAL VARIALBES
    public Rigidbody2D rbBall;

    public float force = 200;

    private float xDir;
    private float yDir;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("hello world");

        Vector3 direction = new Vector3(0, 0, 0);

        xDir = Random.Range(0, 2);
        //Debug.Log("xDir ="+xDir);
        if (xDir == 0)
        {
            direction.x = -1;
        } else if (xDir == 1) 
        {
            direction.x = 1;
        }

        //add force to start movement
        rbBall.AddForce(direction * force);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
