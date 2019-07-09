using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour, IDamageable
{
    private float health; public float maxHealth;
    public Image healthBar;
    public UnityEvent onDeath;
    public bool IsDead
    {
        get;
        set;
    }

    public void Damage (float damage)
    {
        if (IsDead)
            return;
        health -= damage;
        if (healthBar != null)
        {
            healthBar.fillAmount = Mathf.Clamp01 (health / maxHealth);
        }
        if (health < 1)
        {
            Kill ();
        }
    }

    public void Kill ()
    {
        IsDead = true;
        onDeath.Invoke ();
    }

    // Start is called before the first frame update
    void Start ()
    {
        health = maxHealth;
    }


}
