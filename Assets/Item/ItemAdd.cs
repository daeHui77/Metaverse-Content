using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ItemAdd : MonoBehaviour
{
    public int coinSum;
    public Text coinText;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Item"))
        {
            coinText.text = "���� ���� = " + coinSum;
        }
    }
    public void Coinsum(int coin)
    {
        coinSum += coin;
    }
}
