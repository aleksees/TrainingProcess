using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CalculateShoulder : MonoBehaviour
{
    [SerializeField] private Text final;
    //[SerializeField] private Text test;
    public static double moment;
    public static double totalLength;
    public static float y;
    public static float y2;
    public static float degrees;
    public static float x;
    [SerializeField] private Text test3;
    public static double pNum;
    public static double angleNum;
    public static double totalLengthPH;
    public static float upperArmNumber;
    public static double momentPH;
    public static double angleNum2;
    public static double totalLengthPH2;
    public static float upperArmNumber2;
    public static double momentPH2;
    // Start is called before the first frame update
    void Start()
    {

    }


    public void ShoulderWithoutPH()
    {
        totalLength = (Values.lowerArmNumber / 100.00) + (Values.upperArmNumber / 100.00);
        degrees = (float)((ValuesAngles.angle2 * Math.PI) / 180);
        y = (float)Math.Abs(totalLength * Math.Cos(degrees));
        x = (float)(totalLength * Math.Sin(degrees));
        moment = Math.Round(-x * CalculateElbow.forceY - y * CalculateElbow.forceX, 2);
        final.text = (-moment).ToString() + " Н•м";
    }

    public void ShoulderPH()
    {
        upperArmNumber = Values.upperArmNumber % 100;
        totalLengthPH = ((Values.lowerArmNumber * 0.42) / 100) + upperArmNumber / 100;
        angleNum = (AnglesPH.angle2 * Math.PI) / 180;
        y = (float)Math.Round(Math.Cos(angleNum) * totalLengthPH, 2);
        momentPH = Math.Round(Math.Round(-y * -CalcElbowPH.pNum) + moment, 2);
        pNum = ((Values.massHuman * 2.7) / 100) * 10;
        totalLengthPH2 = ((Values.upperArmNumber * 0.47) / 100);
        angleNum2 = (AnglesPH.angle3 * Math.PI) / 180;
        y2 = (float)Math.Round(Math.Cos(angleNum2) * totalLengthPH2, 2);
        momentPH2 = Math.Round(Math.Round(-y2 * -pNum) + momentPH, 2);
        test3.text = (-momentPH2).ToString() + " Н•м";
    }
}
