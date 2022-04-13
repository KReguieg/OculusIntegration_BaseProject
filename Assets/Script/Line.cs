using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class Line : MonoBehaviour
{
    // get the line renderer component
    [SerializeField] private LineRenderer lineRenderer;

    // store the points that make up the line i.e vector 3
    List<Vector3> points;

    //write a method to create the points
    public void SetPoint(Vector3 newPosition)
    {
        points.Add(newPosition);

        lineRenderer.positionCount = points.Count;
        lineRenderer.SetPosition(points.Count -1, newPosition);
    }

    // write a method to update the points
    public void UpdateLine(Vector3 position)
    {
        if(points == null)
        {
            points = new List<Vector3>();
            SetPoint(position);
        }

        if(Vector3.Distance(points.Last(), position) > 0.001f)
        {
            SetPoint(position);
        }
    }
}
