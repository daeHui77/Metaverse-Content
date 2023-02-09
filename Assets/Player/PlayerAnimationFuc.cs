using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationFuc : MonoBehaviour
{
    float v;
    float h;
    Animator animator;

    public AudioClip[] audiosource;
    AudioSource audioSource;
   
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        Move();
    }
    //오디오를 이용해 걷는 소리
    public void EventWalkCall()
    {
        
        audioSource.clip = audiosource[0];
        audioSource.Play();
    }
    public void EventRunCall()
    {
        
        audioSource.clip = audiosource[1];
        audioSource.Play();
    }
    public void EventJumpCall()
    {
        Debug.Log("점프 소리");
        audioSource.clip = audiosource[2];
        audioSource.Play();
    }
    void Move()
    {
        v = Input.GetAxisRaw("Vertical");
        h = Input.GetAxisRaw("Horizontal");

        //idle상태
        animator.SetBool("Walk", false);
        animator.SetBool("Run", false);
        animator.SetBool("BackWalk", false);
        animator.SetBool("BackRun", false);

        if (v != 0)
        {
            //앞으로 걷기
            if (v == 1)
            {
                animator.SetBool("Walk", true);
            }
            //앞으로 뛰기
            if (v == 1 && Input.GetKey(KeyCode.LeftShift))
            {
                animator.SetBool("Walk", true);
                animator.SetBool("Run", true);
            }
            //뒤로 걷기
            if (v == -1)
            {
                animator.SetBool("BackWalk", true);
            }
            //뒤로 뛰기
            if (v == -1 && Input.GetKey(KeyCode.LeftShift))
            {
                animator.SetBool("BackWalk", true);
                animator.SetBool("BackRun", true);
            }
        }
        if (h != 0)
        {
            //오른쪽으로 걷기
            if (h == 1)
            {
                animator.SetBool("Walk", true);
            }
            //오른쪽으로 뛰기
            if (h == 1 && Input.GetKey(KeyCode.LeftShift))
            {
                animator.SetBool("Walk", true);
                animator.SetBool("Run", true);
            }
            //왼쪽으로 걷기
            if (h == -1)
            {
                animator.SetBool("Walk", true);
            }
            //왼쪽으로 뛰기
            if (h == -1 && Input.GetKey(KeyCode.LeftShift))
            {
                animator.SetBool("Walk", true);
                animator.SetBool("Run", true);
            }
        }
    }
}
