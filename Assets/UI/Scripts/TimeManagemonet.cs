using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
public class TimeManagemonet : MonoBehaviour
{
    public Text text;
    public float limitTime;

    // Update is called once per frame
    void Update()
    {
        if (limitTime > 0.0f)
        {
            limitTime -= Time.deltaTime;
        }
        else if (limitTime <= 0.0f)
        {
            GameObject.Find("UIManagement").GetComponent<UIManagement>().removeFGameUI();
        }
        text.text = limitTime.ToString("F2");
    }

}
