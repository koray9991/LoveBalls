using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball1 : MonoBehaviour
{
    public GameObject face;
    public GameObject ps2;
    public AudioClip[] ses;
    // public GameObject loop1;

    /* private void Update()
     {
         loop1.transform.position = new Vector2(transform.position.x, transform.position.y + 0.45f);
     }*/

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Respawn")
        {
            GetComponent<AudioSource>().PlayOneShot(ses[0]);
            GetComponent<CircleCollider2D>().enabled = false;
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<TrailRenderer>().enabled = false;
          //  loop1.SetActive(false);
            face.SetActive(false);
            ps2.transform.position = transform.position;
            ps2.SetActive(true);
        }
    }
}
