using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ItemAdd : MonoBehaviour
{
    public int coinSum;
    public int coinCount;
    public Text coinText;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Item"))
        {
            coinText.text = "소지 코인 = " + coinSum;
        }
    }
    public void CoinCount()
    {
        coinCount += 1;
    }
    public int GetCoinCount()
    {
       return coinCount;
    }
    public void Coinsum(int coin)
    {
        coinSum += coin;
    }
}
