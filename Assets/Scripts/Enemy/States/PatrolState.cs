using UnityEngine;

public class PatrolState : IEnemyState
{
    public IEnemyState DoState(Enemy enemy)
    {
        Material mat = enemy.GetComponent<MeshRenderer>().material;
        if (mat.color != Color.green)
        {
            mat.color = Color.green;
        }

        // changes states based on the enemies health and if the player is visible
        if (enemy.PlayerVisible && enemy.CurrentHealth >= 5f) 
        {
            return enemy.attackState;
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
