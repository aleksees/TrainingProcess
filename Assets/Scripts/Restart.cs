using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    [SerializeField] private GameObject gameObject1;
    [SerializeField] private GameObject go;

    public void ReastartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void RestartCalcPH()
    {
        SceneManager.LoadScene(4);
    }

    public void OpenMenu()
    {
        SceneManager.LoadScene(0);
    }


    public GameObject point;
    public void Color()
    {
        this.GetComponent<SpriteRenderer>().color = new Color32(255, 126, 126, 255);
    }

    public void Color2()
    {
        this.GetComponent<SpriteRenderer>().color = new Color32(54, 112, 202, 255);
    }
    Color c1 = new Color32(239, 125, 125, 255);
    public void ColorLRRed()
    {
        this.GetComponent<LineRenderer>().SetColors(c1, c1);
    }
    Color c2 = new Color32(165, 165, 165, 255);
    public void ColorLR()
    {
        this.GetComponent<LineRenderer>().SetColors(c2, c2);
    } 

    public void Exit()
    {
        Application.Quit();

        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }

    [SerializeField] private Transform gameObject2;
    [SerializeField] private Transform gameObject3;
    public void RightGraf()
    {
        this.transform.position = Vector3.Lerp(gameObject2.position, gameObject2.position, 0.42f);
    }
}
