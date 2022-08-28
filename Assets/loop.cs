using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loop : MonoBehaviour
{
    public Sprite[] animasyonKareleri;
    SpriteRenderer spriteRenderer;
    float zaman = 0;
    int animKarelerSayaci = 0;
    public float time;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }


    void Update()
    {
        zaman += Time.deltaTime;
        if (zaman > time)
        {
            spriteRenderer.sprite = animasyonKareleri[animKarelerSayaci++];
            if (animasyonKareleri.Length == animKarelerSayaci)
            {
                animKarelerSayaci = 0;
            }
            zaman = 0;
        }

    }
}
