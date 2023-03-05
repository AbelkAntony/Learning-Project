using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public KeyCode moveKey;
    public float speed;
    public Vector3 moveDirection;

    public float pauseTime;
    public float pauseTimer = 0;

    public float activeTime;
    public float activeTimer = 0;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
		pauseTimer += Time.deltaTime;

		if (pauseTimer >= pauseTime)
        {
            activeTimer += Time.deltaTime;
            transform.position += speed * Time.deltaTime * moveDirection;

            if(activeTimer >= activeTime)
            {
                pauseTimer = 0;
                activeTimer = 0;
            }
        }
    }

}
