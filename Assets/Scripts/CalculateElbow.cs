using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalculateElbow : MonoBehaviour
{
    [SerializeField] private Text final;
    [SerializeField] private Text final2;
    //[SerializeField] private Text test;
    public static double moment;
    public static int force;
    public static float forceX;
    public static float forceY;
    public static double length;
    public static float y;
    public static float y2;
    public static float degrees;
    public static float x;
    [SerializeField] private Text lengthText;
    //[SerializeField] private Text test3;
    public static double pNum;
    public static double angleNum;
    public static double totalLength;
    public static float upperArmNumber;
    public static double momentPH;
    // Start is called before the first frame update
    void Start()
    {
        force = Values.massGruz * 10;
        forceX = (float)(force * Math.Cos(50 * (Math.PI / 180)));
        forceY = (float)(force * Math.Sin(50 * (Math.PI / 180)));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ElbowWithoutPH()
    {
        length = (Values.lowerArmNumber / 100.00);
        degrees = (float)((ValuesAngles.angle * Math.PI) / 180);
        y = (float)Math.Abs(length * Math.Cos(degrees));
        x = (float)(length * Math.Sin(degrees));
        moment = Math.Round(- x * forceY - y * forceX, 2);
        final.text = (-moment).ToString() + " Н•м";
    }
}


