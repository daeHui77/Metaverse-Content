using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManagement : MonoBehaviour
{
    public GameObject canvas;
    int count;
    // Start is called before the first frame update
    void Start()
    {
        canvas.gameObject.transform.GetChild(2).GetChild(0).gameObject.SetActive(false);
        canvas.gameObject.transform.GetChild(2).GetChild(1).gameObject.SetActive(false);

        canvas.gameObject.transform.GetChild(2).GetChild(2).gameObject.SetActive(false);
        canvas.gameObject.transform.GetChild(2).GetChild(2).GetChild(0).gameObject.SetActive(false);
        canvas.gameObject.transform.GetChild(2).GetChild(2).GetChild(1).gameObject.SetActive(false);
        canvas.gameObject.transform.GetChild(2).GetChild(2).GetChild(2).gameObject.SetActive(false);
        count = 0;
    }
    public void showGameUI()
    {
        canvas.gameObject.transform.GetChild(2).GetChild(0).gameObject.SetActive(true);
        count = 1;
    }
    public void removeSGameUI()
    {
        canvas.gameObject.transform.GetChild(2).GetChild(2).gameObject.SetActive(true);
        canvas.gameObject.transform.GetChild(2).GetChild(2).GetChild(0).gameObject.SetActive(true);
        
        canvas.gameObject.transform.GetChild(2).GetChild(2).GetChild(2).gameObject.SetActive(true);
        count = 0;

    }
    public void removeFGameUI()
    {
        canvas.gameObject.transform.GetChild(2).GetChild(2).gameObject.SetActive(true);
        canvas.gameObject.transform.GetChild(2).GetChild(2).GetChild(1).gameObject.SetActive(true);
        canvas.gameObject.transform.GetChild(2).GetChild(2).GetChild(2).gameObject.SetActive(true);
        count = 0;

    }
    public void removeUI()
    {
        canvas.gameObject.transform.GetChild(2).gameObject.SetActive(false);
        



    }
    public int behaviorcontrol()
    {
        return count;
    }
}
