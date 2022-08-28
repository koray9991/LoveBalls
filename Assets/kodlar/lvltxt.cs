using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class lvltxt : MonoBehaviour
{
    float texttimer;
    public Text leveltext;
    float txt;
    private void Start()
    {
        leveltext.enabled = false;
        leveltext.color = new Color(0, 0, 0, 0);
        leveltext.text = ("LEVEL " + SceneManager.GetActiveScene().buildIndex);
    }
    private void FixedUpdate()
    {
        if (SceneManager.GetActiveScene().buildIndex != 0)
        {
            texttimer += Time.deltaTime;
            if (texttimer < 2)
            {
                leveltext.enabled = true;
                txt += 0.01f;
                leveltext.color = new Color(0, 0, 0, txt);
            }
            if (texttimer > 2 && texttimer < 4)
            {
                leveltext.enabled = true;
                txt -= 0.01f;
                leveltext.color = new Color(0, 0, 0, txt);
            }
            if (texttimer > 4)
            {
                leveltext.enabled = false;

            }
        }
    }
}
