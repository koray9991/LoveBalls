using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line2 : MonoBehaviour
{
    public LineRenderer linerenderer;
    public EdgeCollider2D edgeCollider;
    
    [HideInInspector] public List<Vector2> points = new List<Vector2>();
    [HideInInspector] public int pointscount = 0;
    float pointmindistance = 0.1f;
    float circlecolliderradius;
    public float edgetimer;
    private void Awake()
    {
        edgeCollider.isTrigger = true;
    }
    private void Update()
    {
        edgetimer += Time.deltaTime;
        if (edgetimer > 0.1f)
        {
            edgeCollider.isTrigger = false;
        }
    }
        public void AddPoint(Vector2 newpoint)
    {
        if (pointscount >= 1 && Vector2.Distance(newpoint, GetLastPoint()) < pointmindistance)
            return;

        points.Add(newpoint);
        pointscount++;
        LinesDrawer2.time -= 1;
        CircleCollider2D circleCollider = this.gameObject.AddComponent<CircleCollider2D>();
        circleCollider.offset = newpoint;
        circleCollider.radius = circlecolliderradius;

        linerenderer.positionCount = pointscount;
        linerenderer.SetPosition(pointscount - 1, newpoint);

        if (pointscount > 1)
        {
            edgeCollider.points = points.ToArray();
        }
    }
    public Vector2 GetLastPoint()
    {
        return (Vector2)linerenderer.GetPosition(pointscount - 1);
    }
   
    public void SetLineColor(Gradient colorgradient)
    {
        linerenderer.colorGradient = colorgradient;
    }
    public void SetPointsMinDistance(float distance)
    {
        pointmindistance = distance;
    }
    public void SetLineWidth(float width)
    {
        linerenderer.startWidth = width;
        linerenderer.endWidth = width;
        circlecolliderradius = width / 2f;
        edgeCollider.edgeRadius = circlecolliderradius;
    }

}
