using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawn : MonoBehaviour
{
    public GameObject Item;
    public Transform[] SpawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void ItmeSpawn()
    {
        for (int i = 0; i < SpawnPoint.Length; i++)
        {
            Instantiate(Item, SpawnPoint[i].transform.position, Quaternion.identity);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
