using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFuc : MonoBehaviour
{
    public float transformspeed;
    float v;
    float h;
    private bool jumping; 
    public float JumpPower;
    private Rigidbody rigid;
    
    public GameObject cameraPose;
    public GameObject character;
    public GameObject raycast;
    public Canvas canvas;
    Animator animator;
    
    bool movebool;
    RaycastHit hit;
    Ray ray;
    public LayerMask layer1;
     public LayerMask layer2;
     public LayerMask layer3;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody>();
        JumpPower = 5;
        jumping = false;
        movebool = true;
    }

    // Update is called once per frame
    void Update()
    {
        movebool = GameObject.Find("UIManagement").GetComponent<UIManagement>().behaviorcontrol();
        if(movebool == true)
        {
            Jump();
            Raycast();
            Move();
        }
    }
    //?????????? ?????? ??????
    void Raycast()
    {
        Debug.DrawRay(raycast.transform.position, raycast.transform.forward * 10, Color.red);

        if (Physics.Raycast(raycast.transform.position, raycast.transform.forward , out hit, float.MaxValue, layer1))
        {
           
            if (hit.distance < 1 && Input.GetKeyDown(KeyCode.G))
            {
                transform.position = new Vector3(-394.0f,70.0f,10.0f);
                cameraPose.transform.rotation = Quaternion.Euler(0.0f, 90.0f, 0);
                GameObject.Find("UIManagement").GetComponent<UIManagement>().showGameUI();
                GameObject.Find("ItemSpawn").GetComponent<ItemSpawn>().ItmeSpawn();
            }
        }
         if (Physics.Raycast(raycast.transform.position, raycast.transform.forward , out hit, float.MaxValue, layer2))
        {
           
            if (hit.distance < 1 && Input.GetKeyDown(KeyCode.G))
            {
                GameObject.Find("UIManagement").GetComponent<UIManagement>().ShowPianoUI();
            }
        }
         if (Physics.Raycast(raycast.transform.position, raycast.transform.forward , out hit, float.MaxValue, layer3))
        {
            if (hit.distance < 1 && Input.GetKeyDown(KeyCode.G))
            {
                transform.position = new Vector3(-269.0f,70.0f,70.0f);
                cameraPose.transform.rotation = Quaternion.Euler(0.0f, 90.0f, 0);
            }
           
           
        }
    }
    
    public void MoveFast()
    {
        v = Input.GetAxisRaw("Vertical");
        //?????? ???
        if (v == 1 && Input.GetKey(KeyCode.LeftShift))
        {
            GetComponent<CharacterStatus>().TakeStaminaDamage(20);
            transform.Translate(transformspeed * Time.deltaTime* character.transform.forward);
        }
        //??? ???
        if (v == -1 && Input.GetKey(KeyCode.LeftShift))
        {
            GetComponent<CharacterStatus>().TakeStaminaDamage(20);
            transform.Translate(transformspeed * Time.deltaTime* (character.transform.forward * -1));

        }
    }
    void Move()
    {
        
        v = Input.GetAxisRaw("Vertical");
        h = Input.GetAxisRaw("Horizontal");

        if (v != 0)
        {
            //?????? ???
            if(v == 1)
            {
                
                transform.Translate( transformspeed * Time.deltaTime* character.transform.forward);
                
            }
           
            //??? ???
            if (v == -1)
            {
                transform.Translate( transformspeed * Time.deltaTime* (character.transform.forward * -1));
             
            }
           
        }
        if( h != 0)
        {
            //?????????? ???
            if (h == 1)
            {
                
                transform.Translate(character.transform.right * transformspeed * Time.deltaTime);
              
            }
            //??????????  ???
            if (h == 1 && Input.GetKey(KeyCode.LeftShift))
            {
                transform.Translate(character.transform.right * transformspeed * Time.deltaTime);
              
            }
            //???????? ???
            if (h == -1)
            {
                transform.Translate((character.transform.right * -1) * transformspeed * Time.deltaTime);
               
            }
            //???????? ???
            if (h == -1 && Input.GetKey(KeyCode.LeftShift))
            {
                transform.Translate((character.transform.right * -1) * transformspeed * Time.deltaTime);
                 
               
            }
        }
    }
    void Jump()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(!jumping)
            {
                jumping = true;
                rigid.AddForce(Vector3.up * JumpPower , ForceMode.Impulse);
            }
            else{
                return;
            }
        }
    }
    private void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.CompareTag("Untagged"))
        {
            jumping = false;
        }
        if(collision.gameObject.CompareTag("ArrivalPoint"))
        {
            GameObject.Find("UIManagement").GetComponent<UIManagement>().GameClearUI();
            transform.position = new Vector3(-268.0f,70.0f,69.0f);
             cameraPose.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0);
        }
    }
    public void GameReset()
    {
        transform.position = new Vector3(-394.0f,70.0f,10.0f);
        cameraPose.transform.rotation = Quaternion.Euler(0.0f, 90.0f, 0);
    }
}
