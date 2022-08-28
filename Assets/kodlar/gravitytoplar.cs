using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravitytoplar : MonoBehaviour
{
    public bool gravity0;
    public GameObject ball1;
    void Start()
    {
        if (gravity0)
        {
            GetComponent<Rigidbody2D>().gravityScale = 0;
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (ball1.GetComponent<Rigidbody2D>().gravityScale == 1)
        {
            GetComponent<Rigidbody2D>().gravityScale = 1;
        }
    }
}
