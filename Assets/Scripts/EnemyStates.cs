using System.Collections;
using UnityEngine;

public class EnemyStates : MonoBehaviour
{
    public enum EnemyState
    {
        Patrolling,
        Attacking,
        Chasing,
        Death
    }

    public EnemyState currentState;

    private void Start()
    {
        StartCoroutine(ChangeState());
    }

    private void Update()
    {
        switch (currentState)
        {
            case EnemyState.Patrolling:
                Debug.Log("Enemy is " + currentState);
                GetComponent<MeshRenderer>().material.color = Color.green;
                break;
            case EnemyState.Attacking:
                Debug.Log("Enemy is " + currentState);
                GetComponent<MeshRenderer>().material.color = Color.red;
                break;
            case EnemyState.Chasing:
                Debug.Log("Enemy is " + currentState);
                GetComponent<MeshRenderer>().material.color = Color.blue;
                break;
            case EnemyState.Death:
                Debug.Log("Enemy is dead");
                GetComponent<MeshRenderer>().material.color = Color.black;
                break;
        }

        if (Input.GetKeyDown(KeyCode.Space)) currentState = EnemyState.Chasing;
    }

    private IEnumerator ChangeState()
    {
        while (true)
        {
            currentState = (EnemyState) Random.Range(0, 4);
            yield return new WaitForSeconds(5f);
        }
    }
}