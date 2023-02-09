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

    RaycastHit hit;
    Ray ray;
    public LayerMask layer;

    // Start is called before the first frame update
    void Start()
    {
        transformspeed = 5;
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

        Debug.DrawRay(gameObject.transform.position, gameObject.transform.forward * 10, Color.red);

        if (Physics.Raycast(raycast.transform.position, raycast.transform.forward , out hit, float.MaxValue, layer))
        {
           
            if (hit.distance < 1 && Input.GetKeyDown(KeyCode.G))
            {
                Destroy(hit.transform.gameObject);
                transform.position = new Vector3(-393.0f, 70.0f, 17.0f);
                character.transform.rotation = Quaternion.Euler(0.0f, -180.0f, 0.0f);
            }
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
                transform.Translate(character.transform.forward * transformspeed * Time.deltaTime);
            }
            //������ �ٱ�
            if (v == 1 && Input.GetKey(KeyCode.LeftShift))
            {
                transform.Translate(character.transform.forward * transformspeed * Time.deltaTime);
               
            }
            //�ڷ� �ȱ�
            if (v == -1)
            {
                transform.Translate((character.transform.forward * -1) * transformspeed * Time.deltaTime);
             
            }
            //�ڷ� �ٱ�
            if (v == -1 && Input.GetKey(KeyCode.LeftShift))
            {
                transform.Translate((character.transform.forward * -1) * transformspeed * Time.deltaTime);
               
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
