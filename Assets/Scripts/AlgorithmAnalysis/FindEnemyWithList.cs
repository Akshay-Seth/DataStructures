using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindEnemyWithList : MonoBehaviour
{
    public Transform playerTransform;
    public List<Transform> enemyTransforms;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(FindClosestEnemy().name);

    }

    
    public Transform FindClosestEnemy()
    {
        Transform closestEnemy = null;

        float closestDistance = float.MaxValue;

        foreach (Transform enemyTransform in enemyTransforms)
        {
            float distanceToEnemy = Vector3.Distance(playerTransform.position, enemyTransform.position);
            if (distanceToEnemy < closestDistance)
            {
                closestDistance = distanceToEnemy;
                closestEnemy = enemyTransform;
                Debug.Log($"Closest enemy is {closestEnemy.name} and the distance to enemy is {closestDistance}");
            }
            Debug.Log("Checked " + enemyTransform.name);
        }

        return closestEnemy;
    }
}
