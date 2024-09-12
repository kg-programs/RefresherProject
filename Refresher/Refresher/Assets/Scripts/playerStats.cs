using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerStats : MonoBehaviour
{
    [SerializeField] Stat maxHealth;

    [SerializeField] Stat currentHealth;

    [SerializeField] bool decreaseHealth;

    //float timeToDecrease = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth.amount = maxHealth.amount;

        StartCoroutine(DrainHealth());

        decreaseHealth = false;
    }

    // Update is called once per frame
    void Update()
    {
       /* if (decreaseHealth)
        {
            timeToDecrease -= Time.deltaTime;
            if (timeToDecrease <= 0.0f)
            {
                currentHealth.amount -= 1;
                timeToDecrease = 1.0f;
            }
        }*/
    }

   /* public void UseHealth(float amount)
    {
        currentHealth.amount -= (int)amount;
        if(currentHealth.amount <= 0)
        {
            currentHealth.amount = 0;
        }
    }*/

    public void hurt()
    {
        decreaseHealth = true;
    }

    public void stopHurt()
    {
        decreaseHealth = false;
    }

    IEnumerator DrainHealth()
    {
        while (currentHealth.amount > 0)
        {
            if (decreaseHealth)
            {
                currentHealth.amount -= 1;

                yield return new WaitForSeconds(2.0f);
            }
        }

    }
}
