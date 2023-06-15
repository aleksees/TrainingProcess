using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    public Transform target01;
    public Transform target02;
    public float fract;
    public GameObject gameObject1;
    //[SerializeField] private Transform center;
    // Update is called once per frame
    public void Hip()
    {
        transform.position = Vector2.Lerp(target01.position, target02.position, 0.42f);
        Vector3 zPos = gameObject1.transform.localPosition;
        zPos.z = 0f;
        gameObject1.transform.localPosition = zPos;
    }
    public void NotHip()
    {
        transform.position = Vector2.Lerp(target01.position, target02.position, 0.24f);
        Vector3 zPos = gameObject1.transform.localPosition;
        zPos.z = 0f;
        gameObject1.transform.localPosition = zPos;
    }

}
