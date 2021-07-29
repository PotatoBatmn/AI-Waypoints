using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointAI : MonoBehaviour //PascalCasing
{
    [SerializeField] private float speed = 1f;
    [SerializeField] private GameObject goal;
    [SerializeField] private GameObject goal2;
    private GameObject currentGoal;

    private void Start()
    {
        currentGoal = goal;
    }
    // Update is called once per frame
    void Update()
    {
        float distance2 = Vector2.Distance(transform.position, goal.transform.position);


        if (distance2 > 0.01f)
        {
            Vector2 direction = (goal.transform.position - transform.position).normalized;
            Vector2 aiPosition = transform.position;
            aiPosition += direction * speed * Time.deltaTime;

            transform.position = aiPosition;
        }
        else
        {
            currentGoal = goal2;


        }
        








    }
}