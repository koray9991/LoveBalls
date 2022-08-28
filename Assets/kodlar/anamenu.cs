using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class anamenu : MonoBehaviour
{
    public GameObject baslangic,swipe,geri,totalyildizimg,no1,no2,no3,no2lock,no3lock,no4lock,no5lock;
    public AudioClip[] ses;

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


    int world1totalyildiz,world2totalyildiz,world3totalyildiz;
    int totalyildiz;
    public Text world1totalyildiztext, world2totalyildiztext,world3totalyildiztext;
    public Text totalyildiztext;
    public GameObject level1_0, level1_1, level1_2, level1_3;
    public GameObject level2_0, level2_1, level2_2, level2_3;
    public GameObject level3_0, level3_1, level3_2, level3_3;
    public GameObject level4_0, level4_1, level4_2, level4_3;
    public GameObject level5_0, level5_1, level5_2, level5_3;
    public GameObject level6_0, level6_1, level6_2, level6_3;
    public GameObject level7_0, level7_1, level7_2, level7_3;
    public GameObject level8_0, level8_1, level8_2, level8_3;
    public GameObject level9_0, level9_1, level9_2, level9_3;
    public GameObject level10_0, level10_1, level10_2, level10_3;
    public GameObject level11_0, level11_1, level11_2, level11_3;
   
    public GameObject level12_0, level12_1, level12_2, level12_3;
    public GameObject level13_0, level13_1, level13_2, level13_3;
    public GameObject level14_0, level14_1, level14_2, level14_3;
    public GameObject level15_0, level15_1, level15_2, level15_3;
    public GameObject level16_0, level16_1, level16_2, level16_3;
    public GameObject level17_0, level17_1, level17_2, level17_3;
    public GameObject level18_0, level18_1, level18_2, level18_3;
    public GameObject level19_0, level19_1, level19_2, level19_3;
    public GameObject level20_0, level20_1, level20_2, level20_3;
    public GameObject level21_0, level21_1, level21_2, level21_3;

    public GameObject level22_0, level22_1, level22_2, level22_3;
    public GameObject level23_0, level23_1, level23_2, level23_3;
    public GameObject level24_0, level24_1, level24_2, level24_3;
    public GameObject level25_0, level25_1, level25_2, level25_3;
    public GameObject level26_0, level26_1, level26_2, level26_3;
    public GameObject level27_0, level27_1, level27_2, level27_3;
    public GameObject level28_0, level28_1, level28_2, level28_3;

    void Start()
    {
        if (PlayerPrefs.GetInt("kacincilevel") == 0)
        {
            PlayerPrefs.SetInt("kacincilevel", 1);
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



        ///////////
        if (level1yildiz == 0)
        {
            level1_0.SetActive(true);
        }
        if (level1yildiz == 1)
        {
            level1_1.SetActive(true);
        }
        if (level1yildiz == 2)
        {
            level1_2.SetActive(true);
        }
        if (level1yildiz == 3)
        {
            level1_3.SetActive(true);
        }
        //////////
        if (level2yildiz == 0)
        {
            level2_0.SetActive(true);
        }
        if (level2yildiz == 1)
        {
            level2_1.SetActive(true);
        }
        if (level2yildiz == 2)
        {
            level2_2.SetActive(true);
        }
        if (level2yildiz == 3)
        {
            level2_3.SetActive(true);
        }
        //////////
        if (level3yildiz == 0)
        {
            level3_0.SetActive(true);
        }
        if (level3yildiz == 1)
        {
            level3_1.SetActive(true);
        }
        if (level3yildiz == 2)
        {
            level3_2.SetActive(true);
        }
        if (level3yildiz == 3)
        {
            level3_3.SetActive(true);
        }
        //////////
        if (level4yildiz == 0)
        {
            level4_0.SetActive(true);
        }
        if (level4yildiz == 1)
        {
            level4_1.SetActive(true);
        }
        if (level4yildiz == 2)
        {
            level4_2.SetActive(true);
        }
        if (level4yildiz == 3)
        {
            level4_3.SetActive(true);
        }
        //////////
        if (level5yildiz == 0)
        {
            level5_0.SetActive(true);
        }
        if (level5yildiz == 1)
        {
            level5_1.SetActive(true);
        }
        if (level5yildiz == 2)
        {
            level5_2.SetActive(true);
        }
        if (level5yildiz == 3)
        {
            level5_3.SetActive(true);
        }
        //////////
        if (level6yildiz == 0)
        {
            level6_0.SetActive(true);
        }
        if (level6yildiz == 1)
        {
            level6_1.SetActive(true);
        }
        if (level6yildiz == 2)
        {
            level6_2.SetActive(true);
        }
        if (level6yildiz == 3)
        {
            level6_3.SetActive(true);
        }
        //////////
        if (level7yildiz == 0)
        {
            level7_0.SetActive(true);
        }
        if (level7yildiz == 1)
        {
            level7_1.SetActive(true);
        }
        if (level7yildiz == 2)
        {
            level7_2.SetActive(true);
        }
        if (level7yildiz == 3)
        {
            level7_3.SetActive(true);
        }
        //////////
        if (level8yildiz == 0)
        {
            level8_0.SetActive(true);
        }
        if (level8yildiz == 1)
        {
            level8_1.SetActive(true);
        }
        if (level8yildiz == 2)
        {
            level8_2.SetActive(true);
        }
        if (level8yildiz == 3)
        {
            level8_3.SetActive(true);
        }
        //////////
        if (level9yildiz == 0)
        {
            level9_0.SetActive(true);
        }
        if (level9yildiz == 1)
        {
            level9_1.SetActive(true);
        }
        if (level9yildiz == 2)
        {
            level9_2.SetActive(true);
        }
        if (level9yildiz == 3)
        {
            level9_3.SetActive(true);
        }
        //////////
        if (level10yildiz == 0)
        {
            level10_0.SetActive(true);
        }
        if (level10yildiz == 1)
        {
            level10_1.SetActive(true);
        }
        if (level10yildiz == 2)
        {
            level10_2.SetActive(true);
        }
        if (level10yildiz == 3)
        {
            level10_3.SetActive(true);
        }
        //////////
        if (level11yildiz == 0)
        {
            level11_0.SetActive(true);
        }
        if (level11yildiz == 1)
        {
            level11_1.SetActive(true);
        }
        if (level11yildiz == 2)
        {
            level11_2.SetActive(true);
        }
        if (level11yildiz == 3)
        {
            level11_3.SetActive(true);
        }
        //////////
        if (level12yildiz == 0)
        {
            level12_0.SetActive(true);
        }
        if (level12yildiz == 1)
        {
            level12_1.SetActive(true);
        }
        if (level12yildiz == 2)
        {
            level12_2.SetActive(true);
        }
        if (level12yildiz == 3)
        {
            level12_3.SetActive(true);
        }
        //////////
        if (level13yildiz == 0)
        {
            level13_0.SetActive(true);
        }
        if (level13yildiz == 1)
        {
            level13_1.SetActive(true);
        }
        if (level13yildiz == 2)
        {
            level13_2.SetActive(true);
        }
        if (level13yildiz == 3)
        {
            level13_3.SetActive(true);
        }
        //////////
        if (level14yildiz == 0)
        {
            level14_0.SetActive(true);
        }
        if (level14yildiz == 1)
        {
            level14_1.SetActive(true);
        }
        if (level14yildiz == 2)
        {
            level14_2.SetActive(true);
        }
        if (level14yildiz == 3)
        {
            level14_3.SetActive(true);
        }
        //////////
        if (level15yildiz == 0)
        {
            level15_0.SetActive(true);
        }
        if (level15yildiz == 1)
        {
            level15_1.SetActive(true);
        }
        if (level15yildiz == 2)
        {
            level15_2.SetActive(true);
        }
        if (level15yildiz == 3)
        {
            level15_3.SetActive(true);
        }
        //////////
        if (level16yildiz == 0)
        {
            level16_0.SetActive(true);
        }
        if (level16yildiz == 1)
        {
            level16_1.SetActive(true);
        }
        if (level16yildiz == 2)
        {
            level16_2.SetActive(true);
        }
        if (level16yildiz == 3)
        {
            level16_3.SetActive(true);
        }
        //////////
        if (level17yildiz == 0)
        {
            level17_0.SetActive(true);
        }
        if (level17yildiz == 1)
        {
            level17_1.SetActive(true);
        }
        if (level17yildiz == 2)
        {
            level17_2.SetActive(true);
        }
        if (level17yildiz == 3)
        {
            level17_3.SetActive(true);
        }
        //////////
        if (level18yildiz == 0)
        {
            level18_0.SetActive(true);
        }
        if (level18yildiz == 1)
        {
            level18_1.SetActive(true);
        }
        if (level18yildiz == 2)
        {
            level18_2.SetActive(true);
        }
        if (level18yildiz == 3)
        {
            level18_3.SetActive(true);
        }
        //////////
        if (level19yildiz == 0)
        {
            level19_0.SetActive(true);
        }
        if (level19yildiz == 1)
        {
            level19_1.SetActive(true);
        }
        if (level19yildiz == 2)
        {
            level19_2.SetActive(true);
        }
        if (level19yildiz == 3)
        {
            level19_3.SetActive(true);
        }
        //////////
        if (level20yildiz == 0)
        {
            level20_0.SetActive(true);
        }
        if (level20yildiz == 1)
        {
            level20_1.SetActive(true);
        }
        if (level20yildiz == 2)
        {
            level20_2.SetActive(true);
        }
        if (level20yildiz == 3)
        {
            level20_3.SetActive(true);
        }
        //////////
        if (level21yildiz == 0)
        {
            level21_0.SetActive(true);
        }
        if (level21yildiz == 1)
        {
            level21_1.SetActive(true);
        }
        if (level21yildiz == 2)
        {
            level21_2.SetActive(true);
        }
        if (level21yildiz == 3)
        {
            level21_3.SetActive(true);
        }
        //////////
        if (level22yildiz == 0)
        {
            level22_0.SetActive(true);
        }
        if (level22yildiz == 1)
        {
            level22_1.SetActive(true);
        }
        if (level22yildiz == 2)
        {
            level22_2.SetActive(true);
        }
        if (level22yildiz == 3)
        {
            level22_3.SetActive(true);
        } //////////
        if (level23yildiz == 0)
        {
            level23_0.SetActive(true);
        }
        if (level23yildiz == 1)
        {
            level23_1.SetActive(true);
        }
        if (level23yildiz == 2)
        {
            level23_2.SetActive(true);
        }
        if (level23yildiz == 3)
        {
            level23_3.SetActive(true);
        }
        //////////
        if (level24yildiz == 0)
        {
            level24_0.SetActive(true);
        }
        if (level24yildiz == 1)
        {
            level24_1.SetActive(true);
        }
        if (level21yildiz == 2)
        {
            level24_2.SetActive(true);
        }
        if (level24yildiz == 3)
        {
            level24_3.SetActive(true);
        }
        //////////
        if (level25yildiz == 0)
        {
            level25_0.SetActive(true);
        }
        if (level25yildiz == 1)
        {
            level25_1.SetActive(true);
        }
        if (level25yildiz == 2)
        {
            level25_2.SetActive(true);
        }
        if (level25yildiz == 3)
        {
            level25_3.SetActive(true);
        }
        //////////
        if (level26yildiz == 0)
        {
            level26_0.SetActive(true);
        }
        if (level26yildiz == 1)
        {
            level26_1.SetActive(true);
        }
        if (level26yildiz == 2)
        {
            level26_2.SetActive(true);
        }
        if (level26yildiz == 3)
        {
            level26_3.SetActive(true);
        } //////////
        if (level27yildiz == 0)
        {
            level27_0.SetActive(true);
        }
        if (level27yildiz == 1)
        {
            level27_1.SetActive(true);
        }
        if (level27yildiz == 2)
        {
            level27_2.SetActive(true);
        }
        if (level27yildiz == 3)
        {
            level27_3.SetActive(true);
        } //////////
        if (level28yildiz == 0)
        {
            level28_0.SetActive(true);
        }
        if (level28yildiz == 1)
        {
            level28_1.SetActive(true);
        }
        if (level28yildiz == 2)
        {
            level28_2.SetActive(true);
        }
        if (level28yildiz == 3)
        {
            level28_3.SetActive(true);
        }
        world1totalyildiz = level1yildiz + level2yildiz + level3yildiz + level4yildiz + level5yildiz + level6yildiz + level7yildiz + level8yildiz + level9yildiz + level10yildiz;
        world1totalyildiztext.text = world1totalyildiz+" / 30";
        world2totalyildiz = level11yildiz + level12yildiz + level13yildiz + level14yildiz + level15yildiz + level16yildiz + level17yildiz + level18yildiz + level19yildiz + level20yildiz;
        world2totalyildiztext.text = world2totalyildiz + " / 30";
        world3totalyildiz = level21yildiz + level22yildiz + level23yildiz + level24yildiz + level25yildiz + level26yildiz + level27yildiz + level28yildiz;
        world3totalyildiztext.text = world3totalyildiz + " / 30";
        totalyildiz = level1yildiz + level2yildiz + level3yildiz + level4yildiz + level5yildiz + level6yildiz + level7yildiz + level8yildiz + level9yildiz + level10yildiz + level11yildiz + level12yildiz + level13yildiz + level14yildiz + level15yildiz + level16yildiz + level17yildiz + level18yildiz + level19yildiz + level20yildiz + level21yildiz + level22yildiz + level23yildiz + level24yildiz + level25yildiz + level26yildiz + level27yildiz + level28yildiz;
        totalyildiztext.text = totalyildiz.ToString();



        for (int i = 1; i <= PlayerPrefs.GetInt("kacincilevel"); i++)
        {
           
            if (PlayerPrefs.GetInt("kacincilevel") <= 10)
            {
                no1.transform.GetChild(i - 1).GetComponent<Button>().interactable = true;
            }
            if (PlayerPrefs.GetInt("kacincilevel") == 11 && totalyildiz < 20)
            {
                no1.transform.GetChild(0).GetComponent<Button>().interactable = true;
                no1.transform.GetChild(1).GetComponent<Button>().interactable = true;
                no1.transform.GetChild(2).GetComponent<Button>().interactable = true;
                no1.transform.GetChild(3).GetComponent<Button>().interactable = true;
                no1.transform.GetChild(4).GetComponent<Button>().interactable = true;
                no1.transform.GetChild(5).GetComponent<Button>().interactable = true;
                no1.transform.GetChild(6).GetComponent<Button>().interactable = true;
                no1.transform.GetChild(7).GetComponent<Button>().interactable = true;
                no1.transform.GetChild(8).GetComponent<Button>().interactable = true;
                no1.transform.GetChild(9).GetComponent<Button>().interactable = true;
            }
       

        }
        for (int j = 1; j <= PlayerPrefs.GetInt("kacincilevel")-10; j++)
        {

            if (PlayerPrefs.GetInt("kacincilevel") >= 11 && PlayerPrefs.GetInt("kacincilevel") < 21 && totalyildiz >= 20)
            {

                no1.transform.GetChild(0).GetComponent<Button>().interactable = true;
                no1.transform.GetChild(1).GetComponent<Button>().interactable = true;
                no1.transform.GetChild(2).GetComponent<Button>().interactable = true;
                no1.transform.GetChild(3).GetComponent<Button>().interactable = true;
                no1.transform.GetChild(4).GetComponent<Button>().interactable = true;
                no1.transform.GetChild(5).GetComponent<Button>().interactable = true;
                no1.transform.GetChild(6).GetComponent<Button>().interactable = true;
                no1.transform.GetChild(7).GetComponent<Button>().interactable = true;
                no1.transform.GetChild(8).GetComponent<Button>().interactable = true;
                no1.transform.GetChild(9).GetComponent<Button>().interactable = true;
                no2.transform.GetChild(j - 1).GetComponent<Button>().interactable = true;
            }
            if (PlayerPrefs.GetInt("kacincilevel") == 21 && totalyildiz < 45)
            {
                no1.transform.GetChild(0).GetComponent<Button>().interactable = true;
                no1.transform.GetChild(1).GetComponent<Button>().interactable = true;
                no1.transform.GetChild(2).GetComponent<Button>().interactable = true;
                no1.transform.GetChild(3).GetComponent<Button>().interactable = true;
                no1.transform.GetChild(4).GetComponent<Button>().interactable = true;
                no1.transform.GetChild(5).GetComponent<Button>().interactable = true;
                no1.transform.GetChild(6).GetComponent<Button>().interactable = true;
                no1.transform.GetChild(7).GetComponent<Button>().interactable = true;
                no1.transform.GetChild(8).GetComponent<Button>().interactable = true;
                no1.transform.GetChild(9).GetComponent<Button>().interactable = true;

                no2.transform.GetChild(0).GetComponent<Button>().interactable = true;
                no2.transform.GetChild(1).GetComponent<Button>().interactable = true;
                no2.transform.GetChild(2).GetComponent<Button>().interactable = true;
                no2.transform.GetChild(3).GetComponent<Button>().interactable = true;
                no2.transform.GetChild(4).GetComponent<Button>().interactable = true;
                no2.transform.GetChild(5).GetComponent<Button>().interactable = true;
                no2.transform.GetChild(6).GetComponent<Button>().interactable = true;
                no2.transform.GetChild(7).GetComponent<Button>().interactable = true;
                no2.transform.GetChild(8).GetComponent<Button>().interactable = true;
                no2.transform.GetChild(9).GetComponent<Button>().interactable = true;
            }




        }
        for (int k = 1; k <= PlayerPrefs.GetInt("kacincilevel") - 20; k++)
        {

            if (PlayerPrefs.GetInt("kacincilevel") >= 21 && totalyildiz >= 45)
            {

                no1.transform.GetChild(0).GetComponent<Button>().interactable = true;
                no1.transform.GetChild(1).GetComponent<Button>().interactable = true;
                no1.transform.GetChild(2).GetComponent<Button>().interactable = true;
                no1.transform.GetChild(3).GetComponent<Button>().interactable = true;
                no1.transform.GetChild(4).GetComponent<Button>().interactable = true;
                no1.transform.GetChild(5).GetComponent<Button>().interactable = true;
                no1.transform.GetChild(6).GetComponent<Button>().interactable = true;
                no1.transform.GetChild(7).GetComponent<Button>().interactable = true;
                no1.transform.GetChild(8).GetComponent<Button>().interactable = true;
                no1.transform.GetChild(9).GetComponent<Button>().interactable = true;

                no2.transform.GetChild(0).GetComponent<Button>().interactable = true;
                no2.transform.GetChild(1).GetComponent<Button>().interactable = true;
                no2.transform.GetChild(2).GetComponent<Button>().interactable = true;
                no2.transform.GetChild(3).GetComponent<Button>().interactable = true;
                no2.transform.GetChild(4).GetComponent<Button>().interactable = true;
                no2.transform.GetChild(5).GetComponent<Button>().interactable = true;
                no2.transform.GetChild(6).GetComponent<Button>().interactable = true;
                no2.transform.GetChild(7).GetComponent<Button>().interactable = true;
                no2.transform.GetChild(8).GetComponent<Button>().interactable = true;
                no2.transform.GetChild(9).GetComponent<Button>().interactable = true;

                no3.transform.GetChild(k - 1).GetComponent<Button>().interactable = true;
            }
          




        }
    }

    
   
    public void gelenbuton(int butonNo)
    {
        GetComponent<AudioSource>().PlayOneShot(ses[0]);
        if (butonNo == 1)
        {
            baslangic.SetActive(false);
            swipe.SetActive(true);
            totalyildizimg.SetActive(true);
        }
        if (butonNo == 2)
        {
            swipe.SetActive(false);
            no1.SetActive(true);
            geri.SetActive(true);

        }
        if (butonNo == 3)
        {
            swipe.SetActive(true);
            no1.SetActive(false);
            no2.SetActive(false);
            no3.SetActive(false);
            no2lock.SetActive(false);
            no3lock.SetActive(false);
            no4lock.SetActive(false);
            no5lock.SetActive(false);
            geri.SetActive(false);
        }
        if (butonNo == 4)
        {
            swipe.SetActive(false);
            if (totalyildiz >= 20)
            {
                no2.SetActive(true);
            }
            else
            {
                no2lock.SetActive(true);
            }
           
            geri.SetActive(true);
        }
        if (butonNo == 5)
        {
            swipe.SetActive(false);
            if (totalyildiz >= 45)
            {
                no3.SetActive(true);
            }
            else
            {
                no3lock.SetActive(true);
            }
            geri.SetActive(true);
        }
        if (butonNo == 6)
        {
            swipe.SetActive(false);
            no4lock.SetActive(true);
            geri.SetActive(true);
        }
        if (butonNo == 7)
        {
            swipe.SetActive(false);
            no5lock.SetActive(true);
            geri.SetActive(true);
        }
       
    }
    public void levellerbuton(int gelenlevel)
    {

        SceneManager.LoadScene(gelenlevel);
    }
}
