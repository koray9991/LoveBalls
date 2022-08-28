using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class line3 : MonoBehaviour
{

    public AudioClip[] ses;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "rope")
        {

            GetComponent<AudioSource>().PlayOneShot(ses[0]);
            Destroy(collision.gameObject);
        }
    }
   
}
