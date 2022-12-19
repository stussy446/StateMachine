using UnityEngine;


public class Enemy : MonoBehaviour
{
    [Header("State Settings")]
    [SerializeField] private string _currentStateName;
    private IEnemyState _currentState;


    public PatrolState patrolState = new PatrolState();
    public AttackState attackState = new AttackState();
    public FleeState fleeState = new FleeState();

    [SerializeField] private float _currentHealth;
    [SerializeField] private bool _playerVisible;

    public bool PlayerVisible { get { return _playerVisible; } }
    public float CurrentHealth { get { return _currentHealth; } }

    private void OnEnable()
    {
        _currentState = patrolState;
    }

    private void Update()
    {
        _currentState = _currentState.DoState(this);
        _currentStateName = _currentState.ToString();
    }


}
