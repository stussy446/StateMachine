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

        return this;
    }
}
