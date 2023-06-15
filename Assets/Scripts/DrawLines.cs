using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLines : MonoBehaviour
{
    [SerializeField] private Transform start;
    [SerializeField] private Transform end;
    private LineRenderer lr;
    private Vector3[] positions;

    private void Awake()
    {
        lr = GetComponent<LineRenderer>();
        lr.positionCount = 3;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        positions = new Vector3[] { start.position, transform.position, end.position };
        SetLineRendererPositions();
    }

    private void SetLineRendererPositions()
    {
        lr.SetPositions(positions);
    }
}
