using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public AudioClip[] gameAudiosource;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            audioSource.clip = gameAudiosource[0];
            audioSource.Play();
            Destroy(transform.gameObject);
            Debug.Log("ªË¡¶");
        }
        
    }
}
