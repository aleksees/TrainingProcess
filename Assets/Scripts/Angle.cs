using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Angle : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform start;
    public Transform target;
    [SerializeField]
    private Text angleText;
    void Update()
    {
        Vector3 targetDir = target.position - transform.position;
        Vector3 targetStart = start.position - transform.position;
        float angle = Vector3.Angle(targetDir, targetStart);

        if (angle < 5.0f)
            print("close");

        angleText.text = (Mathf.Round(angle)).ToString();
    }
}
