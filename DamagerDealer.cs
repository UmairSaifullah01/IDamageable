using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagerDealer : MonoBehaviour
{
    public float damageAmount;
    public string enemyTag;
    public void OnTriggerEnter (Collider col)
    {
        if (col.attachedRigidbody && col.attachedRigidbody.CompareTag (enemyTag))
        {
            IDamageable damageable = col.GetComponent<HealthSystem> ();
            if (damageable != null)
            {
                damageable.Damage (damageAmount);
            }
        }
    }
}
