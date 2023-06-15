using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightPositionPers : MonoBehaviour
{
    [SerializeField] private GameObject gameObject1;
    // Start is called before the first frame update
    public void StartInput()
    {
        gameObject1.transform.position = new Vector3(3.5786f, -0.125f, gameObject1.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
