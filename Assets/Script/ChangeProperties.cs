using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeProperties : MonoBehaviour
{
    [SerializeField] private GameObject cubeObject;
    
    private float setScale;
    private float setXTransform;
    private float setYTransform;
    private float setZTransform;

    private Transform cubeTransform;
    private Vector3 stratingScale;
    private Vector3 stratingTransform;

    private void Start()
    {
       cubeTransform = cubeObject.transform;
       stratingScale = cubeTransform.localScale;
       stratingTransform = cubeTransform.localPosition;
    }

    public void OnScaleChanged(float newValue)
    {
        setScale = newValue * 0.1f;       
        cubeTransform.localScale = new Vector3(stratingScale.x + setScale, stratingScale.y + setScale, stratingScale.z + setScale);
    }

    public void OnXTransformChanged(float newValue)
    {
        setXTransform = newValue;
        cubeTransform.position = new Vector3(stratingTransform.x + setXTransform, stratingTransform.y, stratingTransform.z);
    }

    public void OnYTransformChanged(float newValue)
    {
        setYTransform = newValue;
        cubeTransform.position = new Vector3(stratingTransform.x , stratingTransform.y + setYTransform, stratingTransform.z);
    }

    public void OnZTransformChanged(float newValue)
    {
        setZTransform = newValue;
        cubeTransform.position = new Vector3(stratingTransform.x, stratingTransform.y, stratingTransform.z+ setZTransform);
    }

}

