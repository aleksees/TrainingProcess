using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnglesPH : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    [SerializeField] private Text angleText1;
    public static int angle1;

    [SerializeField] private Text angleText2;
    public static int angle2;

    [SerializeField] private Text angleText3;
    public static int angle3;

    [SerializeField] private Text angleText4;
    public static int angle4;

    [SerializeField] private Text angleText5;
    public static int angle5;

    [SerializeField] private Text angleText6;
    public static int angle6;

    [SerializeField] private Text angleText7;
    public static int angle7;

    [SerializeField] private Text angleText8;
    public static int angle8;

    [SerializeField] private Text angleText9;
    public static int angle9;

    [SerializeField] private Text angleText10;
    public static int angle10;

    [SerializeField] private Text angleText11;
    public static int angle11;
    public static string angleText123;


    // Update is called once per frame
    void Update()
    {
        angleText123 = angleText1.text;
        bool success1 = int.TryParse(angleText1.text, out angle1);
        if (success1)
        {
            angle1 = int.Parse(angleText1.text);
        }
        else
        {
            angle1 = 0;
        }
        bool success2 = int.TryParse(angleText2.text, out angle2);
        if (success2)
        {
            angle2 = int.Parse(angleText2.text);
        }
        else
        {
            angle2 = 0;
        }
        bool success3 = int.TryParse(angleText3.text, out angle3);
        if (success3)
        {
            angle3 = int.Parse(angleText3.text);
        }
        else
        {
            angle3 = 0;
        }
        bool success4 = int.TryParse(angleText4.text, out angle4);
        if (success4)
        {
            angle4 = int.Parse(angleText4.text);
        }
        else
        {
            angle4 = 0;
        }
        bool success5 = int.TryParse(angleText5.text, out angle5);
        if (success5)
        {
            angle5 = int.Parse(angleText5.text);
        }
        else
        {
            angle5 = 0;
        }
        bool success6 = int.TryParse(angleText6.text, out angle6);
        if (success6)
        {
            angle6 = int.Parse(angleText6.text);
        }
        else
        {
            angle6 = 0;
        }
        bool success7 = int.TryParse(angleText7.text, out angle7);
        if (success7)
        {
            angle7 = int.Parse(angleText7.text);
        }
        else
        {
            angle7 = 0;
        }
        bool success8 = int.TryParse(angleText8.text, out angle8);
        if (success8)
        {
            angle8 = int.Parse(angleText8.text);
        }
        else
        {
            angle8 = 0;
        }
        bool success9 = int.TryParse(angleText9.text, out angle9);
        if (success9)
        {
            angle9 = int.Parse(angleText9.text);
        }
        else
        {
            angle9 = 0;
        }
        bool success10 = int.TryParse(angleText10.text, out angle10);
        if (success10)
        {
            angle10 = int.Parse(angleText10.text);
        }
        else
        {
            angle10 = 0;
        }
        bool success11 = int.TryParse(angleText11.text, out angle11);
        if (success11)
        {
            angle11 = int.Parse(angleText11.text);
        }
        else
        {
            angle11 = 0;
        }
    }
}
