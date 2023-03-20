using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterScript : MonoBehaviour
{
    Animator animator;
    float speed;
    float time;
    float rota;
    
    // Start is called before the first frame update
    void Start()
    {
        speed = 5;
        time = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        Move();
    }

    void Move()
    {
        
        if(time > 2.0f)
        {
            time = 0.0f;
            rota = transform.rotation.eulerAngles.y;
            rota += 180;
            Vector3 vec3 = new Vector3(0,rota,0);
            transform.rotation = Quaternion.Euler(vec3);
        }

        transform.Translate( speed * Time.deltaTime* Vector3.forward);
    }
}
