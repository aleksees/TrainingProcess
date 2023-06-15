using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadPositions : MonoBehaviour
{
    [SerializeField] private Transform pointPos1;
    [SerializeField] private Transform pointPos2;
    [SerializeField] private Transform pointPos3;

    // Start is called before the first frame update
    void Start()
    {
        pointPos1.position = RememberPosition.point1;
        pointPos2.position = RememberPosition.point2;
        pointPos3.position = RememberPosition.point3;
        if (SceneManager.GetActiveScene().name == "InputScene")
        {
            GetComponent<RightPositionPers>().StartInput();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
