using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float playerHealth = 100f;
    [SerializeField] TextMeshProUGUI healthText;

    private void Update()
    {
        healthText.text = "Health: " + playerHealth.ToString();
    }
    public void playerTakeDamage(float damage)
    {
        playerHealth -= damage;
        if(playerHealth <= 0)
        {
            playerHealth = 0;
            GetComponent<DeathHandler>().HandleDeath();
        }
    }
}
