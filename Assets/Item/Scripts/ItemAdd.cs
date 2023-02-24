using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ItemAdd : MonoBehaviour
{
    public int coinSum;
    public Text coinText;
    
    //���� ���� ǥ��
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Item"))
        {
            coinText.text = coinSum.ToString();
        }
    }
    //���ΰ��� ��������
    public int GetCoinCount()
    {
       return coinSum;
    }
    //���� ���� ���ϱ�
    public void Coinsum(int coin)
    {
        coinSum += coin;
        Debug.Log(coinSum);
    }
     //���� ���� ����
    public void CoinSubtract(int coin)
    {
        coinSum -= coin;
        coinText.text = coinSum.ToString();
    }
}
