using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFuc : MonoBehaviour
{
    public float transformspeed;
    float v;
    float h;

    
    public GameObject cameraPose;
    public GameObject character;
    public GameObject raycast;
    public Canvas canvas;

    RaycastHit hit;
    Ray ray;
    public LayerMask layer;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
       
        Raycast();
        Move();
    }
    //�����ɽ�Ʈ�� �̿��Ͽ� ��ȣ�ۿ�
    void Raycast()
    {
        
        //ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        Debug.DrawRay(raycast.transform.position, raycast.transform.forward * 10, Color.red);

        if (Physics.Raycast(raycast.transform.position, raycast.transform.forward , out hit, float.MaxValue, layer))
        {
           
            if (hit.distance < 1 && Input.GetKeyDown(KeyCode.G))
            {
                transform.position = new Vector3(-400, 70.0f, 10);
                character.transform.rotation = Quaternion.Euler(0.0f, -90.0f, 0.0f);
                GameObject.Find("UIManagement").GetComponent<UIManagement>().showGameUI();
                GameObject.Find("ItemSpawn").GetComponent<ItemSpawn>().ItmeSpawn();
            }
        }
    }
    public void MoveFast()
    {
        v = Input.GetAxisRaw("Vertical");
        //������ �ٱ�
        if (v == 1 && Input.GetKey(KeyCode.LeftShift))
        {
            GetComponent<CharacterStatus>().TakeStaminaDamage(20);
            transform.Translate(transformspeed * Time.deltaTime* character.transform.forward);
        }
        //�ڷ� �ٱ�
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
            //������ �ȱ�
            if(v == 1)
            {
                
                transform.Translate( transformspeed * Time.deltaTime* character.transform.forward);
                
            }
           
            //�ڷ� �ȱ�
            if (v == -1)
            {
                transform.Translate( transformspeed * Time.deltaTime* (character.transform.forward * -1));
             
            }
           
        }
        if( h != 0)
        {
            //���������� �ȱ�
            if (h == 1)
            {
                
                transform.Translate(character.transform.right * transformspeed * Time.deltaTime);
              
            }
            //����������  �ٱ�
            if (h == 1 && Input.GetKey(KeyCode.LeftShift))
            {
                transform.Translate(character.transform.right * transformspeed * Time.deltaTime);
              
            }
            //�������� �ȱ�
            if (h == -1)
            {
                transform.Translate((character.transform.right * -1) * transformspeed * Time.deltaTime);
               
            }
            //�������� �ٱ�
            if (h == -1 && Input.GetKey(KeyCode.LeftShift))
            {
                transform.Translate((character.transform.right * -1) * transformspeed * Time.deltaTime);
                 
               
            }
        }
    }
}
