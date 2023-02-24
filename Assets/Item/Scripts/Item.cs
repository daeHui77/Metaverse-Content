using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public AudioClip[] gameAudiosource;
    AudioSource audiosource;
    Animator animator;

    int[] coinScore = new int[3];
  
    // Start is called before the first frame update
    void Start()
    {
        coinScore[0] = 10;
        coinScore[1] = 50;
        coinScore[2] = 100;

        animator = GetComponent<Animator>();
        audiosource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            GetComponent<MeshCollider>().enabled = false;
            EventItemSound();
            animator.SetTrigger("ItemAdd");
            Destroy(transform.gameObject,0.5f);
            other.GetComponent<ItemAdd>().Coinsum(coinScore[0]);
        }
    }
    public void EventItemSound()
    {
        audiosource.clip = gameAudiosource[0];
        audiosource.Play();
    }
}
