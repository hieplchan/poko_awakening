using System.Collections;
using System.Collections.Generic;
using KBCore.Refs;
using UnityEngine;

public class Player : Entity, IDamageable
{
    [SerializeField, Self] public PlayerControllerComponent ControllerComp;

    public void TakeDamage(int damage)
    {
        HealthComp?.TakeDamage(damage);
    }
}
