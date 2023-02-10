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
    //������� �̿��� �ȴ� �Ҹ�
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
        Debug.Log("���� �Ҹ�");
        audioSource.clip = audiosource[2];
        audioSource.Play();
    }
    void Move()
    {
        v = Input.GetAxisRaw("Vertical");
        h = Input.GetAxisRaw("Horizontal");

        //idle����
        animator.SetBool("Walk", false);
        animator.SetBool("Run", false);
        animator.SetBool("BackWalk", false);
        animator.SetBool("BackRun", false);

        if (v != 0)
        {
            //������ �ȱ�
            if (v == 1)
            {
                animator.SetBool("Walk", true);
            }
            //������ �ٱ�
            if (v == 1 && Input.GetKey(KeyCode.LeftShift))
            {
                animator.SetBool("Walk", true);
                animator.SetBool("Run", true);
            }
            //�ڷ� �ȱ�
            if (v == -1)
            {
                animator.SetBool("BackWalk", true);
            }
            //�ڷ� �ٱ�
            if (v == -1 && Input.GetKey(KeyCode.LeftShift))
            {
                animator.SetBool("BackWalk", true);
                animator.SetBool("BackRun", true);
            }
        }
        if (h != 0)
        {
            //���������� �ȱ�
            if (h == 1)
            {
                animator.SetBool("Walk", true);
            }
            //���������� �ٱ�
            if (h == 1 && Input.GetKey(KeyCode.LeftShift))
            {
                animator.SetBool("Walk", true);
                animator.SetBool("Run", true);
            }
            //�������� �ȱ�
            if (h == -1)
            {
                animator.SetBool("Walk", true);
            }
            //�������� �ٱ�
            if (h == -1 && Input.GetKey(KeyCode.LeftShift))
            {
                animator.SetBool("Walk", true);
                animator.SetBool("Run", true);
            }
        }
    }
}
