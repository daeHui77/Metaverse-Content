using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManagement : MonoBehaviour
{
    public GameObject canvas;
    bool moveBool;

   public GameObject player;
    public GameObject cameraPose;
    
    // Start is called before the first frame update
    void Start()
    {
        moveBool = true;
    }
    //���� ����� UI
    public void showGameUI()
    {
        canvas.gameObject.transform.GetChild(1).GetChild(0).gameObject.SetActive(true);
        canvas.gameObject.transform.GetChild(1).GetChild(0).GetChild(0).gameObject.SetActive(true);
        canvas.gameObject.transform.GetChild(1).GetChild(0).GetChild(1).gameObject.SetActive(true);
        canvas.gameObject.transform.GetChild(1).GetChild(0).GetChild(2).gameObject.SetActive(true);
        moveBool = false;
    }
    //���� ���� ��ư
    public void GameStart()
    {
        canvas.gameObject.transform.GetChild(1).GetChild(0).gameObject.SetActive(false);
        canvas.gameObject.transform.GetChild(1).GetChild(0).GetChild(0).gameObject.SetActive(false);
        canvas.gameObject.transform.GetChild(1).GetChild(0).GetChild(1).gameObject.SetActive(false);
        canvas.gameObject.transform.GetChild(1).GetChild(0).GetChild(2).gameObject.SetActive(false);
        moveBool = true;
    }
    //���� Ŭ���� UI
    public void GameClearUI()
    {
        canvas.gameObject.transform.GetChild(1).GetChild(1).gameObject.SetActive(true);
        canvas.gameObject.transform.GetChild(1).GetChild(1).GetChild(0).gameObject.SetActive(true);
        canvas.gameObject.transform.GetChild(1).GetChild(1).GetChild(1).gameObject.SetActive(true);

    }
    //���� ���â ���� ��ư 
    public void removeUI()
    {
        canvas.gameObject.transform.GetChild(1).GetChild(1).gameObject.SetActive(false);
    }
    //�ൿ���� 
    public bool behaviorcontrol()
    {
        return moveBool;
    }
    //�ǾƳ� ������ UI����
    public void PianoMapUnlock()
    {
        canvas.gameObject.transform.GetChild(2).GetChild(0).gameObject.SetActive(false);
        moveBool = true;
    }
    //�ǾƳ� ������ UI����
    public void ShowPianoUI()
    {
        canvas.gameObject.transform.GetChild(2).GetChild(0).gameObject.SetActive(true);
        moveBool = false;
    }
    //�ǾƳ� ������ �̵�
    public void MoveToPianoMap()
    {
        if(player.GetComponent<ItemAdd>().GetCoinCount() >= 100)
        {
            

            player.transform.position = new Vector3(-354.0f,70.0f,31.0f);

            cameraPose.transform.rotation = Quaternion.Euler(0.0f, 90.0f, 0);

            canvas.gameObject.transform.GetChild(2).GetChild(0).gameObject.SetActive(false);

            player.GetComponent<ItemAdd>().CoinSubtract(100);
             moveBool = true;
        }
    }
    //����UI����
    public void ExplanationRemove()
    {
        canvas.gameObject.transform.GetChild(3).gameObject.SetActive(false);
        moveBool = true;
    }
}
