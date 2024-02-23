using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AggressiveAnimal : MonoBehaviour
{
    [SerializeField] private int attackValue;
    [SerializeField] private int hpMaxValue;
    [SerializeField] private int hpCurValue;

    public Slider healthBar;

    private void Start()
    {
        //hpCurValue = hpMaxValue;
        healthBar = GetComponent<Slider>();
    }

    public void DamageRecive(int damage)
    {
        hpCurValue -= damage;
    }

    public void SetHealth()
    {
        healthBar.value = hpCurValue;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Player.instance.TakeDamage(attackValue);
        }
    }

    /*
    playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<Health>();
    healthBar.maxValue = playerHealth.maxHealth;
    healthBar.value = playerHealth.maxHealth;
    */
}
