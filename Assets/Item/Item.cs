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
            EventItemSound();
            animator.SetTrigger("ItemAdd");
            Destroy(transform.gameObject,1.0f);
            other.GetComponent<ItemAdd>().Coinsum(coinScore[0]);
            Debug.Log("삭제");
        }
    }
    public void EventItemSound()
    {
        Debug.Log("먹는 소리");
        audiosource.clip = gameAudiosource[0];
        audiosource.Play();
    }
}
