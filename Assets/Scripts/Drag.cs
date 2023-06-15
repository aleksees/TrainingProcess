using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    public GameObject selectedObject;
    public GameObject background1;
    public GameObject background2;
    public GameObject background3;
    Vector3 offset;
    

    private void Start()
    {

    }

    void Update()
    {

        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            Collider2D targetObject = Physics2D.OverlapPoint(mousePosition);
            if (targetObject)
            {
                selectedObject = targetObject.transform.gameObject;
                offset = selectedObject.transform.position - mousePosition;
            }
        }
        if (selectedObject)
        {
            selectedObject.transform.position = mousePosition + offset;
            //Debug.Log(selectedObject.transform.position);

            if (selectedObject.CompareTag("pointOfElbow"))
            {
                if ((background2.activeSelf) || (background3.activeSelf))
                {
                    background2.SetActive(false);
                    background3.SetActive(false);
                }
                background1.SetActive(true);
                selectedObject.GetComponent<SpriteRenderer>().color = new Color32(50, 110, 199, 255);
                if (selectedObject.transform.position.y > 1.05)
                {
                    selectedObject.transform.position = new Vector3(selectedObject.transform.position.x, 1.05f, selectedObject.transform.position.z);
                }
                if (selectedObject.transform.position.y < 0.52)
                {
                    selectedObject.transform.position = new Vector3(selectedObject.transform.position.x, 0.52f, selectedObject.transform.position.z);
                }

                if ((selectedObject.transform.position.x > 2.38) || (selectedObject.transform.position.x < 2.38))
                {
                    selectedObject.transform.position = new Vector3(2.38f, selectedObject.transform.position.y, selectedObject.transform.position.z);
                }
            }
            else if (selectedObject.CompareTag("pointOfHip"))
            {
                if ((background1.activeSelf) || (background3.activeSelf))
                {
                    background1.SetActive(false);
                    background3.SetActive(false);
                }
                background2.SetActive(true);
                selectedObject.GetComponent<SpriteRenderer>().color = new Color32(50, 110, 199, 255);
                if (selectedObject.transform.position.x > 0.74)
                {
                    selectedObject.transform.position = new Vector3(0.74f, selectedObject.transform.position.y, selectedObject.transform.position.z);
                }
                if (selectedObject.transform.position.x < 0.13)
                {
                    selectedObject.transform.position = new Vector3(0.13f, selectedObject.transform.position.y, selectedObject.transform.position.z);
                }

                if ((selectedObject.transform.position.y > -0.38) || (selectedObject.transform.position.y < -0.38))
                {
                    selectedObject.transform.position = new Vector3(selectedObject.transform.position.x, -0.38f, selectedObject.transform.position.z);
                }
            }
            else if (selectedObject.CompareTag("pointOfKnee"))
            {
                if ((background2.activeSelf) || (background1.activeSelf))
                {
                    background2.SetActive(false);
                    background1.SetActive(false);
                }
                background3.SetActive(true);
                selectedObject.GetComponent<SpriteRenderer>().color = new Color32(50, 110, 199, 255);
                if (selectedObject.transform.position.x > 1.57)
                {
                    selectedObject.transform.position = new Vector3(1.57f, selectedObject.transform.position.y, selectedObject.transform.position.z);
                }
                if (selectedObject.transform.position.x < 0.95)
                {
                    selectedObject.transform.position = new Vector3(0.95f, selectedObject.transform.position.y, selectedObject.transform.position.z);
                }

                if ((selectedObject.transform.position.y > -2.56) || (selectedObject.transform.position.y < -2.56))
                {
                    selectedObject.transform.position = new Vector3(selectedObject.transform.position.x, -2.56f, selectedObject.transform.position.z);
                }
            }


        }
        if (Input.GetMouseButtonUp(0) && selectedObject)
        {
            background1.SetActive(false);
            background2.SetActive(false);
            background3.SetActive(false);
            selectedObject.GetComponent<SpriteRenderer>().color = new Color32(255, 126, 126, 255);
            selectedObject = null;
        }
    }
}
