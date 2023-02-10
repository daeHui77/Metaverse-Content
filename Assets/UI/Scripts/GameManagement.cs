using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagement : MonoBehaviour
{
    
    public Canvas canvas;
    public int number;
    public ItemAdd itemAdd;
    public TimeManagemonet timeManagemonet;

    public UIManagement uIManagement;
    public void GameStart()
    {

        canvas.gameObject.transform.GetChild(2).GetChild(0).gameObject.SetActive(false);

        canvas.gameObject.transform.GetChild(2).GetChild(1).gameObject.SetActive(true);
    }
     void Update()
    {

        Debug.Log(itemAdd.GetCoinCount());
        if (itemAdd.GetCoinCount() == 9)
        {
            uIManagement.removeSGameUI();
        }
    }

}
