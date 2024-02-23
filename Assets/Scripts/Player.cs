using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player instance { get; private set; }

    [SerializeField] public int hpPoints;
    public float speed;

private void Awake()
    {
        instance = this;
    }

    public void TakeDamage(int damageTaken)
    {
        hpPoints -= damageTaken;

        if (hpPoints <= 0)
        {
            speed = 0;
            Debug.Log("Game Over");
        }
    }    
}
