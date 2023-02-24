using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawn : MonoBehaviour
{
    public GameObject Item;
    public Transform[] SpawnPoint;
    //������ ����
    public void ItmeSpawn()
    {
        for (int i = 0; i < SpawnPoint.Length; i++)
        {
            Instantiate(Item, SpawnPoint[i].transform.position, Quaternion.identity);
        }
    }
}
