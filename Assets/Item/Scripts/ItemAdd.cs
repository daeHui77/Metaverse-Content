using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ItemAdd : MonoBehaviour
{
    public int coinSum;
    public Text coinText;
    
    //코인 개수 표시
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Item"))
        {
            coinText.text = coinSum.ToString();
        }
    }
    //코인개수 가져오기
    public int GetCoinCount()
    {
       return coinSum;
    }
    //코인 갯수 더하기
    public void Coinsum(int coin)
    {
        coinSum += coin;
        Debug.Log(coinSum);
    }
     //코인 갯수 빼기
    public void CoinSubtract(int coin)
    {
        coinSum -= coin;
        coinText.text = coinSum.ToString();
    }
}
