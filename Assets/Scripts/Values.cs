using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Values : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Slider _slider;
    [SerializeField] private Slider _slider2;
    [SerializeField] private Slider _slider3;
    [SerializeField] private Slider _slider4;
    [SerializeField] private Slider _slider5;
    [SerializeField] private Slider _slider6;
    public static int upperArmNumber;
    public static int lowerArmNumber;
    public static int hipNumber;
    public static int kneeNumber;
    public static int massHuman;
    public static int massGruz;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        lowerArmNumber = (int)_slider.value;
        upperArmNumber = (int)_slider2.value;
        hipNumber = (int)_slider3.value;
        kneeNumber = (int)_slider4.value;
        massHuman = (int)_slider5.value;
        massGruz = (int)_slider6.value;
    }
}
