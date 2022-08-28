using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LinesDrawer : MonoBehaviour
{
     AudioSource aso;
    public GameObject lineprefab;
    public LayerMask cantdrawoverlayer, cantdrawoverlayer2;
    int cantdrawoverlayerindex, cantdrawoverlayerindex2;
    [Space(30f)]
    public Gradient linecolor;
    public float linepointsmindistance;
    public float linewidth;
    Line currentline;
    Camera cam;
    public float maxtime;
   public static float time;
    public Image bar;
    public GameObject dotred;
    public GameObject redpen;
    public GameObject tanitim1, tanitim2;
    public GameObject ball1, ball2;
    public bool gravity0;
    void Start()
    {
        if (gravity0)
        {
            ball1.GetComponent<Rigidbody2D>().gravityScale = 0;
            ball2.GetComponent<Rigidbody2D>().gravityScale = 0;
        }
        buton.uzerinde = false;  buton2.uzerinde2 = false; buton3.uzerinde3 = false;
        cam = Camera.main;
        cantdrawoverlayerindex = LayerMask.NameToLayer("CantDrawOver");
        cantdrawoverlayerindex2 = LayerMask.NameToLayer("rope");
        time = maxtime;
        aso = GetComponent<AudioSource>();
        aso.volume = 0f;

        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            tanitim1.SetActive(true);
            tanitim2.SetActive(false);
        }

    }

    
    void Update()
    {
       
            bar.GetComponent<Image>().fillAmount = time / maxtime;
        if (Input.GetMouseButtonDown(0) && !buton.uzerinde && !buton2.uzerinde2 && !buton3.uzerinde3 && time > 0 && !gamemanager.bitti)
        {
            begindraw();
        }
        if (currentline != null && time > 0)
        {
            draw();
            aso.volume = 0.5f;
            if (SceneManager.GetActiveScene().buildIndex == 1)
            {
                tanitim1.SetActive(false);
                tanitim2.SetActive(true);
            }
        }
        if (Input.GetMouseButtonUp(0) ||  time <= 0)
        {
            enddraw();
            aso.volume = 0f;
        }
    }
    void begindraw()
    {
        currentline = Instantiate(lineprefab, this.transform).GetComponent<Line>();
        currentline.UsePhysics(false);
        currentline.SetLineColor(linecolor);
        currentline.SetPointsMinDistance(linepointsmindistance);
        currentline.SetLineWidth(linewidth);
        redpen.SetActive(true);
    }
    void draw()
    {
        Vector2 mouseposition = cam.ScreenToWorldPoint(Input.mousePosition);
        redpen.transform.position = mouseposition;
        RaycastHit2D hit = Physics2D.CircleCast(mouseposition, linewidth / 3f, Vector2.zero, 1f,cantdrawoverlayer);
        RaycastHit2D hit2 = Physics2D.CircleCast(mouseposition, linewidth / 3f, Vector2.zero, 1f, cantdrawoverlayer2);
        if (hit || hit2)
            enddraw();
        else
        {
            currentline.AddPoint(mouseposition);
            
        }
    }
    void enddraw()
    {
        if (currentline != null)
        {
            ball1.GetComponent<Rigidbody2D>().gravityScale = 1;
            ball2.GetComponent<Rigidbody2D>().gravityScale = 1;
            redpen.SetActive(false);
            if (currentline.pointscount < 2 && time > 0)
            {
                Destroy(currentline.gameObject);
                Vector2 mouseposition = cam.ScreenToWorldPoint(Input.mousePosition);
                RaycastHit2D hit = Physics2D.CircleCast(mouseposition, linewidth / 3f, Vector2.zero, 1f, cantdrawoverlayer);
                RaycastHit2D hit2 = Physics2D.CircleCast(mouseposition, linewidth / 3f, Vector2.zero, 1f, cantdrawoverlayer2);
                if (hit || hit2)
                {

                }
                    
                else
                {
                    Instantiate(dotred, mouseposition, Quaternion.identity);

                }
                
                currentline = null;
                
            }
            else
            {
                currentline.GetComponent<Rigidbody2D>().mass = currentline.pointscount/10f;
                currentline.gameObject.layer = cantdrawoverlayerindex;
                currentline.UsePhysics(true);
                currentline = null;
                
            }
        }
    }
}
