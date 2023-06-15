using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalculateKnee : MonoBehaviour
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
    private double totalLengthPH4;
    private double totalLengthPH3;
    private double angleNum3;
    private float y3;
    private double momentPH3;
    public static float kneeNumber;
    private double momentTotalPH;
    public static double angleNum;
    public static double totalLengthPH;
    public static double momentPH;
    public static double angleNum2;
    public static double totalLengthPH2;
    public static double momentPH2;
    private double angleNum4;
    private float y4;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void KneeWithoutPH()
    {
        totalLength = (Values.lowerArmNumber / 100.00) + (Values.upperArmNumber / 100.00) + (Values.hipNumber / 100.00) + (Values.kneeNumber / 100.00);
        degrees = (float)((ValuesAngles.angle3 * Math.PI) / 180);
        y = (float)Math.Abs(totalLength * Math.Cos(degrees));
        x = (float)(totalLength * Math.Sin(degrees));
        moment = Math.Round(x * CalculateElbow.forceY - y * CalculateElbow.forceX, 2);
        final.text = (-moment).ToString() + " Н•м";
    }

    public void KneePH()
    {
        kneeNumber = Values.kneeNumber % 100;

        totalLengthPH = CalculateHip.totalLengthPH + kneeNumber / 100;
        angleNum = (AnglesPH.angle7 * Math.PI) / 180;
        y = (float)Math.Round(Math.Sin(angleNum) * totalLengthPH, 2);
        momentPH = (-y * -CalcElbowPH.pNum);

        totalLengthPH2 = CalculateHip.totalLengthPH2 + kneeNumber / 100;
        angleNum2 = (AnglesPH.angle8 * Math.PI) / 180;
        y2 = (float)Math.Round(Math.Sin(angleNum2) * totalLengthPH2, 2);
        momentPH2 = (-y2 * -CalculateShoulder.pNum) + momentPH;

        totalLengthPH3 = CalculateHip.totalLengthPH3 + kneeNumber / 100;
        angleNum3 = (AnglesPH.angle9 * Math.PI) / 180;
        y3 = (float)Math.Round(Math.Sin(angleNum3) * totalLengthPH3, 2);
        momentPH3 = -(-y3 * -CalculateHip.pNum) + momentPH2;

        pNum = ((Values.massHuman * 14.2) / 100) * 10;
        totalLengthPH4 = ((Values.kneeNumber * 0.44) / 100);
        angleNum4 = (AnglesPH.angle10 * Math.PI) / 180;
        y4 = (float)Math.Round(Math.Sin(angleNum4) * totalLengthPH4, 2);
        momentTotalPH = Math.Round(Math.Round(y4 * pNum) + momentPH3 + moment, 2);

        test3.text = (-momentTotalPH).ToString() + " Н•м";
    }
}
