using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PianoSound : MonoBehaviour
{
     AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other) {
        if(other.transform.CompareTag("Player"))
        {
            audioSource.Play();
                  
        }
    }
}
