using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointAI : MonoBehaviour //PascalCasing
{
    [SerializeField] private float speed = 1f; //camelCasing
    [SerializeField] private GameObject goal;
    [SerializeField] private GameObject goal2;
    private GameObject currentGoal;
    // == equal to
    // != not equal to
    // < less than
    // > greater than
    // <= less than or equal to
    // >= greater than or equal to
    // && and- both have to be true
    // || or- if either one is true
    //task: move ai to as second goal after reaching the first
    //i will have my headset off, type if u have a question
    private void Start()
    {
        currentGoal = goal;
    }
    void Update()
    {
        // float distance = (goal.transform.position - transform.position).magnitude;
        float distance2 = Vector2.Distance(transform.position, currentGoal.transform.position);
        if (distance2 > 0.01f)
        {
            //the direction from A to B
            //direction = B - A
            Vector2 direction = (currentGoal.transform.position - transform.position).normalized;
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