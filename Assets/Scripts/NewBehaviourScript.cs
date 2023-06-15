using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public enum Axis
{
    X,
    Y,
    Z
}
public class NewBehaviourScript : MonoBehaviour
{
    public GameObject target;// ������ ��� �����������
    public Slider slider;// ��������� ��������
    public Axis axis = Axis.X;// ��������� �� ���� ���
    public float left_bottom_back;//����� ����
    public float right_up_forward;// ������ �������
    private float D_value;// ������� ����� ����� � ������ ���������

    void Start()
    {
        D_value = right_up_forward - left_bottom_back;
        //// ��������� - ���������� ��������� ��������� ������� � ��������� ��������� ��������
        switch (axis)
        {
            case Axis.X:
                target.transform.localPosition += new Vector3(-target.transform.localPosition.x + left_bottom_back  + D_value * (slider.value / 100), 0, 0);
                target.transform.localPosition += new Vector3(0, -target.transform.localPosition.y + left_bottom_back + D_value * (slider.value / 100), 0);
                break;
                //    //case Axis.Y:
                //    //    target.transform.position += new Vector3(0, -target.transform.position.y + left_bottom_back + D_value * (slider.value / 100), 0);
                //    //    break;
                //    //case Axis.Z:
                //    //    target.transform.position += new Vector3(0, 0, -target.transform.position.z + left_bottom_back + D_value * (slider.value / 100));
                //    //    break;
        }

        slider.onValueChanged.AddListener(delegate { this.HandleValuChange(); });
        if (!target)
        {
            Debug.Log("missing target!");
        }
        if (!slider)
        {
            Debug.Log("missing slider!");
        }
    }

    public void HandleValuChange()
    {
        // ��� ��������� �������� �������� �������� ��� ������� � ������ ��������� �������
        switch (axis)
        {
            case Axis.X:
                float Xpos = left_bottom_back + D_value * (slider.value / 100);
                target.transform.localPosition += new Vector3(-target.transform.localPosition.x + Xpos, 0, 0);
                float Ypos = left_bottom_back + D_value * (slider.value / 100);
                target.transform.localPosition += new Vector3(0, -target.transform.localPosition.y + Ypos, 0);
                break;
            //case Axis.Y:
            //    float Ypos = left_bottom_back + D_value * (slider.value / 50);
            //    target.transform.position += new Vector3(0, -target.transform.position.y + Ypos, 0);
            //    break;
            //case Axis.Z:
            //    float Zpos = left_bottom_back + D_value * (slider.value / 100);
            //    target.transform.position += new Vector3(0, 0, -target.transform.position.z + Zpos);
            //    break;
        }
    }
}
