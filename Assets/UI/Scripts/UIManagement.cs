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
    //게임 입장시 UI
    public void showGameUI()
    {
        canvas.gameObject.transform.GetChild(1).GetChild(0).gameObject.SetActive(true);
        canvas.gameObject.transform.GetChild(1).GetChild(0).GetChild(0).gameObject.SetActive(true);
        canvas.gameObject.transform.GetChild(1).GetChild(0).GetChild(1).gameObject.SetActive(true);
        canvas.gameObject.transform.GetChild(1).GetChild(0).GetChild(2).gameObject.SetActive(true);
        moveBool = false;
    }
    //게임 시작 버튼
    public void GameStart()
    {
        canvas.gameObject.transform.GetChild(1).GetChild(0).gameObject.SetActive(false);
        canvas.gameObject.transform.GetChild(1).GetChild(0).GetChild(0).gameObject.SetActive(false);
        canvas.gameObject.transform.GetChild(1).GetChild(0).GetChild(1).gameObject.SetActive(false);
        canvas.gameObject.transform.GetChild(1).GetChild(0).GetChild(2).gameObject.SetActive(false);
        moveBool = true;
    }
    //게임 클리어 UI
    public void GameClearUI()
    {
        canvas.gameObject.transform.GetChild(1).GetChild(1).gameObject.SetActive(true);
        canvas.gameObject.transform.GetChild(1).GetChild(1).GetChild(0).gameObject.SetActive(true);
        canvas.gameObject.transform.GetChild(1).GetChild(1).GetChild(1).gameObject.SetActive(true);

    }
    //게임 결과창 제거 버튼 
    public void removeUI()
    {
        canvas.gameObject.transform.GetChild(1).GetChild(1).gameObject.SetActive(false);
    }
    //행동제약 
    public bool behaviorcontrol()
    {
        return moveBool;
    }
    //피아노 컨텐츠 UI제거
    public void PianoMapUnlock()
    {
        canvas.gameObject.transform.GetChild(2).GetChild(0).gameObject.SetActive(false);
        moveBool = true;
    }
    //피아노 컨텐츠 UI생성
    public void ShowPianoUI()
    {
        canvas.gameObject.transform.GetChild(2).GetChild(0).gameObject.SetActive(true);
        moveBool = false;
    }
    //피아노 컨텐츠 이동
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
    //설명UI제거
    public void ExplanationRemove()
    {
        canvas.gameObject.transform.GetChild(3).gameObject.SetActive(false);
        moveBool = true;
    }
}
