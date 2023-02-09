using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;
    //ü�� �ʱ�ȭ
    public void SetMaxHealth(int health)
    {
        slider.maxValue= health;
        slider.value = health;

        fill.color = gradient.Evaluate(1f);
    }
    //ü�� ����ȭ
    public void SetHealth(int health)
    {
        slider.value = health;

        fill.color = gradient.Evaluate(slider.normalizedValue);
    }

}
