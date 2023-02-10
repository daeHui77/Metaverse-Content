using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationFuc : MonoBehaviour  //Ä¶¸¯ÅÍ
{
    float rota;
    public GameObject cameraPose;
    public GameObject character;

    // Update is called once per frame
    void Update()
    {
        rotation();
    }
    void rotation()
    {
        character.transform.rotation = Quaternion.Euler(0,cameraPose.transform.rotation.eulerAngles.y , 0);
    }
}
