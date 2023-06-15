using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;

    public void Check1()
    {
        if ((text2.activeSelf) || (text3.activeSelf) || (text4.activeSelf))
        {
            text2.SetActive(false);
            text3.SetActive(false);
            text4.SetActive(false);
        }
    }

    public void Check2()
    {
        if ((text1.activeSelf) || (text3.activeSelf) || (text4.activeSelf))
        {
            text1.SetActive(false);
            text3.SetActive(false);
            text4.SetActive(false);
        }

    }
    public void Check3()
    {
        if ((text2.activeSelf) || (text1.activeSelf) || (text4.activeSelf))
        {
            text1.SetActive(false);
            text2.SetActive(false);
            text4.SetActive(false);
        }
    }
    public void Check4()
    {
        if ((text1.activeSelf) || (text2.activeSelf) || (text3.activeSelf))
        {
            text1.SetActive(false);
            text2.SetActive(false);
            text3.SetActive(false);
        }
    }
}
