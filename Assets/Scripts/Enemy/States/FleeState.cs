using UnityEngine;

public class FleeState : IEnemyState
{
    public IEnemyState DoState(Enemy enemy)
    {
        Material mat = enemy.GetComponent<MeshRenderer>().material;

        if (mat.color != Color.blue)
        {
            mat.color = Color.blue;
        }

        // changes states based on the enemies health and if the player is visible
        if (enemy.PlayerVisible && enemy.CurrentHealth >= 5f)
        {
            return enemy.attackState;
        }
        else if (enemy.CurrentHealth >= 5f)
        {
            return enemy.patrolState;
        }
        else
        {
            return this;
        }
    }
}
