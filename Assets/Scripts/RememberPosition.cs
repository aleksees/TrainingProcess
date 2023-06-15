using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RememberPosition : MonoBehaviour
{
    public static Vector3 point1;
    public static Vector3 point2;
    public static Vector3 point3;
    [SerializeField] private Transform pointPos1;
    [SerializeField] private Transform pointPos2;
    [SerializeField] private Transform pointPos3;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        point1 = pointPos1.position;
        point2 = pointPos2.position;
        point3 = pointPos3.position;
    }
}
