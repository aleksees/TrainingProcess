using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValuesAngles : MonoBehaviour
{
    [SerializeField] private Text angleText;
    [SerializeField] private Text angleText2;
    [SerializeField] private Text angleText3;
    [SerializeField] private Text angleText4;
    public static int angle;
    public static int angle2;
    public static int angle3;
    public static int angle4;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        bool success1 = int.TryParse(angleText.text, out angle);
        if (success1)
        {
            angle = int.Parse(angleText.text);
        }
        else
        {
            angle = 0;
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
    }
}
