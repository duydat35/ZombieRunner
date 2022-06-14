using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float hitPoints = 100f;
    [SerializeField] Slider slider;

    bool isDead = false;

    private void Start()
    {
        slider.maxValue = hitPoints;
    }

    public void Update()
    {
        slider.value = hitPoints;
    }

    public bool IsDead()
    {
        return isDead;
    }

    public void TakeDamage(float damage)
    {
        BroadcastMessage("OnDamageTaken");
        hitPoints -= damage;
        if (hitPoints <= 0)
        {
            Die();
        }
    }
    public void Die()
    {
        if (isDead) return;
        isDead = true;
        slider.gameObject.SetActive(false);
        GetComponent<Animator>().SetTrigger("die");
    }
}
