using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour
{
    public GameObject effect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other) {
        if(other.transform.CompareTag("Player"))
        {
            Vector3 vector3 = new Vector3(transform.position.x -1.0f,transform.position.y + 0.5f,transform.position.z);
            Debug.Log("»ý¼º");
            GameObject gameObject = Instantiate(effect, vector3, transform.rotation);
            Destroy(gameObject,0.5f);
           
        }
    }
}
