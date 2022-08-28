using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tps : MonoBehaviour
{
    public Collider2D ball1collider, ball2collider,blu1,blu2;
    public GameObject b1, b2,tp1,tp2;
   public  float timer;
   public  bool pasif;
    public float x1,y1,x2,y2;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
        timer += Time.deltaTime;
         if (ball1collider.enabled && timer>0.51f)
         {
             b1.GetComponent<TrailRenderer>().enabled = true;
         }
        if (ball2collider.enabled && timer > 0.51f)
        {
            b1.GetComponent<TrailRenderer>().enabled = true;
        }
        if (timer > 0.3f)
        {
            pasif = false;
           
            
        }
        if (ball1collider.IsTouching(blu1) && timer>0.4f && !pasif)
        {
            b1.GetComponent<TrailRenderer>().enabled = false;
            b1.transform.position = tp2.transform.position;
            timer = 0;
            pasif = true;
            b1.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            if (b1.GetComponent<Rigidbody2D>().velocity == Vector2.zero)
            {
                b1.GetComponent<Rigidbody2D>().AddForce(new Vector2(x1, y1));
            }
           

        }
        if (ball1collider.IsTouching(blu2) && timer > 0.4f && !pasif)
        {
            b1.GetComponent<TrailRenderer>().enabled = false;
            b1.transform.position = tp1.transform.position;
            timer = 0;
            pasif = true;
            
            b1.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            if (b1.GetComponent<Rigidbody2D>().velocity == Vector2.zero)
            {
                b1.GetComponent<Rigidbody2D>().AddForce(new Vector2(x2, y2));
            }
        }
        if (ball2collider.IsTouching(blu1) && timer > 0.4f && !pasif)
        {
            b2.GetComponent<TrailRenderer>().enabled = false;
            b2.transform.position = tp2.transform.position;
            timer = 0;
            pasif = true;
            b2.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            if (b2.GetComponent<Rigidbody2D>().velocity == Vector2.zero)
            {
                b2.GetComponent<Rigidbody2D>().AddForce(new Vector2(x1, y1));
            }
        }
        if (ball2collider.IsTouching(blu2) && timer > 0.4f && !pasif)
        {
            b2.GetComponent<TrailRenderer>().enabled = false;
            b2.transform.position = tp1.transform.position;
            timer = 0;
            pasif = true;
            b2.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            if (b2.GetComponent<Rigidbody2D>().velocity == Vector2.zero)
            {
                b2.GetComponent<Rigidbody2D>().AddForce(new Vector2(x2, y2));
            }
        }
    }
}
