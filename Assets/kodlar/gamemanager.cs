using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class gamemanager : MonoBehaviour
{
    public AudioClip[] ses;
    public GameObject restarticon;
    public GameObject ld1,ld2;
   public static int i=1;
    public GameObject buton1, buton2,buton3;
    public GameObject ball1, ball2;
    public GameObject ball1kalp, ball2kalp;
    public GameObject ball1s, ball1c, ball2s, ball2c;
    public Collider2D ball1collider, ball2collider;
    public Collider2D respawncollider;
    bool b1dustu, b2dustu;
    public static bool bitti;
    public Collider2D star1, star2, star3;
    public Image star1img, star2img, star3img;
    public Image star4img, star5img, star6img;
    public static int starsay;
    float bittitimer;
    public GameObject wp,winps;
    public GameObject wp0, wp1, wp2, wp3;
    public GameObject tanitim1,tanitim2,tanitim3,tanitim4;
    float birioldutimer;

    int level1yildiz;
    int level2yildiz;
    int level3yildiz;
    int level4yildiz;
    int level5yildiz;
    int level6yildiz;
    int level7yildiz;
    int level8yildiz;
    int level9yildiz;
    int level10yildiz;
    int level11yildiz;
    int level12yildiz;
    int level13yildiz;
    int level14yildiz;
    int level15yildiz;
    int level16yildiz;
    int level17yildiz;
    int level18yildiz;
    int level19yildiz;
    int level20yildiz;
    int level21yildiz;
    int level22yildiz;
    int level23yildiz;
    int level24yildiz;
    int level25yildiz;
    int level26yildiz;
    int level27yildiz;
    int level28yildiz;

    float birikitimer;

    void Start()
    {
        Time.timeScale = 1;
        buton1.GetComponent<Image>().color = Color.white;
        buton2.GetComponent<Image>().color = Color.gray;
        buton3.GetComponent<Image>().color = Color.gray;
        bitti = false;
        i = 1;
        starsay = 0;
        if (SceneManager.GetActiveScene().buildIndex > PlayerPrefs.GetInt("kacincilevel"))
        {
            PlayerPrefs.SetInt("kacincilevel", SceneManager.GetActiveScene().buildIndex);
        }
        
        if (SceneManager.GetActiveScene().buildIndex == 2 )
        {
            LinesDrawer2.oh = 0;

        }
        if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            tanitim3.SetActive(true);
            tanitim4.SetActive(false);

        }
        level1yildiz = PlayerPrefs.GetInt("level1yildiz");
        level2yildiz = PlayerPrefs.GetInt("level2yildiz");
        level3yildiz = PlayerPrefs.GetInt("level3yildiz");
        level4yildiz = PlayerPrefs.GetInt("level4yildiz"); 
        level5yildiz = PlayerPrefs.GetInt("level5yildiz");
        level6yildiz = PlayerPrefs.GetInt("level6yildiz");
        level7yildiz = PlayerPrefs.GetInt("level7yildiz"); 
        level8yildiz = PlayerPrefs.GetInt("level8yildiz");
        level9yildiz = PlayerPrefs.GetInt("level9yildiz");
        level10yildiz = PlayerPrefs.GetInt("level10yildiz");
        level11yildiz = PlayerPrefs.GetInt("level11yildiz");
        level12yildiz = PlayerPrefs.GetInt("level12yildiz");
        level13yildiz = PlayerPrefs.GetInt("level13yildiz");
        level14yildiz = PlayerPrefs.GetInt("level14yildiz");
        level15yildiz = PlayerPrefs.GetInt("level15yildiz");
        level16yildiz = PlayerPrefs.GetInt("level16yildiz");
        level17yildiz = PlayerPrefs.GetInt("level17yildiz");
        level18yildiz = PlayerPrefs.GetInt("level18yildiz");
        level19yildiz = PlayerPrefs.GetInt("level19yildiz");
        level20yildiz = PlayerPrefs.GetInt("level20yildiz");
        level21yildiz = PlayerPrefs.GetInt("level21yildiz");
        level22yildiz = PlayerPrefs.GetInt("level22yildiz");
        level23yildiz = PlayerPrefs.GetInt("level23yildiz");
        level24yildiz = PlayerPrefs.GetInt("level24yildiz");
        level25yildiz = PlayerPrefs.GetInt("level25yildiz");
        level26yildiz = PlayerPrefs.GetInt("level26yildiz");
        level27yildiz = PlayerPrefs.GetInt("level27yildiz");
        level28yildiz = PlayerPrefs.GetInt("level28yildiz");

    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 1 && LinesDrawer.time!=50)
        {
            birikitimer += Time.deltaTime;
            if (birikitimer > 10)
            {
                restarticon.SetActive(true);
            }

        }
        
        if (SceneManager.GetActiveScene().buildIndex == 2 && LinesDrawer2.oh ==1)
        {
            tanitim2.SetActive(false);

        }
        if(ball1c.active || ball2c.active)
        {
            birioldutimer += Time.deltaTime;
            if (birioldutimer > 2)
            {
                restarticon.SetActive(true);
            }
        }
        if (!ball1collider.enabled)
        {
            ball1s.SetActive(false);
            ball1c.SetActive(true);
            ball2s.SetActive(false);
            ball2c.SetActive(true);
            b1dustu = true;
        }
        if (!ball2collider.enabled)
        {
            ball1s.SetActive(false);
            ball1c.SetActive(true);
            ball2s.SetActive(false);
            ball2c.SetActive(true);
            b2dustu = true;
        }
        if (ball1collider.IsTouching(respawncollider))
        {
            if (!b1dustu)
            {
                GetComponent<AudioSource>().PlayOneShot(ses[1]);
            }
            ball1s.SetActive(false);
            ball1c.SetActive(true);
            ball2s.SetActive(false);
            ball2c.SetActive(true);
            b1dustu = true;
           
            
        }
        if (ball2collider.IsTouching(respawncollider))
        {
            ball1s.SetActive(false);
            ball1c.SetActive(true);
            ball2s.SetActive(false);
            ball2c.SetActive(true);
            if (!b2dustu)
            {
                GetComponent<AudioSource>().PlayOneShot(ses[1]);
            }
            b2dustu = true;
        }
        if (ball1collider.IsTouching(ball2collider))
        {
            ball1.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
            ball2.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
            ball1kalp.SetActive(true);
            ball2kalp.SetActive(true);
            if (!bitti)
            {
                GetComponent<AudioSource>().PlayOneShot(ses[2]);
            }
            bitti = true;
            birikitimer = 0;
            birioldutimer = 0;
            //SceneManager.LoadScene(Application.loadedLevel);
        }
        if (bitti)
        {
            bittitimer += Time.deltaTime;
            if (bittitimer > 2)
            {
                wp.SetActive(true);
                winps.SetActive(true);
                if (SceneManager.GetActiveScene().buildIndex == 1)
                {
                    if (starsay == 0)
                    {
                        wp0.SetActive(true);
                        if (level1yildiz == 0)
                        {
                            level1yildiz = 0;
                        }
                    }
                    if (starsay == 1)
                    {
                        wp1.SetActive(true);
                        if (level1yildiz < 1)
                        {
                            level1yildiz = 1;
                        }
                    }
                    if (starsay == 2)
                    {
                        wp2.SetActive(true);
                        if (level1yildiz < 2)
                        {
                            level1yildiz = 2;
                        }

                    }
                    if (starsay == 3)
                    {
                        wp3.SetActive(true);
                        level1yildiz = 3;
                    }
                    PlayerPrefs.SetInt("level1yildiz", level1yildiz);
                }
                if (SceneManager.GetActiveScene().buildIndex == 2)
                {
                    if (starsay == 0)
                    {
                        wp0.SetActive(true);
                        if (level2yildiz == 0)
                        {
                            level2yildiz = 0;
                        }
                    }
                    if (starsay == 1)
                    {
                        wp1.SetActive(true);
                        if (level2yildiz < 1)
                        {
                            level2yildiz = 1;
                        }
                    }
                    if (starsay == 2)
                    {
                        wp2.SetActive(true);
                        if (level2yildiz < 2)
                        {
                            level2yildiz = 2;
                        }

                    }
                    if (starsay == 3)
                    {
                        wp3.SetActive(true);
                        level2yildiz = 3;
                    }
                    PlayerPrefs.SetInt("level2yildiz", level2yildiz);
                }
                if (SceneManager.GetActiveScene().buildIndex == 3)
                {
                    if (starsay == 0)
                    {
                        wp0.SetActive(true);
                        if (level3yildiz == 0)
                        {
                            level3yildiz = 0;
                        }
                    }
                    if (starsay == 1)
                    {
                        wp1.SetActive(true);
                        if (level3yildiz < 1)
                        {
                            level3yildiz = 1;
                        }
                    }
                    if (starsay == 2)
                    {
                        wp2.SetActive(true);
                        if (level3yildiz < 2)
                        {
                            level3yildiz = 2;
                        }

                    }
                    if (starsay == 3)
                    {
                        wp3.SetActive(true);
                        level3yildiz = 3;
                    }
                    PlayerPrefs.SetInt("level3yildiz", level3yildiz);
                }
                if (SceneManager.GetActiveScene().buildIndex == 4)
                {
                    if (starsay == 0)
                    {
                        wp0.SetActive(true);
                        if (level4yildiz == 0)
                        {
                            level4yildiz = 0;
                        }
                    }
                    if (starsay == 1)
                    {
                        wp1.SetActive(true);
                        if (level4yildiz < 1)
                        {
                            level4yildiz = 1;
                        }
                    }
                    if (starsay == 2)
                    {
                        wp2.SetActive(true);
                        if (level4yildiz < 2)
                        {
                            level4yildiz = 2;
                        }

                    }
                    if (starsay == 3)
                    {
                        wp3.SetActive(true);
                        level4yildiz = 3;
                    }
                    PlayerPrefs.SetInt("level4yildiz", level4yildiz);
                }
                if (SceneManager.GetActiveScene().buildIndex == 5)
                {
                    if (starsay == 0)
                    {
                        wp0.SetActive(true);
                        if (level5yildiz == 0)
                        {
                            level5yildiz = 0;
                        }
                    }
                    if (starsay == 1)
                    {
                        wp1.SetActive(true);
                        if (level5yildiz < 1)
                        {
                            level5yildiz = 1;
                        }
                    }
                    if (starsay == 2)
                    {
                        wp2.SetActive(true);
                        if (level5yildiz < 2)
                        {
                            level5yildiz = 2;
                        }

                    }
                    if (starsay == 3)
                    {
                        wp3.SetActive(true);
                        level5yildiz = 3;
                    }
                    PlayerPrefs.SetInt("level5yildiz", level5yildiz);
                }
                if (SceneManager.GetActiveScene().buildIndex == 6)
                {
                    if (starsay == 0)
                    {
                        wp0.SetActive(true);
                        if (level6yildiz == 0)
                        {
                            level6yildiz = 0;
                        }
                    }
                    if (starsay == 1)
                    {
                        wp1.SetActive(true);
                        if (level6yildiz < 1)
                        {
                            level6yildiz = 1;
                        }
                    }
                    if (starsay == 2)
                    {
                        wp2.SetActive(true);
                        if (level6yildiz < 2)
                        {
                            level6yildiz = 2;
                        }

                    }
                    if (starsay == 3)
                    {
                        wp3.SetActive(true);
                        level6yildiz = 3;
                    }
                    PlayerPrefs.SetInt("level6yildiz", level6yildiz);
                }
                if (SceneManager.GetActiveScene().buildIndex == 7)
                {
                    if (starsay == 0)
                    {
                        wp0.SetActive(true);
                        if (level7yildiz == 0)
                        {
                            level7yildiz = 0;
                        }
                    }
                    if (starsay == 1)
                    {
                        wp1.SetActive(true);
                        if (level7yildiz < 1)
                        {
                            level7yildiz = 1;
                        }
                    }
                    if (starsay == 2)
                    {
                        wp2.SetActive(true);
                        if (level7yildiz < 2)
                        {
                            level7yildiz = 2;
                        }

                    }
                    if (starsay == 3)
                    {
                        wp3.SetActive(true);
                        level7yildiz = 3;
                    }
                    PlayerPrefs.SetInt("level7yildiz", level7yildiz);
                }
                if (SceneManager.GetActiveScene().buildIndex == 8)
                {
                    if (starsay == 0)
                    {
                        wp0.SetActive(true);
                        if (level8yildiz == 0)
                        {
                            level8yildiz = 0;
                        }
                    }
                    if (starsay == 1)
                    {
                        wp1.SetActive(true);
                        if (level8yildiz < 1)
                        {
                            level8yildiz = 1;
                        }
                    }
                    if (starsay == 2)
                    {
                        wp2.SetActive(true);
                        if (level8yildiz < 2)
                        {
                            level8yildiz = 2;
                        }

                    }
                    if (starsay == 3)
                    {
                        wp3.SetActive(true);
                        level8yildiz = 3;
                    }
                    PlayerPrefs.SetInt("level8yildiz", level8yildiz);
                }
                if (SceneManager.GetActiveScene().buildIndex == 9)
                {
                    if (starsay == 0)
                    {
                        wp0.SetActive(true);
                        if (level9yildiz == 0)
                        {
                            level9yildiz = 0;
                        }
                    }
                    if (starsay == 1)
                    {
                        wp1.SetActive(true);
                        if (level9yildiz < 1)
                        {
                            level9yildiz = 1;
                        }
                    }
                    if (starsay == 2)
                    {
                        wp2.SetActive(true);
                        if (level9yildiz < 2)
                        {
                            level9yildiz = 2;
                        }

                    }
                    if (starsay == 3)
                    {
                        wp3.SetActive(true);
                        level9yildiz = 3;
                    }
                    PlayerPrefs.SetInt("level9yildiz", level9yildiz);
                }
                if (SceneManager.GetActiveScene().buildIndex == 10)
                {
                    if (starsay == 0)
                    {
                        wp0.SetActive(true);
                        if (level10yildiz == 0)
                        {
                            level10yildiz = 0;
                        }
                    }
                    if (starsay == 1)
                    {
                        wp1.SetActive(true);
                        if (level10yildiz < 1)
                        {
                            level10yildiz = 1;
                        }
                    }
                    if (starsay == 2)
                    {
                        wp2.SetActive(true);
                        if (level10yildiz < 2)
                        {
                            level10yildiz = 2;
                        }

                    }
                    if (starsay == 3)
                    {
                        wp3.SetActive(true);
                        level10yildiz = 3;
                    }
                    PlayerPrefs.SetInt("level10yildiz", level10yildiz);
                }
                if (SceneManager.GetActiveScene().buildIndex == 11)
                {
                    if (starsay == 0)
                    {
                        wp0.SetActive(true);
                        if (level11yildiz == 0)
                        {
                            level11yildiz = 0;
                        }
                    }
                    if (starsay == 1)
                    {
                        wp1.SetActive(true);
                        if (level11yildiz < 1)
                        {
                            level11yildiz = 1;
                        }
                    }
                    if (starsay == 2)
                    {
                        wp2.SetActive(true);
                        if (level11yildiz < 2)
                        {
                            level11yildiz = 2;
                        }

                    }
                    if (starsay == 3)
                    {
                        wp3.SetActive(true);
                        level11yildiz = 3;
                    }
                    PlayerPrefs.SetInt("level11yildiz", level11yildiz);
                }
                if (SceneManager.GetActiveScene().buildIndex == 12)
                {
                    if (starsay == 0)
                    {
                        wp0.SetActive(true);
                        if (level12yildiz == 0)
                        {
                            level12yildiz = 0;
                        }
                    }
                    if (starsay == 1)
                    {
                        wp1.SetActive(true);
                        if (level12yildiz < 1)
                        {
                            level12yildiz = 1;
                        }
                    }
                    if (starsay == 2)
                    {
                        wp2.SetActive(true);
                        if (level12yildiz < 2)
                        {
                            level12yildiz = 2;
                        }

                    }
                    if (starsay == 3)
                    {
                        wp3.SetActive(true);
                        level12yildiz = 3;
                    }
                    PlayerPrefs.SetInt("level12yildiz", level12yildiz);
                }
                if (SceneManager.GetActiveScene().buildIndex == 13)
                {
                    if (starsay == 0)
                    {
                        wp0.SetActive(true);
                        if (level13yildiz == 0)
                        {
                            level13yildiz = 0;
                        }
                    }
                    if (starsay == 1)
                    {
                        wp1.SetActive(true);
                        if (level13yildiz < 1)
                        {
                            level13yildiz = 1;
                        }
                    }
                    if (starsay == 2)
                    {
                        wp2.SetActive(true);
                        if (level13yildiz < 2)
                        {
                            level13yildiz = 2;
                        }

                    }
                    if (starsay == 3)
                    {
                        wp3.SetActive(true);
                        level13yildiz = 3;
                    }
                    PlayerPrefs.SetInt("level13yildiz", level13yildiz);
                }
                if (SceneManager.GetActiveScene().buildIndex == 14)
                {
                    if (starsay == 0)
                    {
                        wp0.SetActive(true);
                        if (level14yildiz == 0)
                        {
                            level14yildiz = 0;
                        }
                    }
                    if (starsay == 1)
                    {
                        wp1.SetActive(true);
                        if (level14yildiz < 1)
                        {
                            level14yildiz = 1;
                        }
                    }
                    if (starsay == 2)
                    {
                        wp2.SetActive(true);
                        if (level14yildiz < 2)
                        {
                            level14yildiz = 2;
                        }

                    }
                    if (starsay == 3)
                    {
                        wp3.SetActive(true);
                        level14yildiz = 3;
                    }
                    PlayerPrefs.SetInt("level14yildiz", level14yildiz);
                }
                if (SceneManager.GetActiveScene().buildIndex == 15)
                {
                    if (starsay == 0)
                    {
                        wp0.SetActive(true);
                        if (level15yildiz == 0)
                        {
                            level15yildiz = 0;
                        }
                    }
                    if (starsay == 1)
                    {
                        wp1.SetActive(true);
                        if (level15yildiz < 1)
                        {
                            level15yildiz = 1;
                        }
                    }
                    if (starsay == 2)
                    {
                        wp2.SetActive(true);
                        if (level15yildiz < 2)
                        {
                            level15yildiz = 2;
                        }

                    }
                    if (starsay == 3)
                    {
                        wp3.SetActive(true);
                        level15yildiz = 3;
                    }
                    PlayerPrefs.SetInt("level15yildiz", level15yildiz);
                }
                if (SceneManager.GetActiveScene().buildIndex == 16)
                {
                    if (starsay == 0)
                    {
                        wp0.SetActive(true);
                        if (level16yildiz == 0)
                        {
                            level16yildiz = 0;
                        }
                    }
                    if (starsay == 1)
                    {
                        wp1.SetActive(true);
                        if (level16yildiz < 1)
                        {
                            level16yildiz = 1;
                        }
                    }
                    if (starsay == 2)
                    {
                        wp2.SetActive(true);
                        if (level16yildiz < 2)
                        {
                            level16yildiz = 2;
                        }

                    }
                    if (starsay == 3)
                    {
                        wp3.SetActive(true);
                        level16yildiz = 3;
                    }
                    PlayerPrefs.SetInt("level16yildiz", level16yildiz);
                }
                if (SceneManager.GetActiveScene().buildIndex == 17)
                {
                    if (starsay == 0)
                    {
                        wp0.SetActive(true);
                        if (level17yildiz == 0)
                        {
                            level17yildiz = 0;
                        }
                    }
                    if (starsay == 1)
                    {
                        wp1.SetActive(true);
                        if (level17yildiz < 1)
                        {
                            level17yildiz = 1;
                        }
                    }
                    if (starsay == 2)
                    {
                        wp2.SetActive(true);
                        if (level17yildiz < 2)
                        {
                            level17yildiz = 2;
                        }

                    }
                    if (starsay == 3)
                    {
                        wp3.SetActive(true);
                        level17yildiz = 3;
                    }
                    PlayerPrefs.SetInt("level17yildiz", level17yildiz);
                }
                if (SceneManager.GetActiveScene().buildIndex == 18)
                {
                    if (starsay == 0)
                    {
                        wp0.SetActive(true);
                        if (level18yildiz == 0)
                        {
                            level18yildiz = 0;
                        }
                    }
                    if (starsay == 1)
                    {
                        wp1.SetActive(true);
                        if (level18yildiz < 1)
                        {
                            level18yildiz = 1;
                        }
                    }
                    if (starsay == 2)
                    {
                        wp2.SetActive(true);
                        if (level18yildiz < 2)
                        {
                            level18yildiz = 2;
                        }

                    }
                    if (starsay == 3)
                    {
                        wp3.SetActive(true);
                        level18yildiz = 3;
                    }
                    PlayerPrefs.SetInt("level18yildiz", level18yildiz);
                }
                if (SceneManager.GetActiveScene().buildIndex == 19)
                {
                    if (starsay == 0)
                    {
                        wp0.SetActive(true);
                        if (level19yildiz == 0)
                        {
                            level19yildiz = 0;
                        }
                    }
                    if (starsay == 1)
                    {
                        wp1.SetActive(true);
                        if (level19yildiz < 1)
                        {
                            level19yildiz = 1;
                        }
                    }
                    if (starsay == 2)
                    {
                        wp2.SetActive(true);
                        if (level19yildiz < 2)
                        {
                            level19yildiz = 2;
                        }

                    }
                    if (starsay == 3)
                    {
                        wp3.SetActive(true);
                        level19yildiz = 3;
                    }
                    PlayerPrefs.SetInt("level19yildiz", level19yildiz);
                }
                if (SceneManager.GetActiveScene().buildIndex == 20)
                {
                    if (starsay == 0)
                    {
                        wp0.SetActive(true);
                        if (level20yildiz == 0)
                        {
                            level20yildiz = 0;
                        }
                    }
                    if (starsay == 1)
                    {
                        wp1.SetActive(true);
                        if (level20yildiz < 1)
                        {
                            level20yildiz = 1;
                        }
                    }
                    if (starsay == 2)
                    {
                        wp2.SetActive(true);
                        if (level20yildiz < 2)
                        {
                            level20yildiz = 2;
                        }

                    }
                    if (starsay == 3)
                    {
                        wp3.SetActive(true);
                        level20yildiz = 3;
                    }
                    PlayerPrefs.SetInt("level20yildiz", level20yildiz);
                }
                if (SceneManager.GetActiveScene().buildIndex == 21)
                {
                    if (starsay == 0)
                    {
                        wp0.SetActive(true);
                        if (level21yildiz == 0)
                        {
                            level21yildiz = 0;
                        }
                    }
                    if (starsay == 1)
                    {
                        wp1.SetActive(true);
                        if (level21yildiz < 1)
                        {
                            level21yildiz = 1;
                        }
                    }
                    if (starsay == 2)
                    {
                        wp2.SetActive(true);
                        if (level21yildiz < 2)
                        {
                            level21yildiz = 2;
                        }

                    }
                    if (starsay == 3)
                    {
                        wp3.SetActive(true);
                        level21yildiz = 3;
                    }
                    PlayerPrefs.SetInt("level21yildiz", level21yildiz);
                }
                if (SceneManager.GetActiveScene().buildIndex == 22)
                {
                    if (starsay == 0)
                    {
                        wp0.SetActive(true);
                        if (level22yildiz == 0)
                        {
                            level22yildiz = 0;
                        }
                    }
                    if (starsay == 1)
                    {
                        wp1.SetActive(true);
                        if (level22yildiz < 1)
                        {
                            level22yildiz = 1;
                        }
                    }
                    if (starsay == 2)
                    {
                        wp2.SetActive(true);
                        if (level22yildiz < 2)
                        {
                            level22yildiz = 2;
                        }

                    }
                    if (starsay == 3)
                    {
                        wp3.SetActive(true);
                        level22yildiz = 3;
                    }
                    PlayerPrefs.SetInt("level22yildiz", level22yildiz);
                }
                if (SceneManager.GetActiveScene().buildIndex == 23)
                {
                    if (starsay == 0)
                    {
                        wp0.SetActive(true);
                        if (level23yildiz == 0)
                        {
                            level23yildiz = 0;
                        }
                    }
                    if (starsay == 1)
                    {
                        wp1.SetActive(true);
                        if (level23yildiz < 1)
                        {
                            level23yildiz = 1;
                        }
                    }
                    if (starsay == 2)
                    {
                        wp2.SetActive(true);
                        if (level23yildiz < 2)
                        {
                            level23yildiz = 2;
                        }

                    }
                    if (starsay == 3)
                    {
                        wp3.SetActive(true);
                        level23yildiz = 3;
                    }
                    PlayerPrefs.SetInt("level23yildiz", level23yildiz);
                }
                if (SceneManager.GetActiveScene().buildIndex == 24)
                {
                    if (starsay == 0)
                    {
                        wp0.SetActive(true);
                        if (level24yildiz == 0)
                        {
                            level24yildiz = 0;
                        }
                    }
                    if (starsay == 1)
                    {
                        wp1.SetActive(true);
                        if (level24yildiz < 1)
                        {
                            level24yildiz = 1;
                        }
                    }
                    if (starsay == 2)
                    {
                        wp2.SetActive(true);
                        if (level24yildiz < 2)
                        {
                            level24yildiz = 2;
                        }

                    }
                    if (starsay == 3)
                    {
                        wp3.SetActive(true);
                        level24yildiz = 3;
                    }
                    PlayerPrefs.SetInt("level24yildiz", level24yildiz);
                }
                if (SceneManager.GetActiveScene().buildIndex == 25)
                {
                    if (starsay == 0)
                    {
                        wp0.SetActive(true);
                        if (level25yildiz == 0)
                        {
                            level25yildiz = 0;
                        }
                    }
                    if (starsay == 1)
                    {
                        wp1.SetActive(true);
                        if (level25yildiz < 1)
                        {
                            level25yildiz = 1;
                        }
                    }
                    if (starsay == 2)
                    {
                        wp2.SetActive(true);
                        if (level25yildiz < 2)
                        {
                            level25yildiz = 2;
                        }

                    }
                    if (starsay == 3)
                    {
                        wp3.SetActive(true);
                        level25yildiz = 3;
                    }
                    PlayerPrefs.SetInt("level25yildiz", level25yildiz);
                }
                if (SceneManager.GetActiveScene().buildIndex == 26)
                {
                    if (starsay == 0)
                    {
                        wp0.SetActive(true);
                        if (level26yildiz == 0)
                        {
                            level26yildiz = 0;
                        }
                    }
                    if (starsay == 1)
                    {
                        wp1.SetActive(true);
                        if (level26yildiz < 1)
                        {
                            level26yildiz = 1;
                        }
                    }
                    if (starsay == 2)
                    {
                        wp2.SetActive(true);
                        if (level26yildiz < 2)
                        {
                            level26yildiz = 2;
                        }

                    }
                    if (starsay == 3)
                    {
                        wp3.SetActive(true);
                        level26yildiz = 3;
                    }
                    PlayerPrefs.SetInt("level26yildiz", level26yildiz);
                }
                if (SceneManager.GetActiveScene().buildIndex == 27)
                {
                    if (starsay == 0)
                    {
                        wp0.SetActive(true);
                        if (level27yildiz == 0)
                        {
                            level27yildiz = 0;
                        }
                    }
                    if (starsay == 1)
                    {
                        wp1.SetActive(true);
                        if (level27yildiz < 1)
                        {
                            level27yildiz = 1;
                        }
                    }
                    if (starsay == 2)
                    {
                        wp2.SetActive(true);
                        if (level27yildiz < 2)
                        {
                            level27yildiz = 2;
                        }

                    }
                    if (starsay == 3)
                    {
                        wp3.SetActive(true);
                        level27yildiz = 3;
                    }
                    PlayerPrefs.SetInt("level27yildiz", level27yildiz);
                }
                if (SceneManager.GetActiveScene().buildIndex == 28)
                {
                    if (starsay == 0)
                    {
                        wp0.SetActive(true);
                        if (level28yildiz == 0)
                        {
                            level28yildiz = 0;
                        }
                    }
                    if (starsay == 1)
                    {
                        wp1.SetActive(true);
                        if (level28yildiz < 1)
                        {
                            level28yildiz = 1;
                        }
                    }
                    if (starsay == 2)
                    {
                        wp2.SetActive(true);
                        if (level28yildiz < 2)
                        {
                            level28yildiz = 2;
                        }

                    }
                    if (starsay == 3)
                    {
                        wp3.SetActive(true);
                        level28yildiz = 3;
                    }
                    PlayerPrefs.SetInt("level28yildiz", level28yildiz);
                }


                if (SceneManager.GetActiveScene().buildIndex == PlayerPrefs.GetInt("kacincilevel"))
                {
                    PlayerPrefs.SetInt("kacincilevel", SceneManager.GetActiveScene().buildIndex + 1);
                }
            }
        }
        if (starsay == 0)
        {
            star1img.color = Color.white;
            star2img.color = Color.white;
            star3img.color = Color.white;
        }
        if (starsay == 1)
        {
            star4img.enabled = true;
        }
        if (starsay == 2)
        {
            star5img.enabled = true;
        }
        if (starsay == 3)
        {
            star6img.enabled = true;
        }
     

        if (b1dustu && b2dustu)
        {
            restarticon.SetActive(true);
        }
    }
    public void butonsec(int butonno)
    {
        GetComponent<AudioSource>().PlayOneShot(ses[0]);
        if (butonno == 1)
        {
            ld1.GetComponent<LinesDrawer>().enabled = true;
            ld2.GetComponent<LinesDrawer2>().enabled = false;
            i = 1;
            buton1.GetComponent<Image>().color = Color.white;
            buton2.GetComponent<Image>().color = Color.gray;
            buton3.GetComponent<Image>().color = Color.gray;
        }
        if (butonno == 2)
        {
            if (SceneManager.GetActiveScene().buildIndex == 2)
            {
                tanitim1.SetActive(false);
                tanitim2.SetActive(true);

            }
            ld1.GetComponent<LinesDrawer>().enabled = false;
            ld2.GetComponent<LinesDrawer2>().enabled = true;
            ld2.GetComponent<AudioSource>().enabled = true;
            i = 2;
            buton1.GetComponent<Image>().color = Color.gray;
            buton2.GetComponent<Image>().color = Color.white;
            buton3.GetComponent<Image>().color = Color.gray;
        }
        if (butonno == 4)
        {
            ld1.GetComponent<LinesDrawer>().enabled = false;
            ld2.GetComponent<LinesDrawer2>().enabled = false;
            i = 3;
            buton1.GetComponent<Image>().color = Color.gray;
            buton2.GetComponent<Image>().color = Color.gray;
            buton3.GetComponent<Image>().color = Color.white;
            if (SceneManager.GetActiveScene().buildIndex == 3)
            {
                tanitim3.SetActive(false);
                tanitim4.SetActive(true);

            }
        }
        if (butonno == 3)
        {
            SceneManager.LoadScene(Application.loadedLevel);
        }
        if (butonno == 5)
        {
            SceneManager.LoadScene(0);
        }
        if (butonno == 6)
        {
            if (SceneManager.GetActiveScene().buildIndex == 10 || SceneManager.GetActiveScene().buildIndex == 20)
            {
                SceneManager.LoadScene(0);
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
                
        }
    }
}
