using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackState : IEnemyState
{
    public IEnemyState DoState(Enemy enemy)
    {
        Material mat = enemy.GetComponent<MeshRenderer>().material;
        if (mat.color != Color.red)
        {
            mat.color = Color.red;
        }

        // changes states based on the enemies health and if the player is visible
        if (!enemy.PlayerVisible && enemy.CurrentHealth >= 5f)
        {
            return enemy.patrolState;
        }
        else if (enemy.CurrentHealth < 5f)
        {
            return enemy.fleeState;
        }
        else
        {
            return this;
        }
    }
}
