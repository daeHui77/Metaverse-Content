using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Staminabar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;
    //���׹̳� �ʱ�ȭ
    public void SetMaxStamina(float stamina)
    {
        slider.maxValue = stamina;
        slider.value = stamina;

        fill.color = gradient.Evaluate(1f);
    }
    //���׹̳� ����ȭ
    public void SetStamina(float stamina)
    {
        slider.value = stamina;
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }

   
}
