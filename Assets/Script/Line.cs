using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class Line : MonoBehaviour
{
    // get the line renderer component
    [SerializeField] private LineRenderer lineRenderer;

    // store the points that make up the line i.e vector 3
    private List<Vector3> points = new List<Vector3>();

    //write a method to create the points
    public void SetPoint(Vector3 newPosition)
    {
        this.points.Add(newPosition);

        this.lineRenderer.positionCount = points.Count;
        this.lineRenderer.SetPosition(points.Count -1, newPosition);
    }

    // write a method to update the points
    public void UpdateLine(Vector3 position)
    {
        if (Vector3.Distance(this.points.Last(), position) > 0.001f)
            this.SetPoint(position);
    }
}
