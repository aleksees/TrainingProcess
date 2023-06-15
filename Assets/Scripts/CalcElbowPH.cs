using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalcElbowPH : MonoBehaviour
{
    [SerializeField] private Text lengthText;
    [SerializeField] private Text alpha;
    //[SerializeField] private Text test3;
    public static double pNum;
    public static double angleNum;
    public static double totalLength;
    public static float upperArmNumber;
    public static double momentPH;
    public static double probMomentPH;
    public static float y2;
    [SerializeField] private Text final2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lengthText.text = "CO = " + (Values.lowerArmNumber * 0.42).ToString() + "см" + Environment.NewLine + "p = " + ((Values.massHuman * 1.6) / 100).ToString() + "кг";
        alpha.text = "= " + AnglesPH.angle11.ToString() + "°";
        pNum = (double)(((Values.massHuman * 1.6) / 100) * 10);
        totalLength = ((Values.lowerArmNumber * 0.42) / 100);
        angleNum = (AnglesPH.angle11 * Math.PI) / 180;
        y2 = (float)Math.Round(Math.Round(Math.Cos(angleNum), 3) * totalLength, 3);
        momentPH = Math.Round(Math.Round(-y2 * -pNum, 3) + CalculateElbow.moment, 2);
        probMomentPH = momentPH + 0.05;
        final2.text = (-momentPH).ToString();
    }
}
