using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxisPH : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public Transform target01;
    public Transform target02;
    public float fract;
    [SerializeField] private Transform axisX;
    [SerializeField] private Transform axisY;
    [SerializeField] private Transform center;
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(target01.position, target02.position, 0.42f);
        axisX.position = center.position;
        axisY.position = center.position;
        center.position = target01.position;
    }
}
