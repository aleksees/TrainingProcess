using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Checking : MonoBehaviour
{
    [SerializeField] private Sprite sprite1;
    [SerializeField] private Sprite sprite2;
    public GameObject wrong;
    public GameObject right;
    public GameObject panel;
    public Transform one;
    public GameObject oneSprite;
    public Transform one2;
    public GameObject oneSprite2;
    public Transform one3;
    public GameObject oneSprite3;
    public Transform one4;
    public GameObject oneSprite4;
    public Transform one5;
    public GameObject oneSprite5;
    public Transform one6;
    public GameObject oneSprite6;
    public Transform one7;
    public GameObject oneSprite7;
    public Transform one8;
    public GameObject oneSprite8;
    public Transform two;
    public Transform two2;
    public Transform two3;
    public Transform two4;
    public Transform two5;
    public Transform two6;
    public Transform two7;
    public Transform two8;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if ((one.position == two.position) || (one.position == two2.position))
        {
            oneSprite.GetComponent<Image>().sprite = sprite1;
        }
        else
        {
            oneSprite.GetComponent<Image>().sprite = sprite2;
        }
        if ((one2.position == two.position) || (one2.position == two2.position))
        {
            oneSprite2.GetComponent<Image>().sprite = sprite1;
        }
        else
        {
            oneSprite2.GetComponent<Image>().sprite = sprite2;
        }

        if ((one3.position == two3.position) || (one3.position == two4.position))
        {
            oneSprite3.GetComponent<Image>().sprite = sprite1;
        }
        else
        {
            oneSprite3.GetComponent<Image>().sprite = sprite2;
        }
        if ((one4.position == two3.position) || (one4.position == two4.position))
        {
            oneSprite4.GetComponent<Image>().sprite = sprite1;
        }
        else
        {
            oneSprite4.GetComponent<Image>().sprite = sprite2;
        }

        if ((one5.position == two5.position) || (one5.position == two6.position))
        {
            oneSprite5.GetComponent<Image>().sprite = sprite1;
        }
        else
        {
            oneSprite5.GetComponent<Image>().sprite = sprite2;
        }
        if ((one6.position == two5.position) || (one6.position == two6.position))
        {
            oneSprite6.GetComponent<Image>().sprite = sprite1;
        }
        else
        {
            oneSprite6.GetComponent<Image>().sprite = sprite2;
        }

        if ((one7.position == two7.position) || (one7.position == two8.position))
        {
            oneSprite7.GetComponent<Image>().sprite = sprite1;
        }
        else
        {
            oneSprite7.GetComponent<Image>().sprite = sprite2;
        }
        if ((one8.position == two7.position) || (one8.position == two8.position))
        {
            oneSprite8.GetComponent<Image>().sprite = sprite1;
        }
        else
        {
            oneSprite8.GetComponent<Image>().sprite = sprite2;
        }

        if ((oneSprite.GetComponent<Image>().sprite == sprite2) || (oneSprite2.GetComponent<Image>().sprite == sprite2) || (oneSprite3.GetComponent<Image>().sprite == sprite2) || (oneSprite4.GetComponent<Image>().sprite == sprite2) || (oneSprite5.GetComponent<Image>().sprite == sprite2) || (oneSprite6.GetComponent<Image>().sprite == sprite2) || (oneSprite7.GetComponent<Image>().sprite == sprite2) || (oneSprite8.GetComponent<Image>().sprite == sprite2))
        {
            wrong.SetActive(true);
            panel.SetActive(true);
        }
        else
        {
            right.SetActive(true);
            panel.SetActive(true);
        }
    }
}
