using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckInputField : MonoBehaviour
{
    [SerializeField] private Sprite spriteNew;
    [SerializeField] private Sprite spriteNew2;
    public InputField mainInputField;
    public static int mainInputFieldInt;
    public static bool right = false;
    public GameObject rightIm;
    public GameObject wrong;
    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        mainInputField.onValueChanged.AddListener(delegate { ValueChangeCheck(mainInputField.text); });
    }

    // Update is called once per frame
    public void ValueChangeCheck(string text)
    {
        bool success1 = int.TryParse(mainInputField.text, out mainInputFieldInt);
        if (success1)
        {
            mainInputFieldInt = int.Parse(mainInputField.text);
        }
        else
        {
            mainInputFieldInt = 0;
        }
        if ((text == (-CalcElbowPH.momentPH).ToString()) || ((mainInputFieldInt <= CalcElbowPH.probMomentPH) && (mainInputFieldInt >= CalcElbowPH.momentPH)))
        {
            right = true;

        }
        else
        {
            right = false;
        }

    }

    public void ReplaceSprite()
    {
        if (right == true)
        {
            mainInputField.GetComponent<Image>().sprite = spriteNew;
            rightIm.SetActive(true);
            panel.SetActive(true);

        }
        else
        {
            mainInputField.GetComponent<Image>().sprite = spriteNew2;
            wrong.SetActive(true);
            panel.SetActive(true);
        }
    }
}
