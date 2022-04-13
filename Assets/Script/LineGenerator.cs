using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineGenerator : MonoBehaviour
{
    [SerializeField] private GameObject linePrefab;
    [SerializeField] private Transform paper;
    [SerializeField] private Transform tipPosition;

    private Line activeLine;
    private bool isTouching;

    void Update()
    {
        if(isTouching && activeLine == null)
        {
            GameObject newLine = Instantiate(linePrefab);
            activeLine = newLine.GetComponent<Line>();
        }

        if(!isTouching)
        {
            activeLine = null;
        }

        if(activeLine != null)
        {
            Vector3 newPos = new Vector3(tipPosition.position.x, paper.position.y +0.001f, tipPosition.position.z);
            Debug.Log("Tip pos " + tipPosition);
            activeLine.UpdateLine(newPos);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if( other.tag == "Paper")
            isTouching = true;
        Debug.Log("trigger entered" + isTouching);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Paper")
            isTouching = false;
        Debug.Log("trigger entered" + isTouching);

    }

}
