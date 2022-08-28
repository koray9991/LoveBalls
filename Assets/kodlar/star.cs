using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class star : MonoBehaviour
{
    public AudioClip[] ses;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Player")
        {
            GetComponent<AudioSource>().PlayOneShot(ses[0]);
            gamemanager.starsay++;
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<CircleCollider2D>().enabled = false;
            transform.GetChild(0).gameObject.SetActive(true);
        }
    }
}
