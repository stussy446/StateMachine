using TMPro;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("State Settings")]
    [SerializeField] private string _currentStateName;
    [SerializeField] private TMP_Text _stateNameText;
    private IEnemyState _currentState;

    // possible enemy states
    public PatrolState patrolState = new PatrolState();
    public AttackState attackState = new AttackState();
    public FleeState fleeState = new FleeState();

    [SerializeField] private float _currentHealth;
    [SerializeField] private bool _playerVisible;

    public bool PlayerVisible { get { return _playerVisible; } }
    public float CurrentHealth { get { return _currentHealth; } }

    /// <summary>
    /// Starts off the state in the patrolState
    /// </summary>
    private void OnEnable()
    {
        _currentState = patrolState;
    }

    /// <summary>
    /// Calls DoState on whatever the current state is. DoState is on each State class and transitions to other States as needed. Also changes currentStateName
    /// and its corresponding text in the scene 
    /// </summary>
    private void Update()
    {
        _currentState = _currentState.DoState(this);
        _currentStateName = _currentState.ToString();

        _stateNameText.text = _currentStateName;
    }

}
