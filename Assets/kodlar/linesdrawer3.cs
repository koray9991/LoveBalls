using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class linesdrawer3 : MonoBehaviour
{
    public GameObject circle;
    Camera cam;
    public GameObject ball1, ball2;
    public bool gravity0;
    void Start()
    {
        if (gravity0)
        {
            ball1.GetComponent<Rigidbody2D>().gravityScale = 0;
            ball2.GetComponent<Rigidbody2D>().gravityScale = 0;
        }
        cam = Camera.main;
    }
    private void Update()
    {
        if (Input.GetMouseButton(0) && gamemanager.i==3 && !gamemanager.bitti)
        {
            circle.GetComponent<BoxCollider2D>().enabled = true;
            Vector2 mouseposition = cam.ScreenToWorldPoint(Input.mousePosition);
            circle.transform.position = mouseposition;
            ball1.GetComponent<Rigidbody2D>().gravityScale = 1;
            ball2.GetComponent<Rigidbody2D>().gravityScale = 1;
        }
        if (Input.GetMouseButtonUp(0))
        {
            circle.GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}
