using UnityEngine;
using System.Collections;

public interface IDamageable
{
    bool IsDead {
        get;set;
    }
    void Damage (float damage);
    void Kill ();
}