using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFuc : MonoBehaviour
{
    float rotaY;
    float rotaX;
    float x;
    float y;
    float clampX;
    public GameObject cameraPose;

    void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X");
        float mouseY = Input.GetAxisRaw("Mouse Y");

        //카메라 시점 변경
        if (Input.GetMouseButton(1))
        {
            rotaY = cameraPose.transform.rotation.eulerAngles.y;
            rotaX = cameraPose.transform.rotation.eulerAngles.x;
            x = rotaX - mouseY;
            y = rotaY + mouseX;
            if (x > 180)
            {
                x = x - 360;
            }
            clampX = Mathf.Clamp(x, -40.0f, 40.0f);
            cameraPose.transform.rotation = Quaternion.Euler(clampX, y, 0);
        }
    }
}
