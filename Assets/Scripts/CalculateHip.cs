using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalculateHip : MonoBehaviour
{
    [SerializeField] private Text final;
    //[SerializeField] private Text test;
    public static double moment;
    public static double length;
    public static double length1;
    public static double length2;
    public static double totalLength;
    public static float y;
    public static float y2;
    public static float degrees;
    public static float x;
    [SerializeField] private Text test3;
    public static double pNum;
    public static double totalLengthPH3;
    private double angleNum3;
    private float y3;
    private double momentTotalPH;
    public static float hipNumber;
    public static double angleNum;
    public static double totalLengthPH;
    public static double momentPH;
    public static double angleNum2;
    public static double totalLengthPH2;
    public static double momentPH2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void HipWithoutPH()
    {
        length = (Values.lowerArmNumber / 100.00);
        length1 = (Values.upperArmNumber / 100.00);
        length2 = (Values.hipNumber / 100.00);
        totalLength = length + length1 + length2;
        degrees = (float)((ValuesAngles.angle4 * Math.PI) / 180);
        y = (float)Math.Abs(totalLength * Math.Cos(degrees));
        x = (float)(totalLength * Math.Sin(degrees));
        moment = Math.Round(x * CalculateElbow.forceY - y * CalculateElbow.forceX, 2);
        final.text = (-moment).ToString() + " Н•м";
    }

    public void HipPH()
    {
        hipNumber = Values.hipNumber % 100;

        totalLengthPH = CalculateShoulder.totalLengthPH + hipNumber / 100;
        angleNum = (AnglesPH.angle4 * Math.PI) / 180;
        y = (float)Math.Round(Math.Sin(angleNum) * totalLengthPH, 2);
        momentPH = (-y * -CalcElbowPH.pNum);

        totalLengthPH2 = CalculateShoulder.totalLengthPH2 + hipNumber / 100;
        angleNum2 = (AnglesPH.angle5 * Math.PI) / 180;
        y2 = (float)Math.Round(Math.Sin(angleNum2) * totalLengthPH2, 2);
        momentPH2 = (-y2 * -CalculateShoulder.pNum) + momentPH;

        pNum = ((Values.massHuman * 43.5) / 100) * 10;
        totalLengthPH3 = ((Values.hipNumber * 0.44) / 100); 
        angleNum3 = (AnglesPH.angle6 * Math.PI) / 180;
        y3 = (float)Math.Round(Math.Sin(angleNum3) * totalLengthPH3, 2);
        momentTotalPH = Math.Round(Math.Round(-y3 * -pNum) + momentPH2 + moment, 2);
        test3.text = (-momentTotalPH).ToString() + " Н•м";
    }
}
