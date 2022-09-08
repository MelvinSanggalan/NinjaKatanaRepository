using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class SwordDashAbility : Ability
{
    public float dashSpeed;
    public float dashTime;

    public override void Activate(GameObject parent)
    {
        PlayerController moveScript = parent.GetComponent<PlayerController>();

        float startTime = Time.time;

    }

}
