using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStatus : MonoBehaviour
{
    public int maxHealth = 100;
    public float maxStamina = 100;

    public int currentHealth;
    public HealthBar healthBar;

    public float currentStamina;
    public Staminabar staminaBar;

    float timer;
    float waitingTime;
    public bool git;
    // Start is called before the first frame update
    void Start()
    {
        git = false;
        timer = 0.0f;
        waitingTime = 2.0f;
        currentHealth = maxHealth;
        currentStamina = maxStamina;

        healthBar.SetMaxHealth(maxHealth);
        staminaBar.SetMaxStamina(maxStamina);
    }

    // Update is called once per frame
    void Update()
    {
        UseStamina();
        if (Input.GetKeyDown(KeyCode.K))
        {
            TakeDamage(20);
        }
        
    }
    public void UseStamina()
    {
        
        if (git == false)
        {
            GetComponent<MoveFuc>().MoveFast();
            //TakeStaminaDamage(20);
        }
        if (currentStamina < 0)
        {
            git = true;
            //Time.deltaTime로 딜레이주기
            timer += Time.deltaTime;
            //Debug.Log(timer);
            //Debug.Log(Time.deltaTime);

            //딜레이 이후 실행
            if (timer > waitingTime)
            {
                timer = 0.0f;
                waitingTime = 2.0f;
                Debug.Log("1");
                TakeStaminaHealing(100);
                git = false;
            }
        }
    }
    //체력바 데미지 입음
    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }
    //스테미너 소모
    public void TakeStaminaDamage(int num)
    {
        currentStamina -= num * Time.deltaTime ;
        staminaBar.SetStamina(currentStamina);
    }
    //스테미너 회복
    void TakeStaminaHealing(int num)
    {
        currentStamina = num;
        staminaBar.SetStamina(currentStamina);
    }
}
